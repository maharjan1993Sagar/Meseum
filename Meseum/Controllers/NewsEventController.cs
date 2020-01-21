using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.UOW;
using Microsoft.AspNetCore.Mvc;
using Meseum.Models;

namespace Meseum.Controllers
{
    public class NewsEventController : Controller
    {
        private readonly IUnitOfWork _repo;

        public NewsEventController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public async Task<ActionResult> Index()
        {
            var NewsEvent = await _repo.NewsEvents.GetModel();
            return View(NewsEvent);
        }
        public async Task<IActionResult> Details(int id)
        {
            NewsEvent news = await _repo.NewsEvents.GetById(id);
            return View(news);
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int? id)
        {
            NewsEvent news = new NewsEvent();

           // ViewBag.Species = new SelectList(_repo.Species.GetModel(), "id", "speciesName");
            if (id.HasValue)
            {
                NewsEvent newsEvent = await _repo.NewsEvents.GetById(id.Value);
                

                if (newsEvent != null)
                {
                    news = newsEvent;
                }
            }
            return View(news);
        }
        [HttpPost]
        public ActionResult AddEdit(int? id, NewsEvent model)
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
                       _repo.NewsEvents.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        _repo.NewsEvents.Update(model);
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
            NewsEvent news = await _repo.NewsEvents.GetById(id);
            
            _repo.NewsEvents.Delete(id);

            return RedirectToAction("Index");

        }

    }
}