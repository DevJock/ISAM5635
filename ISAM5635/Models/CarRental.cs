using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635.Models
{
    public class CarRental
    {
        public int RentalID { get; set; }
        public string UserName { get; set; }
        public Location RentalLocation { get; set; }
        public Location PickUp { get; set; }
        public Location DropOff { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }


        public CarRental(int _rentalID, string _userName,Location _rentalLocation, Location _pickUp, Location _dropOff, DateTime _bookingStart, DateTime _bookingEnd)
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
