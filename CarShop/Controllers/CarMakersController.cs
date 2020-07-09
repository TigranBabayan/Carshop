using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;

namespace CarShop.Controllers
{
    public class CarMakersController : Controller
    {
        private readonly ApplicationContext _context;

        public CarMakersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: CarMakers
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarMakers.ToListAsync());
        }

        // GET: CarMakers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carMaker = await _context.CarMakers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carMaker == null)
            {
                return NotFound();
            }

            return View(carMaker);
        }

        // GET: CarMakers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarMakers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CarName")] CarMaker carMaker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carMaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carMaker);
        }

        // GET: CarMakers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carMaker = await _context.CarMakers.FindAsync(id);
            if (carMaker == null)
            {
                return NotFound();
            }
            return View(carMaker);
        }

        // POST: CarMakers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CarName")] CarMaker carMaker)
        {
            if (id != carMaker.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carMaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarMakerExists(carMaker.Id))
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
            return View(carMaker);
        }

        // GET: CarMakers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carMaker = await _context.CarMakers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carMaker == null)
            {
                return NotFound();
            }

            return View(carMaker);
        }

        // POST: CarMakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carMaker = await _context.CarMakers.FindAsync(id);
            _context.CarMakers.Remove(carMaker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarMakerExists(int id)
        {
            return _context.CarMakers.Any(e => e.Id == id);
        }
    }
}
