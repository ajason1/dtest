using DeveloperTest.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using DeveloperTest.Domain;

namespace DeveloperTest.Repository
{
    public class PetRepository : IPetRepository
    {
        private IRestService _restService;
        public PetRepository(IRestService restService)
        {
            _restService = restService;
        }

        public async Task<IList<PetOwner>> GetPetOwnersAsync()
        {
            //pass via configuration service. now just for demo.
            var uri = new Uri("http://agl-developer-test.azurewebsites.net/people.json");
            var content = await _restService.GetString(uri);
            var petOwners = await Task.Run(() => JsonConvert.DeserializeObject<List<PetOwner>>(content));

            return petOwners;
        }
    }
}
