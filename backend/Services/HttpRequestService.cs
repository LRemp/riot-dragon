using System.Net;

namespace backend.Services
{
    public interface IHttpRequestService
    {
        HttpResponseMessage SendHttpRequest(string region, string requestEndpoint);
    }
    public class HttpRequestService: IHttpRequestService
    {
        private string ApiKey { get; set; }
        public HttpRequestService(IConfiguration configuration)
        {
            ApiKey = configuration["ApiKey"];
        }
        public HttpResponseMessage SendHttpRequest(string region, string requestEndpoint)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get,
                $"https://{region.ToLower()}.api.riotgames.com{requestEndpoint}?api_key={ApiKey}");

            HttpResponseMessage response = client.Send(httpRequestMessage);
            return response;
        }
    }
}
