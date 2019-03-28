using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<string> GetAllUsers() => context.GetAllUsers();

        public void AddNewUser(string firstName, string lastName, DateTime birthDate, string gender, string email,
            string address, string postalCode, string city, string password, string accountType) =>
            context.AddNewUser(firstName, lastName, birthDate, gender, email, address, postalCode, city, password,
                accountType);

        //hier komen de methodes die gegevens doorgeven aan context.
    }
}
