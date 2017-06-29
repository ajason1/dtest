using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTest.Domain
{
    public class PetOwner
    {      
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Pet[] Pets { get; set; }
    }
}
