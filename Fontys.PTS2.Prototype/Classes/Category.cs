using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.Classes
{
    class Category
    {
       
        private int CategoryID { get; set; }
        public string Name { get; private set; }
        private string Description { get; set; }

        public Category()
        {

        }

        public Category(int categoryID, string categoryName, string categoryDescription)
        {
            this.CategoryID = categoryID;
            this.Name = categoryName;
            this.Description = categoryDescription;
        }

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
            List<Category> categoryList = new List<Category>();
            Database db = new Database();

            DataTable table = db.GetAllCategories();

            foreach(DataRow row in table.Rows)
            {
                int categoryID = Convert.ToInt32(row["CategoryID"].ToString());
                string categoryName = row["Name"].ToString();
                string categoryDescription = row["Description"].ToString();

                Category category = new Category(categoryID, categoryName, categoryDescription);
                categoryList.Add(category);
            }

            return categoryList;
        }

        

        public void DeleteCategory(Category c)
        {
            //Delete the category tha's been given as parameter
        }
    }
}
