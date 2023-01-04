using backend.Models;
using System.Text.Json;

namespace backend.Services
{
    public interface ISummonerProfileService
    {
        Task<SummonerData> FetchSummonerProfile(string region, string summonerName);
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
    }
}
