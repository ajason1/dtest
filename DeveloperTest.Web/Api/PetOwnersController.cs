using DeveloperTest.Domain;
using DeveloperTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DeveloperTest.Web.Api
{
    public class PetOwnersController : ApiController
    {
        private IPetService _petService;
        public PetOwnersController(IPetService petService)
        {
            _petService = petService;
        }

        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Index()
        {
            var petOwners = await _petService.GetPetOwnersAsync();
            var result = petOwners
               .Where(o => o.Pets != null)
               .GroupBy(s => s.Gender)
               .Select(o => //Use tuple for demo purpose
                       new { OwnerGender = o.Key,
                             Pets = o.SelectMany(v => v.Pets)
                                    .OrderBy(p => p.Name, StringComparer.InvariantCultureIgnoreCase) }
                       );

            return this.Request.CreateResponse(System.Net.HttpStatusCode.OK, result);
        }
    }
}