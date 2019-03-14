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
    class DatabaseChat
    {
        private const string ConnectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public List<ChatLog> GetAllOpenChats()
        {
            try
            {
                string query = "SELECT U2.FirstName as ReceiverFirstName, U2.LastName as ReceiverLastName, C.ChatLogID, C.MessageID, C.ReceiverID, C.SenderID, Q.Title as QuestionTitle, R.Description as Reactie, U.FirstName as SenderFirstName, U.LastName as SenderLastName FROM CHATLOG as C" +
                "INNER JOIN Reaction as R on R.ReactionID = C.ReactionID" +
                "INNER JOIN Question as Q on R.QuestionID = Q.QuestionID" +
                "INNER JOIN[User] as U on U.UserID = C.SenderID" +
                "INNER JOIN[User] as U2 on U2.UserID = C.ReceiverID" +
                "WHERE C.SenderID = 1";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);


                List<ChatLog> chatLogList = new List<ChatLog>();
                
                foreach (DataRow row in dt.Rows)
                {
                    int chatLogID = Convert.ToInt32(row["ChatLogID"].ToString());
                    string questionTitle = row["QuestionTitle"].ToString();
                    int senderID = Convert.ToInt32(row["SenderID"].ToString());
                    int receiverID = Convert.ToInt32(row["ReceiverID"].ToString());
                    string receiverLastName = row["ReceiverLastName"].ToString();
                    string receiverFirstName = row["ReceiverFirstName"].ToString();
                    string senderLastName = row["SenderLastName"].ToString();
                    string senderFirstName = row["SenderFirstName"].ToString();

                    ChatLog chatLog = new ChatLog(chatLogID, questionTitle, senderID, receiverID, receiverLastName, receiverFirstName, senderLastName, senderFirstName);
                    chatLogList.Add(chatLog);
                }

                return chatLogList;
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
