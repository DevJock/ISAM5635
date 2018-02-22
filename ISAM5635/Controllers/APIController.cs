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
        [Route("fleet")]
        [HttpPost]
        public List<Car> GetAvailableCars()
        {
            return null;
        }


        [Route("fleet/{carnum}")]
        [HttpPost]
        public string GetCar(int carnum)
        {
            return carnum.ToString();
        }

        [Route("fleet/add{car}")]
        [HttpPost]
        public string AddCar(string car)
        {
            return "Success";
        }





    }
}
