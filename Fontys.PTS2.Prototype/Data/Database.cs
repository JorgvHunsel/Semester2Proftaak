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
    class Database
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
                        "INSERT INTO [Question] ([Status], [Title], [Description], [Datetime], [Urgency], [User_ID])" +
                        $"VALUES ({askedQuestion.ToString() + ", '1' "})"
                };

                cmd.Connection = _conn;
                cmd.ExecuteNonQuery();
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

        public DataTable GetAllOpenQuestions()
        {
            try
            {
                string query = "SELECT [Title], [User_ID], [Datetime], [Urgency] FROM [Question] WHERE [Status] = 'Open'";
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
    }
}
