using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;

namespace Fontys.PTS2.Prototype.Data.Contexts
{
    public interface IUserContext
    {
        void AddNewUser(string firstName, string lastName, DateTime birthDate, string gender, string email,
            string address, string postalCode, string city, string password, string accountType);

        List<string> GetAllUsers();

        int GetUserId(string firstName);

        bool CheckValidityUser(string email, string password);

        User getCurrentUserInfo(string email);

        void EditUser(User currentUser);

        bool CheckIfUserAlreadyExists(string email);

        bool IsEmailValid(string email);
    }
}
