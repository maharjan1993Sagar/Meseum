using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.UOW;
using Microsoft.AspNetCore.Mvc;
using Meseum.Models;

namespace Meseum.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _repo;

        public CategoryController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public async Task<ActionResult> Index()
        {
            var Categorys =await _repo.Categories.GetModel();
            return View(Categorys);
        }
        public async Task<IActionResult> Details(int id)
        {
            Category Category =await _repo.Categories.GetById(id);
            return View(Category);

        }

        [HttpGet]
        public async Task<IActionResult> AddEditCategory(int? id)
        {
            Category model = new Category();

           // ViewBag.Species = new SelectList(_repo.Species.GetModel(), "id", "speciesName");
            if (id.HasValue)
            {

                Category Category =await _repo.Categories.GetById(id.Value);

                if (Category != null)
                {
                    model = Category;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditCategory(int? id, Category model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = false;
                    //FeedFooder feed = isNew ? new FeedFooder { } : _repo.GetById(id.Value);
                    // feed = model;
                    if (!id.HasValue)
                    {
                        model.UpdatedBy = "admin";
                        isNew = true;
                    }
                    if (isNew)
                    {

                        model.Id = 0;
                        model.UpdatedAt = DateTime.Now;
                       _repo.Categories.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        _repo.Categories.Update(model);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            Category Category =await _repo.Categories.GetById(id);
            _repo.Categories.Delete(id);

            return RedirectToAction("Index");

        }

    }
}