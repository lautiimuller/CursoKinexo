using Contract;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class NotasController : Controller
    {
        private readonly IServicioNotas notasService;

        public NotasController(IServicioNotas notasService)
        {
            this.notasService = notasService;
        }

        public ActionResult Index()
        {
            var notas = notasService.GetNews();

            IList<NotaModel> notas1 = new List<NotaModel>();

            foreach (var cat in notas)
            {
                var creada = new NotaModel { Id = cat.Id, Active = cat.Active, Descripcion = cat.Descripcion, Titulo = cat.Titulo };
                notas1.Add(creada);
            }

            return View(notas1);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NotaModel model)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            return RedirectToAction("Index");
        }
    }
}