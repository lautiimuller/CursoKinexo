using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Lista()
        {
            return View();
        }

        

        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }


    }
}
