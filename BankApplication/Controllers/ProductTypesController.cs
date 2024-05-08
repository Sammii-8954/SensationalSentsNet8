using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankApplication.Data;
using SensationalScentsWeb.Data;
using AutoMapper;
using SensationalScentsWeb.Models;
using SensationalScentsWeb.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace SensationalScentsWeb.Controllers
{
    [Authorize]
    public class ProductTypesController : Controller
    {
        
        private readonly IProductTypeRepository productTypeRepository;
        private readonly IMapper mapper;

        public ProductTypesController(IProductTypeRepository productTypeRepository, IMapper mapper)
        {
            
            this.productTypeRepository = productTypeRepository;
            this.mapper = mapper;
        }

        // GET: ProductTypes
        public async Task<IActionResult> Index()
        { 
            //var ProductTypes =  await productTypeRepository.GetAllAsync();
            var ProductTypes = mapper.Map<List<ProductTypeVM>> (await productTypeRepository.GetAllAsync());
            return View(ProductTypes);
        }

        // GET: ProductTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var productType = await productTypeRepository.GetAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            var productTypeVM = mapper.Map<ProductTypeVM>(productType);
            return View(productTypeVM);

            
        }
        [Authorize(Roles = "Administrator")]
        // GET: ProductTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypeVM productTypeVM) //consder adjusting 
        {
            if (ModelState.IsValid)
            {
                var productType = mapper.Map<ProductType>(productTypeVM);
                await productTypeRepository.AddAsync(productType);
                return RedirectToAction(nameof(Index));
            }
            return View(productTypeVM);
        }
        [Authorize(Roles = "Administrator")]
        // GET: ProductTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var productType = await productTypeRepository.GetAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            var productTypeVM = mapper.Map<ProductTypeVM>(productType);
            return View(productTypeVM);
        }
        [Authorize(Roles = "Administrator")]
        // POST: ProductTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductTypeVM productTypeVM)
        {
            if (id != productTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var productType = mapper.Map<ProductType>(productTypeVM);
                    await productTypeRepository.UpdateAsync(productType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ProductTypeExistsAsync(productTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productTypeVM);
        }


        [Authorize(Roles = "Administrator")]
        // POST: ProductTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await productTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProductTypeExistsAsync(int id)
        {
            return  await productTypeRepository.Exists(id);
        }
    }
}
