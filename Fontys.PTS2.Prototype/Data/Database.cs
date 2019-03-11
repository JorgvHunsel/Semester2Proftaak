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

        public void WriteQuestionToDatabase(Question askedQuestion)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    
                    CommandType = System.Data.CommandType.Text,
                    CommandText =
                        "INSERT INTO [Question] ([Status], [Title], [Description], [Datetime], [Urgency], [CategoryID], [CareRecipientID])" +
                        $"VALUES ({askedQuestion.ToString() + ", '1' "})"


                };

                cmd.Connection = _conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable GetAllOpenQuestions()
        {
            try
            {
                string query = "SELECT  Q.[Title], Q.[CareRecipientID], Q.[Datetime], Q.[Urgency], C.[Name], Q.[QuestionID] FROM[Question] as Q INNER JOIN[Category] as C ON Q.CategoryId = C.CategoryID  WHERE[Status] = 'Open'";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                return dt;

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
