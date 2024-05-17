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

        public async Task<Dictionary<string, int>> GetApiDataAsync(string url)
        {
            var respone = await _client.GetAsync(url);
            respone.EnsureSuccessStatusCode();

            var jsonResponse = await respone.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonResponse);

            //get dates and codes from Json
            var time = jsonObject["daily"]["time"].ToObject<List<string>>();;
            var codes = jsonObject["daily"]["weather_code"].ToObject<List<int>>();

            Dictionary<string, int> data = new Dictionary<string, int>();
            //place dates and codes in dictionary
            for (int i = 0; i < time.Count; i++)
            {
                data[time[i]] = codes[i];
            }
           

            return data;
        }

       
    }
}
