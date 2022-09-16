using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWH.MVC.Controllers
{
    using Data.Models;
    using DataAccess.IAccess;

    public class HomeController : Controller
    {
        
        private readonly IDataAccess _dataAccess;

        public HomeController(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details([FromQuery] string personId)
        {

            var person = _dataAccess.GetPersonDetails(Guid.Parse(personId));
            return PartialView(person);
        }
        
        [HttpPost]
        public ActionResult Index(Person model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Details",model);
            }

            TempData["View"] = "Overview";
            return View("Success");
        }
        
        
        
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
