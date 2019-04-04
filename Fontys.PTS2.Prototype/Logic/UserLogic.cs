using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.Logic
{
    public class UserLogic
    {
        static UserRepository userRepo = new UserRepository();

        // hier komt de verbinding tussen de repos en de view. zie category repository
        public static bool CheckValidityUser(string email, string password)
        {
            return userRepo.CheckValidityUser(email, password);
        }

        public static int GetUserId(string firstName)
        {
            return userRepo.GetUserId(firstName);
        }

        public static List<string> GetAllUsers()
        {
            return userRepo.GetAllUsers();
        }

        public static void AddNewUser(string firstName, string lastName, DateTime birthDate, User.Gender gender, string email,
            string address, string postalCode, string city, string password, string accountType)
        {
            if (accountType == "Volunteer")
            {
                Volunteer currentUser = new Volunteer(firstName, lastName, address, city, postalCode, address, birthDate, gender,
                    true, User.AccountType.Volunteer);
            }
            else if (accountType == "Admin")
            {
                Admin currentUser = new Admin(firstName, lastName, address, city, postalCode, address, birthDate, gender,
                    true, User.AccountType.Admin);
            }
            else if (accountType == "CareRecipient")
            {
                CareRecipient currentUser = new CareRecipient(firstName, lastName, address, city, postalCode, address, birthDate, gender,
                    true, User.AccountType.CareRecipient);
            }
            else if (accountType == "Professional")
            {
                Professional currentUser = new Professional(firstName, lastName, address, city, postalCode, address, birthDate, gender,
                    true, User.AccountType.Professional);
            }

            string genderString = gender.ToString();
            userRepo.AddNewUser(firstName, lastName, birthDate, genderString, email, address, postalCode, city, password, accountType);
        }

        public static User getCurrentUserInfo(string email)
        {
            return userRepo.getCurrentUserInfo(email);
        }

        public static void EditUser(User currentUser)
        {
            userRepo.EditUser(currentUser);
        }

        public static bool CheckIfUserAlreadyExists(string email)
        {
            return userRepo.CheckIfUserAlreadyExists(email);
        }

        public static bool IsEmailValid(string email)
        {
            return userRepo.IsEmailValid(email);
        }
    }
}
