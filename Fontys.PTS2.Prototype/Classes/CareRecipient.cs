using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class CareRecipient : User
    {
        public CareRecipient(int userId, string firstName, string lastName, string address, string city, string postalCode, string emailAddress, int age, Gender userGender, bool status) : base(userId, firstName, lastName, address, city, postalCode, emailAddress, age, userGender, status)
        {
        }
    }
}
