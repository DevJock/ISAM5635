using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635.Models
{
    public class Car_O
    {
        public enum State
        {
            Available,
            Not_Available
        }

        public enum VehicleClass
        {
            Compact,
            Mid_Size,
            Full_Size,
            Van,
            SUV
        }

        public int CarNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public State Status { get; set; }
        public VehicleClass Class { get; set; }



        public Car_O(int _carNum, string _brand,string _model,string _year,string _color, State _status, VehicleClass _class)
        {
            CarNum = _carNum;
            Brand = _brand;
            Model = _model;
            Year = _year;
            Color = _color;
            Status = _status;
            Class = _class;
        }


        public static List<Car_O> SampleData()
        {
            List<Car_O> cars = new List<Car_O>();
            cars.Add(new Car_O(0, "Brand1", "Model1", "1994", "Red", Car_O.State.Available, Car_O.VehicleClass.SUV));
            cars.Add(new Car_O(2, "Brand2", "Model2", "2010", "Black", Car_O.State.Not_Available, Car_O.VehicleClass.Full_Size));
            cars.Add(new Car_O(3, "Brand1", "Model2", "2000", "Red", Car_O.State.Available, Car_O.VehicleClass.Compact));
            cars.Add(new Car_O(4, "Brand1", "Model1", "1998", "Yellow", Car_O.State.Available, Car_O.VehicleClass.Van));
            return cars;
        }




    }
}
