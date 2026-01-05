using CarSalesDb.Models;
using CarSalesDb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesDb.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        // GET: /Brand
        public IActionResult Index()
        {
            var brands = _brandService.GetAllBrands();
            return View(brands);
        }
        // GET: /Brand/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: /Brand/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid)
                return View(brand);
            _brandService.CreateBrand(brand);
            return RedirectToAction(nameof(Index));
        }
        // GET: /Brand/Edit/5
        public IActionResult Edit(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if (brand == null) return NotFound();
            return View(brand);
        }
        // POST: /Brand/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Brand brand)
        {
            if (!ModelState.IsValid)
                return View(brand);
            _brandService.UpdateBrand(brand);
            return RedirectToAction(nameof(Index));
        }
        // GET: /Brand/Delete/5
        public IActionResult Delete(int id)
        {
            _brandService.DeleteBrand(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
