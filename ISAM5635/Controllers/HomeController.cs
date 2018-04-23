using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISAM5635.Models;

namespace ISAM5635.Controllers
{
    public class HomeController : Controller
    {

        private RentalDB _context;
        public HomeController(RentalDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cars = from c in _context.Car  select c;
            return View(cars);
        }

        public IActionResult RentCars()
        {
            var cars = from c in _context.CarRental select c;
            return View(cars);
        }


        [HttpGet]
        public IActionResult AddCar()
        {
      
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car cars)
        {
            _context.Add(cars);
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Details(int carId)
        {
            var item = (from Car c in _context.Car
                        where c.CarId == carId
                        select c).FirstOrDefault();
            
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int carId)
        {
            var item = (from Car c in _context.Car
                        where c.CarId == carId
                        select c).FirstOrDefault();

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Car cars)
        {
            //_context.Add(cars);
            _context.Update(cars);
            _context.SaveChanges();
            return View("Index");
        }

        [HttpGet]
        public IActionResult Delete(int carId)
        {
            var item = (from Car c in _context.Car
                        where c.CarId == carId
                        select c).FirstOrDefault();

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Car cars)
        {
            //_context.Add(cars);
            _context.Remove(cars);
            _context.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
