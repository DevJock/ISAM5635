using System;
using System.Collections.Generic;

namespace ISAM5635.Models
{
    public partial class Location
    {
        public Location()
        {
            CarRental = new HashSet<CarRental>();
        }

        public string LocationName { get; set; }

        public ICollection<CarRental> CarRental { get; set; }
    }
}
