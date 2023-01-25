using backend.Enums;
using backend.Managers;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SummonerController : Controller
    {
        private readonly IMetadataItemService _ItemsService;
        private readonly ISummonerProfileService _SummonerProfileService;
        public SummonerController(IMetadataItemService ItemsService, ISummonerProfileService summonerProfileService) 
        { 
            _ItemsService = ItemsService;
            _SummonerProfileService = summonerProfileService;
        }
        [HttpGet(Name = "GetSummonerProfile")]
        public async Task<ActionResult> GetSummonerProfile(string summonerName, string region)
        {
            if (!Enum.IsDefined(typeof(Regions), region))
            {
                return BadRequest("User name or password is invalid.");
            }
            var summonerProfile = _SummonerProfileService.FetchSummonerProfile(region, summonerName);
            if(summonerProfile == null)
            {
                return NotFound();
            }
            return Ok(summonerProfile);
        }
    }
}
