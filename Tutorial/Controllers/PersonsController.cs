using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Models;

namespace Tutorial.Controllers
{
    public class PersonsController : Controller
    {
        public ActionResult Show(string id, string name, string address)
        {
            var person = new Person()
            {
                IdPerson = id,
                FullName = name,
                Address = address
            };
            return View(person);
        }
    }
}