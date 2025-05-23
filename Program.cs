using System;
using System.Collections.Generic;
using System.Linq;
using VolleyballPMS;
using PMSDataPlayer;

public class Program
{
    static PlayerService playerService;

    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\t---------------- Volleyball Players Profile Management System ----------------");

        ChooseStorageType();

        if (!AdminLogin())
        {
            Console.WriteLine("\nProgram will exit now.");
            return;
        }

        MainMenu();
    }

    static void ChooseStorageType()
    {
        Console.WriteLine("[1] In-Memory");
        Console.WriteLine("[2] JSON File");
        Console.WriteLine("[3] Text File");
        Console.Write("Choose data storage type: ");

        int storageChoice;
        while (!int.TryParse(Console.ReadLine(), out storageChoice) || storageChoice < 1 || storageChoice > 3)
        {
            Console.WriteLine("Invalid input. Please choose 1, 2, or 3:");
        }

        switch (storageChoice)
        {
            case 1:
                playerService = new PlayerService(new InMemoryPlayerData());
                break;
            case 2:
                playerService = new PlayerService(new JsonFilePlayerData());
                break;
            case 3:
                playerService = new PlayerService(new TextFilePlayerData());
                break;
        }

        Console.WriteLine($"\nStorage type selected: {(storageChoice == 1 ? "In-Memory" : storageChoice == 2 ? "JSON File" : "Text File")}");
    }

    static bool AdminLogin()
    {
        string adminUsername = "batakmagvball";
        string adminPassword = "jess";
        string adminResetCode = "vball11";

        int loginAttempts = 0;
        const int maxAttempts = 3;

        while (true)
        {
            Console.Write("\nEnter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == adminUsername && password == adminPassword)
            {
                Console.WriteLine("\n\t---------------- LOGIN SUCCESSFUL ----------------");
                return true;
            }

            loginAttempts++;
            Console.WriteLine($"\n\t [ERROR]: Incorrect username or password. Attempts left: << {maxAttempts - loginAttempts} >> ");

            if (loginAttempts >= maxAttempts)
            {
                Console.WriteLine("\nSorry... Too many login failed.\n");
                Console.Write("If you're the admin, enter the reset code to change credentials: ");
                string resetCode = Console.ReadLine();

                if (resetCode == adminResetCode)
                {
                    Console.WriteLine("\nYou can now reset your username and password.");

                    Console.Write("Enter new username: ");
                    adminUsername = Console.ReadLine();

                    Console.Write("Enter new password: ");
                    adminPassword = Console.ReadLine();

                    loginAttempts = 0;
                    Console.WriteLine("\nCredentials reset. Please login with new credentials.");
                }
                else
                {
                    Console.WriteLine("\n\t[ACCESS DENIED]: Invalid reset code. Program will exit......");
                    return false;
                }
            }
        }
    }

    static void MainMenu()
    {
        string[] options = {
            "[1] Create Profile",
            "[2] Edit Profile",
            "[3] View Profile",
            "[4] Delete Profile",
            "[5] Search Profile",
            "[6] Exit Program"
        };

        int choice;

        do
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("Please select an option to proceed");

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.Write("\nEnter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("\n\t********** Invalid input: Choose a number between 1-6.**********");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateProfile();
                    break;
                case 2:
                    EditProfile();
                    break;
                case 3:
                    ViewProfile();
                    break;
                case 4:
                    DeleteProfile();
                    break;
                case 5:
                    SearchProfile();
                    break;
                case 6:
                    Console.WriteLine("\nEXITING THE PROGRAM.");
                    Environment.Exit(0);
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine("\n*Press any key to continue* ");
                Console.ReadKey();
            }

        } while (choice != 6);
    }

    static string GetValidInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                Console.WriteLine("Input cannot be empty. Please try again.");
        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }

    static void CreateProfile()
    {
        Console.WriteLine("\nYou selected >>> CREATE PROFILE <<< ");

        string name = GetValidInput("Enter a player name: ");

        int age;
        while (true)
        {
            Console.Write("Enter a player age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                break;
            Console.WriteLine("\n\t********** ERROR: Please enter a valid positive number for age. **********\n");
        }

        string position = GetValidInput("Enter player's position (e.g. Spiker, Libero, Setter): ");

        if (playerService.AddPlayer(name, age, position))
            Console.WriteLine("\n\t---------------- Player's Profile ADDED successfully! ----------------");
        else
            Console.WriteLine("\n\t[ERROR] Failed to add player profile.");
    }

    static void EditProfile()
    {
        Console.WriteLine("\nYou selected >>> EDIT PROFILE <<<");

        string name = GetValidInput("Enter the name of the player to edit: ");
        var player = playerService.GetPlayerByName(name);

        if (player == null)
        {
            Console.WriteLine($"\nPlayer with name '{name}' not found.");
            return;
        }

        Console.WriteLine("[1] Name");
        Console.WriteLine("[2] Age");
        Console.WriteLine("[3] Position");
        Console.WriteLine("[4] All fields");
        Console.Write("\nSelect field to edit:");


        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid input. Choose 1 to 4.");
        }

        switch (choice)
        {
            case 1:
                string newName = GetValidInput("Enter new name: ");
                player.Name = newName;
                break;
            case 2:
                int newAge;
                while (true)
                {
                    Console.Write("Enter new age: ");
                    if (int.TryParse(Console.ReadLine(), out newAge) && newAge > 0)
                        break;
                    Console.WriteLine("Please enter a valid positive age.");
                }
                player.Age = newAge;
                break;
            case 3:
                string newPosition = GetValidInput("Enter new position: ");
                player.Position = newPosition;
                break;
            case 4:
                string allName = GetValidInput("Enter new name: ");

                int allAge;
                while (true)
                {
                    Console.Write("Enter new age: ");
                    if (int.TryParse(Console.ReadLine(), out allAge) && allAge > 0)
                        break;
                    Console.WriteLine("Please enter a valid positive age.");
                }

                string allPosition = GetValidInput("Enter new position: ");

                player.Name = allName;
                player.Age = allAge;
                player.Position = allPosition;
                break;
        }

        if (playerService.UpdatePlayer(name, player))
            Console.WriteLine("\n\t---------------- Player's Profile UPDATED successfully! ----------------");
        else
            Console.WriteLine("\n\t[ERROR] Failed to update player profile.");
    }

    static void ViewProfile()
    {
        Console.WriteLine("\nYou selected >>> VIEW PROFILE <<<");

        var players = playerService.GetAllPlayers();

        if (playerService.GetAllPlayers().Count == 0)
        {
            Console.WriteLine("\nNo player profiles found. Please add a player first.");
            return;
        }

        Console.WriteLine("\n-- Players List --");
        foreach (var p in players)
        {
            Console.WriteLine($"Name: {p.Name} | Age: {p.Age} | Position: {p.Position}");
        }
    }

    static void DeleteProfile()
    {
        Console.WriteLine("\nYou selected >>> DELETE PROFILE <<<");

        string name = GetValidInput("Enter the name of the player to delete: ");

        if (playerService.DeletePlayer(name))
            Console.WriteLine("\n\t---------------- Player's Profile DELETED successfully! ----------------");
        else
            Console.WriteLine($"\nPlayer with name '{name}' not found.");
    }

    static void SearchProfile()
    {
        Console.WriteLine("\nYou selected >>> SEARCH PROFILE <<<");

        string searchTerm = GetValidInput("Enter name or part of name to search: ");

        var results = playerService.SearchPlayersByName(searchTerm);

        if (playerService.GetAllPlayers().Count == 0)
        {
            Console.WriteLine("\nNo player profiles found. Please add a player first..");
            return;
        }

        Console.WriteLine("\n-- Search Results --");
        foreach (var p in results)
        {
            Console.WriteLine($"Name: {p.Name} | Age: {p.Age} | Position: {p.Position}");
        }
    }
}
