using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    class ChatContextSQL : IChatContext
    {
        private const string ConnectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public DataTable GetAllOpenChatsAsDataTable(int userid)
        {
            try
            {
                string query = "SELECT U2.FirstName as ReceiverFirstName, U2.LastName as ReceiverLastName, C.ChatLogID, C.ReceiverID, C.SenderID, Q.Title as QuestionTitle, R.Description as Reactie, U.FirstName as SenderFirstName, U.LastName as SenderLastName, C.TimeStamp as TimeStamp FROM CHATLOG as C INNER JOIN Reaction as R on R.ReactionID = C.ReactionID INNER JOIN Question as Q on R.QuestionID = Q.QuestionID INNER JOIN [User] as U on U.UserID = C.SenderID INNER JOIN [User] as U2 on U2.UserID = C.ReceiverID WHERE C.ReceiverID = '" + userid + "'";
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

        public DataTable LoadMessagesAsDataTable(int chatID)
        {
            try
            {
                string query = "SELECT M.ChatID, M.SenderID, M.ReceiverID, M.Content, M.TimeStamp FROM [Message] M INNER JOIN ChatLog C ON C.ChatLogID = M.ChatID WHERE M.ChatID = '" + chatID + "'";
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

        public void SendMessage(int chatid, int receiverid, int senderid, string message)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {

                    CommandType = System.Data.CommandType.Text,
                    CommandText =
                        "INSERT INTO [Message] ([ChatID], [Content], [SenderID], [ReceiverID])" +
                        $"VALUES ({chatid}, '{message}', {senderid}, {receiverid})"


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
    }
}
