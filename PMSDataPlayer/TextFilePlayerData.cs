using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PlayerCommon;


namespace PMSDataPlayer
{
    public class TextFilePlayerData : IPlayerDataSource
    {
        private readonly string filePath = "players.txt";

        public bool AddPlayer(Player player)
        {
            var players = GetAllPlayers();

            if (players.Any(p => p.Name.Equals(player.Name, StringComparison.OrdinalIgnoreCase)))
                return false; 

            string line = $"{player.Name}|{player.Age}|{player.Position}{Environment.NewLine}";
            File.AppendAllText(filePath, line);
            return true;
        }

        public bool UpdatePlayer(string originalName, Player updatedPlayer)
        {
            var players = GetAllPlayers();
            var existingPlayer = players.FirstOrDefault(p => p.Name.Equals(originalName, System.StringComparison.OrdinalIgnoreCase));
            if (existingPlayer == null)
                return false;

            existingPlayer.Name = updatedPlayer.Name;
            existingPlayer.Age = updatedPlayer.Age;
            existingPlayer.Position = updatedPlayer.Position;

            SaveAll(players);
            return true;
        }

        public bool DeletePlayer(string name)
        {
            var players = GetAllPlayers();
            var playerToRemove = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (playerToRemove == null)
                return false;

            players.Remove(playerToRemove);
            SaveAll(players);
            return true;
        }

        public Player GetPlayerByName(string name)
        {
            var players = GetAllPlayers();
            return players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Player> SearchPlayersByName(string searchTerm)
        {
            var players = GetAllPlayers();
            return players
                .Where(p => p.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Player> GetAllPlayers()
        {
            var list = new List<Player>();
            if (!File.Exists(filePath))
                return list;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 3 && int.TryParse(parts[1], out int age))
                {
                    list.Add(new Player(parts[0], age, parts[2]));
                }
            }
            return list;
        }

        private void SaveAll(List<Player> players)
        {
            using StreamWriter sw = new(filePath);
            foreach (var p in players)
                sw.WriteLine($"{p.Name}|{p.Age}|{p.Position}");
        }
    }
}
