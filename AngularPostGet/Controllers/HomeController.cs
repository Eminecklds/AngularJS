using AngularPostGet.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularPostGet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }

        //employees tablosuna veri eklemek istiyorum.

        //employees tablosundaki tüm insanları göstermek istiyorum.


        //angularjs ile cagıracagım ıcın jsonresult kullandım.
        public JsonResult GetAll()
        {
            var employeeList = db.Employees.Select(x => new
            {
                x.FirstName,
                x.LastName

            }).ToList();
            return Json(employeeList, JsonRequestBehavior.AllowGet);
        }
    }
}