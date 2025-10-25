using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlayerCommon;
using PMSDataPlayer;
using VballPMS;

namespace VballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VBPlayersController : ControllerBase
    {
        // private static readonly InMemoryPlayerData dataSource = new InMemoryPlayerData();
          private static readonly DBDataPlayer dataSource = new DBDataPlayer();
        // private static readonly JsonFilePlayerData dataSource = new JsonFilePlayerData();
        //private static readonly TextFilePlayerData dataSource = new TextFilePlayerData();
        private readonly PlayerService _playerService;

        public VBPlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }




        [HttpGet]
        public IEnumerable<Player> GetAllPlayers()
        {
            return _playerService.GetAllPlayers();
        }

        [HttpPost]
        public bool AddPlayer([FromBody] Player player)
        {
            return _playerService.AddPlayer(player);
        }

        [HttpPatch("update")]
        public bool UpdatePlayer(string name, [FromBody] Player updatedPlayer)
        {
            return _playerService.UpdatePlayer(name, updatedPlayer);
        }

        [HttpDelete]
        public bool DeletePlayer(string  name)
        {
            return _playerService.DeletePlayer(name);
        }

        [HttpGet("search")]
        public IEnumerable<Player> SearchPlayersByName(string keyword)
        {
            return _playerService.SearchPlayersByName(keyword);
        }
    }
}
