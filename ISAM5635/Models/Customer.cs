using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635.Models
{
    public class Customer
    {
        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOBirth { get; set; }
        string License { get; set; }

        public Customer(string _userName, string _firstName, string _lastName, DateTime _dateOfBirth, string _license)
        {
            UserName = _userName;
            FirstName = _firstName;
            LastName = _lastName;
            DateOBirth = _dateOfBirth;
            License = _license;
        }
    }
}
