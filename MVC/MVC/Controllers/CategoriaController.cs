using Contract;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Contract.IService;

namespace MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly IService categoryService;
        public CategoriaController(IService categoryService)
        {
            this.categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();

            IList<CategoriaModel> categories1 = new List<CategoriaModel>();

            foreach (var cat in categories)
            {
                var creada = new CategoriaModel { Id = cat.Id, Active = cat.Active, Description = cat.Description, Name = cat.Name };
                categories1.Add(creada);
            }

            return View(categories1);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (categoryService.DeleteCategory(id))
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Create(CategoriaModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            var category = new Categoria { Id = model.Id, Active = model.Active, Description = model.Description, Name = model.Name };
            categoryService.SaveCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var category = categoryService.SearchCategory(id);

            return View(new CategoriaModel { Id = category.Id, Name = category.Name, Active = category.Active, Description = category.Description });
        }

        [HttpPost]
        public ActionResult Edit(CategoriaModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var category = new Categoria { Id = model.Id, Active = model.Active, Description = model.Description, Name = model.Name };

            categoryService.EditCategory(category);

            return RedirectToAction("Index");
        }
    }
}