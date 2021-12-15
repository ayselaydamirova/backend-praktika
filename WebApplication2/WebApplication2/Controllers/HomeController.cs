using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class HomeController: Controller
    {
        //public ContentResult Index()
        //{
        //    var result = new ContentResult();
        //    result.Content = "hello p201 !!!";

        //    return result;
        //}

        //public ViewResult Index()
        //{
        //    var result = new ViewResult();
        //    result.ViewName = "Index";

        //    return result;
        //}


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id, string name)
        {
            //return Content(name + " - "+id.ToString());

            ViewData["id"] = id;
            ViewBag.Id = 20;
            TempData["id"] = 21;

            return RedirectToAction("about");
        }

        //public ContentResult About()
        //{
        //    return Content("About page");
        //}

        public ViewResult About()
        {

            return View();
        }


        public JsonResult Json()
        {
            return Json(new { name = "Aysel", surname = "Aydamirova" });
        }

    }
}
    
}
