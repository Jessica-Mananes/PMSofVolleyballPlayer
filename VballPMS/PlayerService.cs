using System.Collections.Generic;
using PlayerCommon;
using PMSDataPlayer;

namespace VballPMS
{
    public class PlayerService
    {
        private readonly IPlayerDataSource _data;

        public PlayerService(IPlayerDataSource data)
        {
            _data = data;
        }

        public bool AddPlayer(Player player)
        {
            return _data.AddPlayer(player);
        }

        public bool UpdatePlayer(string originalName, Player updatedPlayer)
        {
            var existingPlayer = _data.GetPlayerByName(originalName);
            if (existingPlayer == null) return false;
            return _data.UpdatePlayer(originalName, updatedPlayer);
        }

        public bool DeletePlayer(string name)
        {
            return _data.DeletePlayer(name);
        }

        public Player GetPlayerByName(string name)
        {
            return _data.GetPlayerByName(name);
        }

        public List<Player> GetAllPlayers()
        {
            return _data.GetAllPlayers();
        }

        public List<Player> SearchPlayersByName(string searchTerm)
        {
            return _data.SearchPlayersByName(searchTerm);
        }
        public string GetStorageType()
        {
            return _data.GetType().Name;
        }
    }
}
