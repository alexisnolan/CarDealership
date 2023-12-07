using CarDealership.Data;
using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {
        private CarsDBContext _context;
        public CarController(CarsDBContext context) 
        {
            _context = context ;
        }
        public IActionResult Index()
        {
           var carsList = _context.cars.ToList(); // fetches a list of books from db
            return View(carsList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Add(Car carobj)
        {
            _context.cars.Add(carobj); //adds obj to be added
            _context.SaveChanges(); // runs pending command on commits

            return RedirectToAction("Index", "Car");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //fetch car from cars table
            Car myCar = _context.cars.Find(id);
            return View(myCar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CarID, Mileage, DateReceived, DateSold, Status, VIN, Make, Model, Year")] Car myCar) 
        {
            if(ModelState.IsValid)
            {
				_context.cars.Update(myCar);
				_context.SaveChanges();
			}

            return RedirectToAction("Index", "Car");
            
        
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
           var myCar = _context.cars.Find(id);
           return View(myCar);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var myCar = _context.cars.Find(id);

            if (myCar != null)
            {
                _context.cars.Remove(myCar);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        
        }
    }
}
