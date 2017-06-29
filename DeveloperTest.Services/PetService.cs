using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperTest.Domain;
using DeveloperTest.Repository;
using Newtonsoft.Json;

namespace DeveloperTest.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _restRepository;

        public PetService(IPetRepository petRepository)
        {
            _restRepository = petRepository;
        } 
        public Task<IList<PetOwner>> GetPetOwnersAsync()
        {
            return _restRepository.GetPetOwnersAsync(); 
            //var result = _restRepository.GetPetOwners();
            //return null;
            // return petOwners;
        }
    }
}
