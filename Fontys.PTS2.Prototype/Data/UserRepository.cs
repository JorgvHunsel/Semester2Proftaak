using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    public class UserRepository
    {
        private IUserContext context;

        public UserRepository()
        {
            this.context = new UserContextSQL();
        }

        public UserRepository(IUserContext context)
        {
            this.context = context;
        }

        public bool CheckValidityUser(string email, string password) => context.CheckValidityUser(email, password);

        public int GetUserId(string firstName) => context.GetUserId(firstName);

        public List<User> GetAllUsers() => context.GetAllUsers();

        public void AddNewUser(User newUser, string password) =>
            context.AddNewUser(newUser, password);

        public User getCurrentUserInfo(string email) => context.getCurrentUserInfo(email);

        public void EditUser(User currentUser, string password) => context.EditUser(currentUser, password);

        public bool CheckIfUserAlreadyExists(string email) => context.CheckIfUserAlreadyExists(email);

        public bool IsEmailValid(string email) => context.IsEmailValid(email);

        public bool CheckIfAccountIsActive(string email) =>
            context.CheckIfAccountIsActive(email);
    }
}
