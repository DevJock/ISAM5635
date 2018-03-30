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
            Car[] cars = _context.Car.ToArray();
            return View(cars);
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
