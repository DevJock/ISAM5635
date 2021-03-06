﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISAM5635.Models
{
    public partial class Car
    {
        public Car()
        {
            CarRental = new HashSet<CarRental>();
        }

        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public string CategoryType { get; set; }

        public Category CategoryTypeNavigation { get; set; }
        public ICollection<CarRental> CarRental { get; set; }

        public override string ToString()
        {
            return $"{CarId}, {Brand},{ProductionYear},{Color},{Status},{CategoryType}";
        }

    }
}
