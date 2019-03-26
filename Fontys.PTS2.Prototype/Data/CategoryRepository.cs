using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    public class CategoryRepository
    {
        private ICategoryContext context;

        public CategoryRepository()
        {
            this.context = new CategoryContextSQL();
        }

        public CategoryRepository(ICategoryContext context)
        {
            this.context = context;
        }

        public List<Category> GetAllCategories() => context.GetAllCategories();
    }
}
