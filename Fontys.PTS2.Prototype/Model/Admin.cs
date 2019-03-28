﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class Admin : User
    {
        public Admin(string firstName, string lastName, string address, string city, string postalCode, string emailAddress, DateTime dateBirth, Gender userGender, bool status) : base(firstName, lastName, address, city, postalCode, emailAddress, dateBirth, userGender, status)
        {
        }
    }
}
