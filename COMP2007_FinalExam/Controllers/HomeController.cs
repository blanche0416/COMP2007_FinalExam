// Author's Name : Pui In Kwok
// Student Number : 200203793
// Data Modified : 17 Aug, 2016
// Short Version History : 0.0.0.1
// File Description : This is the home controller that get the home, about and contact page

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_FinalExam.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}