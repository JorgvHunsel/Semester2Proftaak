using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;

namespace Fontys.PTS2.Prototype.Data
{
    class Database
    {
        private const string ConnectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection _conn = new SqlConnection(ConnectionString);

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
                        $"VALUES ({askedQuestion.ToString()})"
                };
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

        public void GetAllOpenQuestions()
        {

        }
    }
}
