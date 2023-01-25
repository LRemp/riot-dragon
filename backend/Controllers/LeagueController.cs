using backend.Enums;
using backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueController : ControllerBase
    {
        private readonly ISummonerProfileService _SummonerProfileService;
        public LeagueController(ISummonerProfileService summonerProfileService)
        {
            _SummonerProfileService = summonerProfileService;
        }
        [Route("Entries")]
        [HttpGet]
        public async Task<ActionResult> GetSummonerLeagueEntries(string region, string summonerName)
        {
            if (!Enum.IsDefined(typeof(Regions), region))
            {
                return BadRequest("User name or password is invalid.");
            }
            var summonerProfile = _SummonerProfileService.FetchSummonerProfile(region, summonerName).Result;
            var leagueEntries = _SummonerProfileService.FetchSummonerLeagueEntries(region, summonerProfile.id);
            if (leagueEntries == null)
            {
                return NotFound();
            }
            return Ok(leagueEntries);
        }
    }
}
