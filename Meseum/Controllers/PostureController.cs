using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.UOW;
using Microsoft.AspNetCore.Mvc;
using Meseum.Models;

namespace Meseum.Controllers
{
    public class PostureController : Controller
    {
        private readonly IUnitOfWork _repo;

        public PostureController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public async Task<ActionResult> Index()
        {
            var Postures =await _repo.Postures.GetModel();
            return View(Postures);
        }
        public async Task<IActionResult> Details(int id)
        {
            Posture Posture =await _repo.Postures.GetById(id);
            return View(Posture);

        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int? id)
        {
            Posture model = new Posture();

           // ViewBag.Species = new SelectList(_repo.Species.GetModel(), "id", "speciesName");
            if (id.HasValue)
            {

                Posture Posture =await _repo.Postures.GetById(id.Value);

                if (Posture != null)
                {
                    model = Posture;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEdit(int? id, Posture model)
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
                       _repo.Postures.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        _repo.Postures.Update(model);
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
        public async Task<IActionResult> Delete(int id)
        {
            Posture Posture =await _repo.Postures.GetById(id);
            _repo.Categories.Delete(id);

            return RedirectToAction("Index");

        }

    }
}