using PlayerCommon;
using PMSDataPlayer;
using System.Collections.Generic;
using Vball_BusinessDataLogic.Services;

namespace VballPMS
{
    public class PlayerService
    {
        private readonly IPlayerDataSource _data;
        private readonly EmailService _emailService;

        public PlayerService(IPlayerDataSource data, EmailService emailService)
        {
            _data = data;
            _emailService = emailService;
        }

        public bool AddPlayer(Player player)
        {
            bool result = _data.AddPlayer(player);

            if (result)
            {
                _emailService.SendEmail(player.Name, player.Email);
            }

            return result;
        }

        public bool UpdatePlayer(string originalName, Player updatedPlayer)
        {
            var existingPlayer = _data.GetPlayerByName(originalName);
            if (existingPlayer == null) return false;

            bool result = _data.UpdatePlayer(originalName, updatedPlayer);

            if (result)
            {
                _emailService.SendEmail(updatedPlayer.Name, updatedPlayer.Email);
            }

            return result;
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
