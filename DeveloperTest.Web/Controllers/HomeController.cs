using DeveloperTest.Services;
using DeveloperTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DeveloperTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPetService _petService;
        public HomeController(IPetService petService)
        {
            _petService = petService;
        }

        public async Task<ActionResult> Index()
        {
            var petOwners =  await _petService.GetPetOwnersAsync();
            return View(new PetListingViewModel(petOwners));
        }
    }
}