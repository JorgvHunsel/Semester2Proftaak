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

        //hier komen de methodes die gegevens doorgeven aan context.
    }
}
