using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    public class QuestionContextSQL : IQuestionContext
    {
        //Er mogen geen static methodes hier voorkomen. Je maakt ze pas static bij de questionrepos
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

        public static void WriteQuestionToDatabase(Question askedQuestion)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {

                    CommandType = System.Data.CommandType.Text,
                    CommandText =
                        "INSERT INTO [Question] ([Status], [Title], [Description], [Datetime], [Urgency], [CategoryID], [CareRecipientID])" +
                        $"VALUES ({askedQuestion.ToString() + ", '1'"})"
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

        public static DataTable GetAllOpenQuestions()
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

        public static Question LoadSingleQuestion(int questionID)
        {
            try
            {
                string query =
                    "SELECT  * FROM [Question] AS Q INNER JOIN [Category] AS C ON Q.CategoryId = C.CategoryID WHERE Q.[QuestionID] = '" + questionID + "'";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                int QuestionID = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                string status = dt.Rows[0].ItemArray[3].ToString();
                string title = dt.Rows[0].ItemArray[4].ToString();
                string content = dt.Rows[0].ItemArray[5].ToString();
                DateTime dateTime = Convert.ToDateTime(dt.Rows[0].ItemArray[6]);
                string urgency = dt.Rows[0].ItemArray[7].ToString();

                int CategoryID = Convert.ToInt32(dt.Rows[0].ItemArray[2]);
                string CategoryName = dt.Rows[0].ItemArray[9].ToString();
                string CategoryDescription = dt.Rows[0].ItemArray[10].ToString();

                Category category = new Category(CategoryID, CategoryName, CategoryDescription);

                Question question = new Question(title, content, Question.QuestionStatus.Open, dateTime, urgency, category);
                return question;

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

        public static void EditQuestion(int questionID, string subjectNew, string contentNew, Category category, string urgency)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {

                    CommandType = System.Data.CommandType.Text,
                    CommandText =
                        "UPDATE Question SET CategoryId = '" + category.CategoryID + "', Title = '" + subjectNew + "', Description = '" + contentNew + "', Urgency = '" + urgency + "' WHERE QuestionID = '" + questionID + "'"
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

        public static void EditQuestion(int questionID, string subjectNew, string contentNew, string urgency)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {

                    CommandType = System.Data.CommandType.Text,
                    CommandText =
                        "UPDATE Question SET Title = '" + subjectNew + "', Description = '" + contentNew + "', Urgency = '" + urgency + "' WHERE QuestionID = '" + questionID + "'"
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
    }
}
