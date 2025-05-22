using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PlayerCommon;

namespace PMSDataPlayer
{
    public class JsonFilePlayerData : IPlayerDataSource
    {
        private readonly string filePath = "players.json";

        public bool AddPlayer(Player player)
        {
            var players = GetAllPlayers();

            if (players.Any(p => p.Name == player.Name))
                return false;

            players.Add(player);
            SaveAll(players);
            return true;
        }

        public bool UpdatePlayer(Player updatedPlayer)
        {
            var players = GetAllPlayers();

            var existingPlayer = players.FirstOrDefault(p => p.Name == updatedPlayer.Name);
            if (existingPlayer == null)
                return false;

            existingPlayer.Age = updatedPlayer.Age;
            existingPlayer.Position = updatedPlayer.Position;

            SaveAll(players);
            return true;
        }

        public bool DeletePlayer(string name)
        {
            var players = GetAllPlayers();

            var playerToRemove = players.FirstOrDefault(p => p.Name == name);
            if (playerToRemove == null)
                return false;

            players.Remove(playerToRemove);
            SaveAll(players);
            return true;
        }

        public List<Player> GetAllPlayers()
        {
            if (!File.Exists(filePath))
                return new List<Player>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
        }

        public Player GetPlayerByName(string name)
        {
            var players = GetAllPlayers();
            return players.FirstOrDefault(p => p.Name == name);
        }

        public List<Player> SearchPlayersByName(string searchTerm)
        {
            var players = GetAllPlayers();
            return players.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        private void SaveAll(List<Player> players)
        {
            string json = JsonSerializer.Serialize(players, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
