using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWH.MVC.Controllers
{
    using System.Xml;
    using System.Xml.Linq;
    using Data.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Services.IServices;
    using Services.Services;

    public class HomeController : Controller
    {
        
        private readonly IDataAccess _dataAccess;
        private readonly IUserService _userService;

        public HomeController(IDataAccess dataAccess, IUserService userService)
        {
            _dataAccess = dataAccess;
            _userService = userService;
        }
        
        public IActionResult Index()
        {
            if (!AuthService.IsLoggedIn)
            {
                return RedirectToAction("Index", "Login"); 
            }
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

        public IActionResult Logout()
        {
            AuthService.IsLoggedIn = false;
            return RedirectToAction("Index", "Login"); 
        }
        
        [HttpPost]
        public string StringToXml(string data)
        {
          
            
            var xml = JsonConvert.DeserializeXmlNode("{\"Row\":" + data + "}", "BiddingHistory");
            var stringData = xml.OuterXml;
            return stringData;
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
