using System.Collections.Generic;
using System.Numerics;
using PMSDataPlayer;

namespace PMSDataPlayer
{
    public class PlayerData
    {

        private readonly List<Player> players = new();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public bool UpdatePlayer(int index, string name, int age, string position)
        {
            if (index >= 0 && index < players.Count)
            {
                players[index].Name = name;
                players[index].Age = age;
                players[index].Position = position;
                return true;
            }
            return false;
        }

        public bool DeletePlayer(int index)
        {
            if (index >= 0 && index < players.Count)
            {
                players.RemoveAt(index);
                return true;
            }
            return false;
        }

        public List<Player> GetAllPlayers()
        {
            return players;
        }

        public int GetPlayerCount()
        {
            return players.Count;
        }

        public Player GetPlayerByIndex(int index)
        {
            if (index >= 0 && index < players.Count)
                return players[index];
            return null;
        }
    }
}
