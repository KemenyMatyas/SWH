using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace SWH.MVC.Controllers
{
    using DataAccess.IAccess;
    using Kendo.Mvc.Extensions;

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
