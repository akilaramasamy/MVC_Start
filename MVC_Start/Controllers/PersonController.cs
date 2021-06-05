using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            PersonViewModel person = new PersonViewModel
            {
                FirstName = "Akila",
                LastName = "Ramasamy",
                Age = 100,
                Email = "aramasamy@usf.edu",
                Phone = "12345",
                Address = "756  jgyf"

            };
            return View(person);
        }
        [HttpPost]
        public IActionResult Save(PersonViewModel model)
        {
            return View();
        }
     }
}
