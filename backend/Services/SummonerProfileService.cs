using backend.Models;
using System.Net.Security;
using System.Text.Json;

namespace backend.Services
{
    public interface ISummonerProfileService
    {
        Task<SummonerData> FetchSummonerProfile(string region, string summonerName);
        Task<List<LeagueEntry>> FetchSummonerLeagueEntries(string region, string encryptedSummonerId);
    }
    public class SummonerProfileService : ISummonerProfileService
    {
        private readonly IHttpRequestService _httpRequestService;
        public SummonerProfileService(IHttpRequestService httpRequestService) 
        {
            _httpRequestService = httpRequestService;
        }
        public async Task<SummonerData> FetchSummonerProfile(string region, string summonerName)
        {
            HttpResponseMessage response = _httpRequestService.SendHttpRequest(region, $"/lol/summoner/v4/summoners/by-name/{summonerName}");
            SummonerData summonerData = await response.Content.ReadFromJsonAsync<SummonerData>();

            if (response.IsSuccessStatusCode)
            {
                return summonerData;
            }
            return null;
        }
        public async Task<List<LeagueEntry>> FetchSummonerLeagueEntries(string region, string encryptedSummonerId)
        {
            HttpResponseMessage response = _httpRequestService.SendHttpRequest(region, $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}");
            List<LeagueEntry> leagueEntries = await response.Content.ReadFromJsonAsync<List<LeagueEntry>>();

            if (response.IsSuccessStatusCode)
            {
                return leagueEntries;
            }
            return null;
        }
    }
}
