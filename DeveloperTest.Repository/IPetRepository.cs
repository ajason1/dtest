using DeveloperTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTest.Repository
{
    public interface IPetRepository
    {
        Task<IList<PetOwner>> GetPetOwnersAsync();
    }
}
