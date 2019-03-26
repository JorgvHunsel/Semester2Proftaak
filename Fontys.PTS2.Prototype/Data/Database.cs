using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;

namespace Fontys.PTS2.Prototype.Data
{
    public class Database
    {
        private const string ConnectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public List<Category> GetAllCategories()
        {
            try
            {
                string query = "SELECT [CategoryID], [Name], [Description] FROM [Category]";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                List<Category> categoryList = new List<Category>();
                

                foreach (DataRow row in dt.Rows)
                {
                    int categoryID = Convert.ToInt32(row["CategoryID"].ToString());
                    string categoryName = row["Name"].ToString();
                    string categoryDescription = row["Description"].ToString();

                    Category category = new Category(categoryID, categoryName, categoryDescription);
                    categoryList.Add(category);
                }

                return categoryList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
