using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
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

        //stuff for the RENTAL process
        //Create a Rentals view that allows users to select a type of instrument by clicking on an image.

        //After clicking on the instrument image you should be taken to a new page that shows the instrument.
        //The user should be able to select new or used.Depending on whether its new or used, you should show the price for the instrument.

        public ActionResult Rental()
        {
            return View();
        }

        public ActionResult Trumpet()
        {
            return View();
        }
    }
}