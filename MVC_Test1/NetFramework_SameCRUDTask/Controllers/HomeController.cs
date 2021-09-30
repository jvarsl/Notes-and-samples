using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFramework_SameCRUDTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            /*
            // 1 - neziuri i web config
            Response.StatusCode = 404;
            return View("Error");
            // 2 - i web config turetu ziureti ir atidaryti tuos puslapius (bet neatidaro)
            throw new HttpException(404, "Page Not Found");
            // 3 - defaultini error langa priimu
            return HttpNotFound("Some description");
            */
            ViewBag.Message = "Your contact page.";
            ViewData["CustomMessage"] = "Superino my bros";
            var randomList = new List<int>() { 1, 2, 3, 4, 5 };
            ViewData["Numbers"] = randomList;
            return View();
        }
    }
}