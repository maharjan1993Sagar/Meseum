using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.UOW;
using Microsoft.AspNetCore.Mvc;
using Meseum.Models;
using Meseum.Mapping;
using AutoMapper;
using Meseum.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Meseum.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _env;

        public InventoryController(IUnitOfWork repo, IMapper mapper, IHostingEnvironment env)
        {
            _repo = repo;
            _mapper = mapper;
            _env = env;
        }
        public async Task<ActionResult> Index()
        {
            var inventory = await _repo.Inventories.GetModel();
            return View(inventory);
        }
        public async Task<IActionResult> Details(int id)
        {
            Inventory inventory = await _repo.Inventories.GetById(id);
            return View(inventory);
        }
        public async Task<ActionResult> Add()
        {
            InventoryVM inventoryVM = new InventoryVM();
            inventoryVM.Categories = new SelectList(await _repo.Categories.GetModel(), "Id", "Name");
            inventoryVM.Locations = new SelectList(await _repo.Locations.GetModel(), "Id", "Name");
            inventoryVM.UpdatedAt = DateTime.Now;
            inventoryVM.UpdatedBy = User.Identity.Name;
            return View(inventoryVM);
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(InventoryVM inventoryVM)
        {
            if (ModelState.IsValid)
            {
                IFormFile[] files = inventoryVM.Files;

                inventoryVM.UpdatedAt = DateTime.Now;
                inventoryVM.UpdatedBy = User.Identity.Name;
                Inventory inventory = _mapper.Map<InventoryVM, Inventory>(inventoryVM);
                _repo.Inventories.Insert(inventory);
                _repo.Save();

                IEnumerable<Inventory> inventories = await _repo.Inventories.GetModel();
                int id = inventories.OrderByDescending(m => m.Id).First().Id;

              
                var folderpath = Path.Combine(_env.ContentRootPath, "wwwroot\\Admin\\images\\Inventories\\Thumb");

                if (!Directory.Exists(folderpath))
                {
                    Directory.CreateDirectory(folderpath);
                }

                string fileName = inventoryVM.File.FileName;
                using (var fileStream = new FileStream(Path.Combine(folderpath,id+".jpg"), FileMode.Create, FileAccess.Write))
                {
                    inventoryVM.File.CopyTo(fileStream);
                }

                var ImageFolder = Path.Combine(_env.ContentRootPath, "wwwroot\\Admin\\images\\Inventories\\", id.ToString());
                if (inventoryVM.Files != null)
                {
                   

                    if (!Directory.Exists(ImageFolder))
                    {
                        Directory.CreateDirectory(ImageFolder);
                    }

                }


                foreach (var file in inventoryVM.Files)
                {
                    using (var fileStream = new FileStream(Path.Combine(ImageFolder,file.FileName ), FileMode.Create, FileAccess.Write))
                    {
                        file.CopyTo(fileStream);
                    }
                }
              
                return RedirectToAction("Index");
            }

            inventoryVM.Categories = new SelectList(await _repo.Categories.GetModel(), "Id", "Name", inventoryVM.CategoryId);
            inventoryVM.Locations = new SelectList(await _repo.Locations.GetModel(), "Id", "Name", inventoryVM.LocationId);
            return View(inventoryVM);
        }
        public async Task<ActionResult> Edit(int? id)
        {
            if (id.HasValue)
            {
                InventoryVM inventoryVM = new InventoryVM();
                 Inventory inventory   = await _repo.Inventories.GetById(id.Value);
                inventoryVM = _mapper.Map<Inventory, InventoryVM>(inventory);
                inventoryVM.Categories = new SelectList(await _repo.Categories.GetModel(), "Id", "Name",inventory.CategoryId);
                inventoryVM.Locations = new SelectList(await _repo.Locations.GetModel(), "Id", "Name",inventory.LocationId);
                inventoryVM.UpdatedAt = DateTime.Now;
                inventoryVM.UpdatedBy = User.Identity.Name;
                return View(inventoryVM);
            }
            else
            {
                return BadRequest();
            }
           
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id,InventoryVM inventoryVM)
        {
            if (ModelState.IsValid)
            {

                IFormFile[] files = inventoryVM.Files;
                inventoryVM.UpdatedAt = DateTime.Now;
                inventoryVM.UpdatedBy = User.Identity.Name;
                Inventory inventory = _mapper.Map<InventoryVM, Inventory>(inventoryVM);

                _repo.Inventories.Insert(inventory);
                _repo.Save();

                IEnumerable<Inventory> inventories = await _repo.Inventories.GetModel();
              


                var folderpath = Path.Combine(_env.ContentRootPath, "wwwroot\\Admin\\images\\Inventories\\Thumb");

                if (!Directory.Exists(folderpath))
                {
                    Directory.CreateDirectory(folderpath);
                }

                string fileName = inventoryVM.File.FileName;
                using (var fileStream = new FileStream(Path.Combine(folderpath, id + ".jpg"), FileMode.Create, FileAccess.Write))
                {
                    inventoryVM.File.CopyTo(fileStream);
                }

                var ImageFolder = Path.Combine(_env.ContentRootPath, "wwwroot\\Admin\\images\\Inventories\\", id.ToString());
                if (inventoryVM.Files != null)
                {


                    if (!Directory.Exists(ImageFolder))
                    {
                        Directory.CreateDirectory(ImageFolder);
                    }

                }


                foreach (var file in inventoryVM.Files)
                {
                    using (var fileStream = new FileStream(Path.Combine(ImageFolder, file.FileName), FileMode.Create, FileAccess.Write))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                return RedirectToAction("Index");
            }

            inventoryVM.Categories = new SelectList(await _repo.Categories.GetModel(), "Id", "Name", inventoryVM.CategoryId);
            inventoryVM.Locations = new SelectList(await _repo.Locations.GetModel(), "Id", "Name", inventoryVM.LocationId);
            return View(inventoryVM);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Inventory inventory = await _repo.Inventories.GetById(id);
            _repo.Inventories.Delete(id);
            
            return RedirectToAction("Index");

        }

    }
}