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
        [Route("Cars")]
        [HttpGet]
        public List<Car> Get()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car(0, "Brand1", "Model1", "1994", "Red", Car.State.Available, Car.VehicleClass.SUV));
            cars.Add(new Car(2, "Brand2", "Model2", "2010", "Black", Car.State.Not_Available, Car.VehicleClass.Full_Size));
            cars.Add(new Car(3, "Brand1", "Model2", "2000", "Red", Car.State.Available, Car.VehicleClass.Compact));
            cars.Add(new Car(4, "Brand1", "Model1", "1998", "Yellow", Car.State.Available, Car.VehicleClass.Van));
            return cars;
        }
    }
}
