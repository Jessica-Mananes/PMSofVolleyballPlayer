using System.Collections.Generic;
using PlayerCommon;

namespace PMSDataPlayer
{
    public interface IPlayerDataSource
    {
        bool AddPlayer(Player player);
        bool DeletePlayer(string name);
        List<Player> GetAllPlayers();
        Player GetPlayerByName(string name);
        List<Player> SearchPlayersByName(string searchTerm);
        bool UpdatePlayer(string originalName, Player updatedPlayer);
    }
}
