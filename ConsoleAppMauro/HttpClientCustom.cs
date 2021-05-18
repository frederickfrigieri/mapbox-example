using System;
using System.Net.Http;
using System.Text.Json;

namespace ConsoleAppMauro
{
    public class HttpClientCustom
    {
        private readonly HttpClient client;
        const string ACCESS_TOKEN = "";
        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public HttpClientCustom()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.mapbox.com");
        }

        public object GetExample<T>(string endpoint) where T : class
        {
            var response = client.GetAsync($"{endpoint}?access_token={ACCESS_TOKEN}").Result;

            return JsonSerializer.Deserialize<T>(response.Content.ReadAsStringAsync().Result, _options);
        }
    }
}
