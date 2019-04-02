using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class Professional : User
    {
        public Professional(string firstName, string lastName, string address, string city, string postalCode, string emailAddress, DateTime dateTime, Gender userGender, bool status, AccountType accountType) : base(firstName, lastName, address, city, postalCode, emailAddress, dateTime, userGender, status, accountType)
        {
        }
    }
}
