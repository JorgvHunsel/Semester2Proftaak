using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    abstract class User
    {
        public enum Gender { Male, Female, Other}
        private int UserId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private string City { get; set; }
        private string PostalCode { get; set; }
        private string EmailAddress { get; set; }
        private int Age { get; set; }
        private Gender UserGender { get; set; }
        private bool Status { get; set; }

        protected User(int userId, string firstName, string lastName, string address, string city, string postalCode, string emailAddress, int age, Gender userGender, bool status)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            PostalCode = postalCode;
            EmailAddress = emailAddress;
            Age = age;
            UserGender = userGender;
            Status = status;
        }

        public User NewUser(int userId, string firstName, string lastName, string address, string city,
            string postalCode, string emailAddress, int age, Gender userGender, bool status)
        {
            return null;
        }


    }
}
