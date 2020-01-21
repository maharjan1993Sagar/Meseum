using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.UOW;
using Microsoft.AspNetCore.Mvc;
using Meseum.Models;

namespace Meseum.Controllers
{
    public class LocationsController : Controller
    {
        private readonly IUnitOfWork _repo;

        public LocationsController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public async Task<ActionResult> Index()
        {
            var locations =await _repo.Locations.GetModel();
            return View(locations);
        }
        public async Task<IActionResult> Details(int id)
        {
            Location location =await _repo.Locations.GetById(id);
            return View(location);

        }

        [HttpGet]
        public async Task<IActionResult> AddEditLocation(int? id)
        {
            Location model = new Location();

           // ViewBag.Species = new SelectList(_repo.Species.GetModel(), "id", "speciesName");
            if (id.HasValue)
            {

                Location location =await _repo.Locations.GetById(id.Value);

                if (location != null)
                {
                    model = location;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditLocation(int? id, Location model)
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
                       _repo.Locations.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        _repo.Locations.Update(model);
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
        public async Task<IActionResult> DeleteLocation(int id)
        {
            Location location =await _repo.Locations.GetById(id);
            _repo.Locations.Delete(id);

            return RedirectToAction("Index");

        }

    }
}