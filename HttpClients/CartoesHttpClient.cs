using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace dotnet_typed_httpclient.HttpClients
{
    public class CartoesHttpClient
    {
        private readonly HttpClient httpClient;

        public CartoesHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<JToken> GetCartoes()
        {
            var response = await httpClient.GetAsync("/cartoes");
            
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<JToken>();
        }
    }
}