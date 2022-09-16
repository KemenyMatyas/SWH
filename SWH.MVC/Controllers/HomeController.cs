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
        public IActionResult Details([FromQuery] string personId)
        {

            var person = _dataAccess.GetPersonDetails(Guid.Parse(personId));
            return PartialView(person);
        }
        
        [HttpPost]
        public ActionResult SubmitDetails(Person person)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Details",person);
            }

            try
            {
                _dataAccess.EditPersonData(person);
                return PartialView("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
            
            
            
            
        }
        
        
        
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
