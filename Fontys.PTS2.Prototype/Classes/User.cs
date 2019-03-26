using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    abstract class User
    {
        public enum AccountType { CareRecipient, Volunteer, Professional, Admin }
        public enum Gender { M, V, A }
        public int UserId { get; set; }
        public string FirstName { get; private set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private string City { get; set; }
        private string PostalCode { get; set; }
        private string EmailAddress { get; set; }
        private int Age { get; set; }
        private Gender UserGender { get; set; }
        private AccountType UserAccountType { get; set; }
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

        public static bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
