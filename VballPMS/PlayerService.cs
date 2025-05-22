using VolleyballPMS;
using System;
using System.Collections.Generic;
using PMSDataPlayer;
using System.Numerics;

namespace VolleyballPMS
{
    public class PlayerService
    {

        private readonly InMemoryPlayerData playerData = new();

        public bool AddPlayer(string name, int age, string position)
        {
            Player newPlayer = new(name, age, position);
            playerData.AddPlayer(newPlayer);
            return true;
        }

        public bool EditPlayer(int index, string newName, int newAge, string newPosition)
        {
            return playerData.UpdatePlayer(index, newName, newAge, newPosition);

        }

        public bool DeletePlayer(int index)
        {
            return playerData.DeletePlayer(index);

        }

        public List<Player> GetAllPlayers()
        {
            return playerData.GetAllPlayers();
        }

        public int GetPlayerCount()
        {
            return playerData.GetPlayerCount();

        }

        public Player GetPlayerByIndex(int index)
        {
            return playerData.GetPlayerByIndex(index);
        }
    }
}