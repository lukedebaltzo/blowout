﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.phone = "Please call Support at <strong><u>801-555-1212.</u></strong> Thank you!";
            return View();
        }

        public ActionResult Email(string sName, string sEmail)
        {
            ViewBag.email = "Thank you " + sName + ". We will send an email to " + sEmail;
            return View();
        }
    }
}