using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAppli2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>() 
            { 
                "India",
                "USA",
                "UK",
                "CANADA"
            };
            return View();
        }

    }
}
