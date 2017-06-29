using DeveloperTest.Domain;
using Microsoft.Practices.ObjectBuilder2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperTest.Web.Models
{
    public class PetListingViewModel
    {
        public IEnumerable<Tuple<string, IOrderedEnumerable<Pet>>> PetOwnersGroupByGender { get; set; }
        public PetListingViewModel(IList<PetOwner> petOwners)
        {
            PetOwnersGroupByGender = petOwners
                .Where(o => o.Pets != null)
                .GroupBy(s => s.Gender) 
                .Select(o => //Use tuple for quick demo purpose
                        new Tuple<string, IOrderedEnumerable<Pet>>(o.Key, 
                        o.SelectMany(v => v.Pets)
                        .OrderBy(p => p.Name, 
                        StringComparer.InvariantCultureIgnoreCase)));
        }
    }

}