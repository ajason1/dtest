using System;
using System.Net.Http;

namespace DeveloperTest.Infrastructure
{
    public class RestServiceFactory : IRestServiceFactory
    {
        private readonly TimeSpan _timeout;

        public RestServiceFactory(TimeSpan timeout)
        {
            _timeout = timeout;
        }

        public IRestService Create()
        {
            return new RestService(new HttpClient());
        }
    }
}