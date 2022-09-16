using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace SWH.MVC.Controllers
{
    using System;
    using Data.Models;
    using Kendo.Mvc.Extensions;
    using Services.IServices;

    public class GridPersonController : Controller
    {
        private readonly IDataAccess _dataAccess;

        public GridPersonController(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        
        public ActionResult GetAllPersons([DataSourceRequest] DataSourceRequest request)
        {
            var persons = _dataAccess.GetAllPersons();
            var person = _dataAccess.GetPersonDetails(Guid.Parse("efdf0c97-295f-4fef-a218-42d49b309ee4"));
            var newPerson = new Person()
            {
                Id = Guid.Parse("efdf0c97-295f-4fef-a218-42d49b309ee4"),
                UserName = "teszt",
                Password = "test",
                FirstName = "test",
                LastName = "test",
                Domicile = "test",
                PlaceOfBirth = "test",
                BirthDay = DateTime.Now
            };
            
            _dataAccess.EditPersonData(newPerson);
            var dsResult = persons.ToDataSourceResult(request);
            return Json(dsResult);
        }
    }
}
