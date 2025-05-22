using System.Collections.Generic;
using PMSDataPlayer;

namespace VolleyballPMS
{
    public class PlayerService
    {
        private readonly IPlayerDataSource _data;

        public PlayerService(IPlayerDataSource data)
        {
            _data = data;
        }

        public bool AddPlayer(string name, int age, string position)
        {
            return _data.AddPlayer(new Player { Name = name, Age = age, Position = position });
        }

        public bool UpdatePlayer(Player player)
        {
            return _data.UpdatePlayer(player);
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
    }
}
