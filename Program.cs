using System;
using System.Collections.Generic;
using VolleyballPMS;
using PMSDataPlayer;
using PlayerCommon;

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
        Console.WriteLine("[4] Database");
        Console.Write("Choose data storage type: ");

        int storageChoice = GetValidatedNumberInput(1, 4);

        playerService = storageChoice switch
        {
            1 => new PlayerService(new InMemoryPlayerData()),
            2 => new PlayerService(new JsonFilePlayerData()),
            3 => new PlayerService(new TextFilePlayerData()),
            4 => new PlayerService(new DBDataPlayer()),
            _ => throw new Exception("Invalid storage type.")
        };

        string storageName = storageChoice switch
        {
            1 => "In-Memory",
            2 => "JSON File",
            3 => "Text File",
            4 => "Database",
            _ => "Unknown"
        };

        Console.WriteLine($"\nStorage type selected: {storageName}");
    }

    static bool AdminLogin()
    {
        string adminUsername = "batakmagvball";
        string adminPassword = "jess";
        string resetCode = "vball11";

        int attempts = 0;
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

            attempts++;
            Console.WriteLine($"\n\t[ERROR]: Incorrect credentials. Attempts left: << {maxAttempts - attempts} >>");

            if (attempts >= maxAttempts)
            {
                Console.WriteLine("\nToo many failed attempts.");
                Console.Write("Enter reset code to update credentials: ");
                string inputCode = Console.ReadLine();

                if (inputCode == resetCode)
                {
                    adminUsername = GetValidInput("Enter new username: ");
                    adminPassword = GetValidInput("Enter new password: ");
                    attempts = 0;
                    Console.WriteLine("Credentials reset. Please log in again.");
                }
                else
                {
                    Console.WriteLine("\n\t[ACCESS DENIED]: Invalid reset code. Program will exit.");
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
            Console.WriteLine("Please select an option to proceed:");

            foreach (string option in options)
                Console.WriteLine(option);

            Console.Write("\nEnter your choice: ");
            choice = GetValidatedNumberInput(1, 6);

            switch (choice)
            {
                case 1: CreateProfile(); break;
                case 2: EditProfile(); break;
                case 3: ViewProfile(); break;
                case 4: DeleteProfile(); break;
                case 5: SearchProfile(); break;
                case 6: Console.WriteLine("\nEXITING THE PROGRAM."); return;
            }

            Console.WriteLine("\n*Press any key to continue* ");
            Console.ReadKey();

        } while (true);
    }

    static void CreateProfile()
    {
        Console.WriteLine("\nYou selected >>> CREATE PROFILE <<<");

        string name = GetValidInput("Enter player name: ");
        int age = GetValidatedPositiveNumber("Enter player age: ");
        string position = GetValidInput("Enter player position (e.g. Spiker, Libero, Setter): ");

        var player = new Player { Name = name.Trim(), Age = age, Position = position.Trim() };

        if (playerService.AddPlayer(player))
            Console.WriteLine("\n\t---------------- Player's Profile ADDED successfully! ----------------");
        else
            Console.WriteLine("\n\t[ERROR] Failed to add player profile.");
    }

    static void EditProfile()
    {
        Console.WriteLine("\nYou selected >>> EDIT PROFILE <<<");

        string originalName = GetValidInput("Enter name of player to edit: ");
        var player = playerService.GetPlayerByName(originalName);

        if (player == null)
        {
            Console.WriteLine($"\nPlayer with name '{originalName}' not found.");
            return;
        }

        Console.WriteLine("[1] Name");
        Console.WriteLine("[2] Age");
        Console.WriteLine("[3] Position");
        Console.WriteLine("[4] All fields");
        Console.Write("\nSelect field to edit: ");
        int choice = GetValidatedNumberInput(1, 4);

        var updatedPlayer = new Player
        {
            Name = player.Name.Trim(),
            Age = player.Age,
            Position = player.Position.Trim()
        };

        switch (choice)
        {
            case 1:
                updatedPlayer.Name = GetValidInput("Enter new name: ");
                break;
            case 2:
                updatedPlayer.Age = GetValidatedPositiveNumber("Enter new age: ");
                break;
            case 3:
                updatedPlayer.Position = GetValidInput("Enter new position: ");
                break;
            case 4:
                updatedPlayer.Name = GetValidInput("Enter new name: ");
                updatedPlayer.Age = GetValidatedPositiveNumber("Enter new age: ");
                updatedPlayer.Position = GetValidInput("Enter new position: ");
                break;
        }

        if (playerService.UpdatePlayer(originalName, updatedPlayer))
            Console.WriteLine("\n\t---------------- Player's Profile UPDATED successfully! ----------------");
        else
            Console.WriteLine("\n\t[ERROR] Failed to update player profile.");
    }

    static void ViewProfile()
    {
        Console.WriteLine("\nYou selected >>> VIEW PROFILE <<<");

        var players = playerService.GetAllPlayers();

        if (players.Count == 0)
        {
            Console.WriteLine("\nNo player profiles found.");
            return;
        }

        Console.WriteLine("\n-- Players List --");
        foreach (var p in players)
        {
            string name = (p.Name ?? "N/A").Trim();
            string position = (p.Position ?? "N/A").Trim();
            string age = p.Age.ToString();

            Console.WriteLine("| {0,-20} | {1,-5} | {2,-12} |", name, age, position);
        }
    }
    static void DeleteProfile()
    {
        Console.WriteLine("\nYou selected >>> DELETE PROFILE <<<");

        string name = GetValidInput("Enter name of player to delete: ");

        if (playerService.DeletePlayer(name))
            Console.WriteLine("\n\t---------------- Player's Profile DELETED successfully! ----------------");
        else
            Console.WriteLine($"\nPlayer with name '{name}' not found.");
    }

    static void SearchProfile()
    {
        Console.WriteLine("\nYou selected >>> SEARCH PROFILE <<<");

        if (playerService.GetAllPlayers().Count == 0)
        {
            Console.WriteLine("\nNo player profiles found.");
            return;
        }

        string term = GetValidInput("Enter name or part of name to search: ");
        var results = playerService.SearchPlayersByName(term);

        if (results.Count == 0)
        {
            Console.WriteLine($"\nNo player found matching \"{term}\".");
            return;
        }


        Console.WriteLine("\n-- Search Results --");
        foreach (var p in results)
            Console.WriteLine($"Name: {p.Name} | Age: {p.Age} | Position: {p.Position}");
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

        return input.Trim();
    }

    static int GetValidatedNumberInput(int min, int max)
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
        {
            Console.Write($"Please enter a valid number ({min}-{max}): ");
        }
        return number;
    }

    static int GetValidatedPositiveNumber(string prompt)
    {
        int number;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

        return number;
    }
}
