using System.Collections.Generic;
using PlayerCommon;

namespace PMSDataPlayer
{
    public interface IPlayerDataSource
    {
        List<Player> GetAllPlayers();
        bool AddPlayer(Player player);
        bool UpdatePlayer(Player player);
        bool DeletePlayer(string name);
        Player GetPlayerByName(string name);
        List<Player> SearchPlayersByName(string searchTerm);
    }
}
