using EjemploControllers.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EjemploControllers.Controllers
{
    public class UsuariosController : Controller
    {
        private static IList<Usuario> usuarios = new List<Usuario>();

        public ActionResult Index()
        {
            return View(usuarios);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Id = usuarios.Count() + 1;
            usuarios.Add(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var usuario = usuarios.Where(x => x.Id == id).Single();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Edit(Usuario model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usuario = usuarios.Where(x => x.Id == model.Id).Single();
            usuario.Nombre = model.Nombre;
            usuario.Email = model.Email;
            usuario.Password = model.Password;

            return RedirectToAction("Index");
        }
    }
}