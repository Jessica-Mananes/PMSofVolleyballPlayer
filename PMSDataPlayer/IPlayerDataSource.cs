using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataPlayer
{
    public interface IPlayerDataSource
    {
        bool AddPlayer(Player player);
        bool UpdatePlayer(Player player);
        bool DeletePlayer(string name);
        Player GetPlayerByName(string name);
        List<Player> GetAllPlayers();
        List<Player> SearchPlayersByName(string searchTerm);
    }
}
