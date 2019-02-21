using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class Category
    {
        private int CategoryId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }

        public void AddCategory(string name)
        {
            //Add new Category
        }

        public void EditCategory(Category c)
        {
            //Edit c.Description
        }

        public List<Category> GetAllCategories()
        {
            return null;
            //Returns all categories in a list
        }

        public void DeleteCategory(Category c)
        {
            //Delete the category tha's been given as parameter
        }
    }
}
