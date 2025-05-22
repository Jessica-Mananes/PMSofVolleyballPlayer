using System.Collections.Generic;

namespace PMSDataPlayer
{
    public class InMemoryPlayerData : IPlayerDataSource
    {
        private readonly List<Player> players = new();

        public List<Player> GetAllPlayers()
        {
            return new List<Player>(players);
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public bool UpdatePlayer(int index, string newName, int newAge, string newPosition)
        {
            if (index < 0 || index >= players.Count)
                return false;

            players[index].Name = newName;
            players[index].Age = newAge;
            players[index].Position = newPosition;
            return true;
        }

        public bool DeletePlayer(int index)
        {
            if (index < 0 || index >= players.Count)
                return false;

            players.RemoveAt(index);
            return true;
        }

        public Player GetPlayerByIndex(int index)
        {
            if (index < 0 || index >= players.Count)
                return null;

            return players[index];
        }

        public int GetPlayerCount()
        {
            return players.Count;
        }
    }
}
