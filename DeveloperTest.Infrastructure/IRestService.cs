using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeveloperTest.Infrastructure
{
    public interface IRestService : IDisposable
    {
        Task<string> GetString(Uri uri);
    }
}
