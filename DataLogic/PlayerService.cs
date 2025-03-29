using VolleyballPMS;
using System;
using System.Collections.Generic;

namespace VolleyballPMS
{
    public class PlayerService
    {
        public class Player
        {
            public string Name;
            public int Age;
            public string Position;

            public Player(string name, int age, string position)
            {
                this.Name = name;
                this.Age = age;
                this.Position = position;
            }
        }

        private readonly List<Player> playersList = new();

        public bool AddPlayer(string name, int age, string position)
        {
            playersList.Add(new Player(name, age, position));
            return true;
        }

        public bool EditPlayer(int index, string name, int age, string position)
        {
            if (index < 0 || index >= playersList.Count)
                return false;

            playersList[index].Name = name;
            playersList[index].Age = age;
            playersList[index].Position = position;
            return true;
        }

        public bool DeletePlayer(int index)
        {
            if (index < 0 || index >= playersList.Count)
                return false;

            playersList.RemoveAt(index);
            return true;
        }

        public List<Player> GetAllPlayers()
        {
            return new List<Player>(playersList);
        }

        public int GetPlayerCount() => playersList.Count;

        public Player GetPlayerByIndex(int index)
        {
            return (index >= 0 && index < playersList.Count) ? playersList[index] : null;
        }
    }
}