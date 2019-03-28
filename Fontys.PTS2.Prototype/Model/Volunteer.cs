﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class Volunteer : User
    {
        public Volunteer(string firstName, string lastName, string address, string city, string postalCode, string emailAddress, DateTime dateTime, Gender userGender, bool status) : base(firstName, lastName, address, city, postalCode, emailAddress, dateTime, userGender, status)
        {
        }

    }
}
