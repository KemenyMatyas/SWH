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
            var dsResult = persons.ToDataSourceResult(request);
            return Json(dsResult);
        }
    }
}
