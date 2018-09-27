using EjemploControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploControllers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Usuario
            {
                Nombre = "Diego Bersano"
            });
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