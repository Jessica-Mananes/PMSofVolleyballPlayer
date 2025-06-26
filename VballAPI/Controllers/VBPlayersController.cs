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


        private static readonly PlayerService playerService = new PlayerService(dataSource);


        [HttpGet]
        public IEnumerable<Player> GetAllPlayers()
        {
            return playerService.GetAllPlayers();
        }

        [HttpPost]
        public bool AddPlayer([FromBody] Player player)
        {
            return playerService.AddPlayer(player);
        }

        [HttpPatch("update")]
        public bool UpdatePlayer(string name, [FromBody] Player updatedPlayer)
        {
            return playerService.UpdatePlayer(name, updatedPlayer);
        }

        [HttpDelete]
        public bool DeletePlayer(string name)
        {
            return playerService.DeletePlayer(name);
        }

        [HttpGet("search")]
        public IEnumerable<Player> SearchPlayersByName(string keyword)
        {
            return playerService.SearchPlayersByName(keyword);
        }
    }
}
