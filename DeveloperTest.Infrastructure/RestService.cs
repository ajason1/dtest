using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeveloperTest.Infrastructure
{
    public class RestService : IRestService
    {
        private readonly HttpClient _client;
        public RestService(HttpClient client)
        {
            _client = client;
        }
        public async Task<string> GetString(Uri uri)
        {
            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}