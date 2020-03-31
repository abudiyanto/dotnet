using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Models;

namespace Tutorial.Controllers
{
    public class BasicsController : Controller
    {
        public ActionResult Conditional(string name)
        {
            string answer = "bambang";
            if (name != null)
            {
                if (name.Equals(answer))
                    return Content("Hello " + answer);
                else
                    return Content("I'm sorry...");
            }
            return Content("Please insert name!");
        }
        public ActionResult Looping(int number)
        {
            ViewBag.Statement = "Hello World!";
            return View(number);
        }
        public ActionResult Json()
        {
            var person = new Person()
            {
                IdPerson = "123",
                Address = "Babarsari",
                FullName = "Bambang"
            };
            return Json(person, JsonRequestBehavior.AllowGet);
        }
    }
}