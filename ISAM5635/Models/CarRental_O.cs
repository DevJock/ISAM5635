using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635.Models
{
    public class CarRental_O
    {
        public int RentalID { get; set; }
        public string UserName { get; set; }
        public Location_O RentalLocation { get; set; }
        public Location_O PickUp { get; set; }
        public Location_O DropOff { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }


        public CarRental_O(int _rentalID, string _userName,Location_O _rentalLocation, Location_O _pickUp, Location_O _dropOff, DateTime _bookingStart, DateTime _bookingEnd)
        {
            RentalID = _rentalID;
            UserName = _userName;
            RentalLocation = _rentalLocation;
            PickUp = _pickUp;
            DropOff = _dropOff;
            BookingStart = _bookingStart;
            BookingEnd = _bookingEnd;
        }

    }
}
