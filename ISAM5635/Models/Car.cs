using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635.Models
{
    public class Car
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



        public Car(int _carNum, string _brand,string _model,string _year,string _color, State _status, VehicleClass _class)
        {
            CarNum = _carNum;
            Brand = _brand;
            Model = _model;
            Year = _year;
            Color = _color;
            Status = _status;
            Class = _class;
        }

    }
}
