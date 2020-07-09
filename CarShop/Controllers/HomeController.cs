using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarShop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.carMaker = _context.CarMakers.ToList();
            ViewBag.carsImages = _context.CarModels.ToList();
            return View(_context.CarModels.ToList());
        }

        public IActionResult GetCar(int id)
        {
            var car = _context.CarModels.Include(c => c.CarMaker).FirstOrDefault(m=>m.Id==id);
            
            return View(car);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
