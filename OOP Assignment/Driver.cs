using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    internal class Driver
    {
        public int driverId;
        public string fullName;
        public string phoneNumber;
    
       public Driver(int DriverId, string FullName, string PhoneNumber ) 
       {
            driverId = DriverId;
            fullName = FullName;
            phoneNumber = PhoneNumber;
       }
    }
}
