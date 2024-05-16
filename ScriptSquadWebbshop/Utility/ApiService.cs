using Newtonsoft.Json.Linq;
using ScriptSquadWebbshop.Models;
using System.Text.Json.Nodes;

namespace ScriptSquadWebbshop.Utility
{
    public class ApiService
    {
        private readonly HttpClient _client;
        public ApiService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("API Client");
        }

        public async Task<WeatherApiResponse> GetApiDataAsync(string url)
        {
            var respone = await _client.GetAsync(url);
            respone.EnsureSuccessStatusCode();

            var jsonResponse = await respone.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonResponse);

            var weatherApiResponse = new WeatherApiResponse
            {
                Time = jsonObject["daily"]["time"].ToObject<List<string>>(),
                WeatherCode = jsonObject["daily"]["weather_code"].ToObject<List<int>>()
            };

            return weatherApiResponse;
        }

       
    }
}
