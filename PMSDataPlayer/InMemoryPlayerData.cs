using System.Collections.Generic;
using System.Linq;
using PlayerCommon;


namespace PMSDataPlayer
{
    public class InMemoryPlayerData : IPlayerDataSource
    {
        private readonly List<Player> players = new();

        public bool AddPlayer(Player player)
        {
            if (players.Any(p => p.Name == player.Name))
                return false;
            players.Add(player);
            return true;
        }

        public bool UpdatePlayer(string originalName, Player updatedPlayer)
        {
            var index = players.FindIndex(p => p.Name.Equals(originalName, StringComparison.OrdinalIgnoreCase));
            if (index == -1)
                return false;

            players[index] = updatedPlayer;
            return true;
        }

        public bool DeletePlayer(string name)
        {
            var player = players.FirstOrDefault(p => p.Name == name);
            if (player == null)
                return false;

            players.Remove(player);
            return true;
        }

        public Player GetPlayerByName(string name)
        {
            return players.FirstOrDefault(p => p.Name == name);
        }

        public List<Player> GetAllPlayers()
        {
            return new List<Player>(players);
        }

        public List<Player> SearchPlayersByName(string searchTerm)
        {
            return players
                .Where(p => p.Name.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
