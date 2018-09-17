using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExtremeMvcApp1.Models;

namespace DevExtremeMvcApp1.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public ActionResult Index() {
            return View();
        }


        public ActionResult Jumbo()
        {
            return View(new FormLayoutFeaturesModel
            {                
                Name = "Joseph",                
                /*
                Description = "360-684-1334",                
                BirthDate = DateTime.Parse("1964/03/16"),
                HireDate = DateTime.Parse("1995/01/15"),
                Notes = "John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003.\r\n\r\nWhen not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.",
                Address = "351 S Hill St., Los Angeles, CA",
                Email = "jheart@dx-email.com",
                Phone = "360-654-4567"
                */
            });
          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Validation(FormLayoutFeaturesModel userInfo)
        {
            if (ModelState.IsValid)
            {
                return View("SuccessValidation");
            }

            return View(userInfo);
        }

        public ActionResult HandHeldMining() {
         return View();
        }

        public ActionResult SuccessValidation()
        {
            return View();
        }

        public ActionResult DataMaintenance()
        {
            return View();
        }
    }
}