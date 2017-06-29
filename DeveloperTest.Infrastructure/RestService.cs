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
            return await _client.GetStringAsync(uri).ConfigureAwait(false);
        }
        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}