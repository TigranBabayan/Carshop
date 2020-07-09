using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CarShop.Controllers
{
    public class CarModelsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CarModelsController(ApplicationContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: CarModels
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.CarModels.Include(c => c.CarMaker);
            return View(await applicationContext.ToListAsync());
        }

        // GET: CarModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.CarModels
                .Include(c => c.CarMaker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carModel == null)
            {
                return NotFound();
            }

            return View(carModel);
        }

        // GET: CarModels/Create
        public IActionResult Create()
        {
            ViewBag.EngineValue = GetEngineValue();
            ViewBag.CarModelYear = GetCarModelYear().Reverse();
            ViewBag.DoorCount = GetDoorCount();
            ViewData["CarMakerId"] = new SelectList(_context.CarMakers, "Id", "CarName");
            return View();
        }

        // POST: CarModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( CarViewModel carModel)
        {
            if (ModelState.IsValid)
            {
                    string image = null;
                    List<string> uniqueFileName = UploadedFile(carModel);
                    foreach (var unique in uniqueFileName)
                    {
                        image += unique + '<';

                    };
                CarModel car = new CarModel
                {
                    ModelName = carModel.ModelName,
                    Modefication = carModel.Modefication,
                    Year = carModel.Year,
                    Bodystyle = carModel.Bodystyle,
                    Mileage = carModel.Mileage,
                    CarModelColor = carModel.CarModelColor,
                    Gearbox = carModel.Gearbox,
                    Fueltype = carModel.Fueltype,
                    Handdrive = carModel.Handdrive,
                    Customcleared = carModel.Customcleared,
                    Price = carModel.Price,
                    CarModelImage = image,
                    TopAnnouncements = carModel.TopAnnouncements,
                    EngineValue = carModel.EngineValue,
                    Description = carModel.Description,
                    HoursePower = carModel.HoursePower,
                    CarModelExteriorColor = carModel.CarModelExteriorColor,
                    DoorCount = carModel.DoorCount,
                    Drivetrain = carModel.Drivetrain,
                    Condition = carModel.Condition,
                    Vin = carModel.Vin,
                    CarMakerId = carModel.CarMakerId,
                    CarMaker = carModel.CarMaker,
                    };

                    _context.Add(car);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                
              
            }
            ViewData["CarMakerId"] = new SelectList(_context.CarMakers, "Id", "CarName");
            return View(carModel);
        }

        // GET: CarModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.EngineValue = GetEngineValue();
            ViewBag.CarModelYear = GetCarModelYear().Reverse();
            ViewBag.DoorCount = GetDoorCount();
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.CarModels.FindAsync(id);
            if (carModel == null)
            {
                return NotFound();
            }
            ViewData["CarMakerId"] = new SelectList(_context.CarMakers, "Id", "CarName");
            return View(carModel);
        }

        // POST: CarModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CarViewModel carModel)
        {
            if (id != carModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (carModel.CarModelImage == null)
                {
                    CarModel car = new CarModel();
                  
                    
                }
                try
                {
                    string image = null;
                    List<string> uniqueFileName = UploadedFile(carModel);
                    foreach (var unique in uniqueFileName)
                    {
                        image += unique + '<';

                    };
                    CarModel car = new CarModel
                    {
                        Id = id,
                        ModelName = carModel.ModelName,
                        Modefication = carModel.Modefication,
                        Year = carModel.Year,
                        Bodystyle = carModel.Bodystyle,
                        Mileage = carModel.Mileage,
                        CarModelColor = carModel.CarModelColor,
                        Gearbox = carModel.Gearbox,
                        Fueltype = carModel.Fueltype,
                        Handdrive = carModel.Handdrive,
                        Customcleared = carModel.Customcleared,
                        Price = carModel.Price,

                         CarModelImage = image,
                        TopAnnouncements = carModel.TopAnnouncements,
                        EngineValue = carModel.EngineValue,
                        Description = carModel.Description,
                        HoursePower = carModel.HoursePower,
                        CarModelExteriorColor = carModel.CarModelExteriorColor,
                        DoorCount = carModel.DoorCount,
                        Drivetrain = carModel.Drivetrain,
                        Condition = carModel.Condition,
                        Vin = carModel.Vin,
                        CarMakerId = carModel.CarMakerId,
                        CarMaker = carModel.CarMaker,
                    };
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarModelExists(carModel.Id))
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
            ViewData["CarMakerId"] = new SelectList(_context.CarMakers, "Id", "CarName", carModel.CarMakerId);
            return View(carModel);
        }

        // GET: CarModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.CarModels
                .Include(c => c.CarMaker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carModel == null)
            {
                return NotFound();
            }

            return View(carModel);
        }

        // POST: CarModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var carModel = await _context.CarModels.FindAsync(id);
            var splitedImageName = SplitImageName(carModel.CarModelImage);
            foreach (var img in splitedImageName)
            {
            var imagePath = Path.Combine(webHostEnvironment.WebRootPath, "images", img);
                if (System.IO.File.Exists(imagePath))
                
                    System.IO.File.Delete(imagePath);
                
            }
         
            _context.CarModels.Remove(carModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarModelExists(int id)
        {
            return _context.CarModels.Any(e => e.Id == id);
        }

        public IEnumerable<string> GetEngineValue()
        {
            for (decimal i = 0.1M; i <= 7.3M; i+=0.1M)
            {
                var engine = i.ToString(CultureInfo.CreateSpecificCulture("de-DE"));
                yield return engine;
            }
        }

        public IEnumerable<int> GetCarModelYear()
        {
            var carDate = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            for (int i = 1911; i <= carDate +1; i++)
            {
                yield return i;
            }
        }

        public IEnumerable<int> GetDoorCount()
        {
            for (int i = 1; i < 6; i++)
            {
                yield return i;
            }
        }

        private List<string> UploadedFile(CarViewModel model)
        {
            List<string> uniqueFileName = new List<string>();
            string filePath = null;

            if (model.CarModelImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                foreach (IFormFile item in model.CarModelImage)
                {

                    uniqueFileName.Add(item.FileName);
                    filePath = Path.Combine(uploadsFolder, item.FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        item.CopyTo(fileStream);
                    }
                }
            }
            return uniqueFileName;
        }


 
   public List<string> SplitImageName(string ProfilePicture)
        {
            List<string> imageName = new List<string>();


            string[] splitedImageName = ProfilePicture.Split('<');

            foreach (var imgName in splitedImageName)
            {
                imageName.Add(imgName);
            }


            return imageName;

        }
    }

}
