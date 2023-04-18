﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHotel.DataAccess.Model
{
    internal class Guest
    {
        public int GuestID { get; set; }
        public int BookingID { get; set; }
        public enum GuestPriority { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthdayDate { get; set; }
        public enum Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PassportNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public List<Booking> Bookings { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
