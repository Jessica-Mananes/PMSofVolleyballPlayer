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
        PlayerService playerService = new PlayerService(new InMemoryPlayerData());

        [HttpGet]
        public IEnumerable<Player> GetAllPlayers()
        {
            return playerService.GetAllPlayers();
        }

        [HttpPost]
        public bool AddPlayer(Player request)
        {
            return playerService.AddPlayer(request);
        }

        [HttpPatch("update")]
        public bool UpdatePlayer(string name, Player updatedPlayer)
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
