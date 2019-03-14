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
    class QueryQuestion
    {
        private const string ConnectionString =
            @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public static string GetQuestionName(int questionId)
        {
            try
            {
                string query = "SELECT [Title] FROM [Question] WHERE [QuestionID] = " + questionId.ToString();
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                string questionTitle = "";

                foreach (DataRow row in dt.Rows)
                {
                    questionTitle = row["Title"].ToString();
                }

                return questionTitle;
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

        public static string GetQuestionDescription(int questionId)
        {
            try
            {
                string query = "SELECT [Description] FROM [Question] WHERE [QuestionID] = " + questionId.ToString();
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                string description = "";

                foreach (DataRow row in dt.Rows)
                {
                    description = row["Description"].ToString();
                }

                return description;
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
