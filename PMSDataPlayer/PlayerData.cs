using System.Collections.Generic;
using PlayerCommon;

namespace PMSDataPlayer
{
    public class PlayerData : IPlayerDataSource
    {
        private readonly IPlayerDataSource _dataSource;

        public PlayerData()
        {
           // _dataSource = new InMemoryPlayerData();
          //  _dataSource = new JsonFilePlayerData();
          //  _dataSource = new TextFilePlayerData();
           _dataSource = new DBDataPlayer(); 
        }

        public bool AddPlayer(Player player) => _dataSource.AddPlayer(player);
        public List<Player> GetAllPlayers() => _dataSource.GetAllPlayers();
        public Player GetPlayerByName(string name) => _dataSource.GetPlayerByName(name);
        public bool UpdatePlayer(string name, Player updatedPlayer) => _dataSource.UpdatePlayer(name, updatedPlayer);
        public bool DeletePlayer(string name) => _dataSource.DeletePlayer(name);
        public List<Player> SearchPlayersByName(string name) => _dataSource.SearchPlayersByName(name);

      
        }
    }
