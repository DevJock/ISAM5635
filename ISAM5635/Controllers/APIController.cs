using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISAM5635.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISAM5635.Controllers
{
    [Route("api/")]
    public class APIController : Controller
    {

        private RentalDB _context;
        public APIController(RentalDB context)
        {
            _context = context;
        }


        [Route("fleet/")]
        [HttpPost]
        public IActionResult GetAvailableCars()
        {
            return Json(_context.Car.ToList());
        }

        [Route("fleet/car/")]
        [HttpPost]
        public IActionResult CarDetails()
        {
            int id = Convert.ToInt32(Request.Form["CarId"]);
            var item = (from Car c in _context.Car
                        where c.CarId == id
                        select c).FirstOrDefault();
            return Json(item);
        }

        [Route("fleet/add/")]
        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
            return Json(car);
        }


        [Route("fleet/update/")]
        [HttpPost]
        public IActionResult UpdateCar([FromBody] Car car)
        {
            var item = (from Car c in _context.Car
                        where c.CarId == car.CarId
                        select c).FirstOrDefault();
            _context.Car.Remove(item);
            _context.Add(car);
            _context.SaveChanges();
            return Json(car);
        }
    }
}
