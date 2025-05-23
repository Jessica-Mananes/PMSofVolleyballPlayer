﻿using System.Collections.Generic;
using PlayerCommon;

namespace PMSDataPlayer
{
    public class PlayerData
    {
        private readonly IPlayerDataSource playerData;

        public PlayerData()
        {
            playerData = new JsonFilePlayerData();
            // playerData = new TextFilePlayerData();
            // playerData = new InMemoryPlayerData();
        }

        public List<Player> GetAllPlayers()
        {
            return playerData.GetAllPlayers();
        }

        public bool AddPlayer(Player player)
        {
            return playerData.AddPlayer(player);
        }

        public bool EditPlayer(Player updatedPlayer)
        {
            var existingPlayer = playerData.GetPlayerByName(updatedPlayer.Name);
            if (existingPlayer == null)
                return false;

            return playerData.UpdatePlayer(existingPlayer.Name, updatedPlayer);
        }


        public bool DeletePlayer(string playerName)
        {
            return playerData.DeletePlayer(playerName);
        }

        public Player GetPlayerByName(string playerName)
        {
            return playerData.GetPlayerByName(playerName);
        }

        public List<Player> SearchPlayersByName(string searchTerm)
        {
            return playerData.SearchPlayersByName(searchTerm);
        }
    }
}
