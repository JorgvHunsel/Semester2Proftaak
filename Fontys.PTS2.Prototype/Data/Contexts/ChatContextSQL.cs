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

        public List<ChatLog> GetAllOpenChatsWithVolunteerID(int userid)
        {
            List<ChatLog> chatLogList = new List<ChatLog>();
            try
            {
                string query = "SELECT Chatlog.[ChatLogID]" +
                               ", Chatlog.[ReactionID]" +
                               ", Chatlog.[CareRecipientID]" +
                               ", Chatlog.[VolunteerID]" +
                               ", Chatlog.[TimeStamp]" +
                               ", Question.[Title]" +


                               ", [Volunteer].Firstname as VolunteerFirstName" +
                               ", [Volunteer].LastName as VolunteerLastName" +

                               ", [CareRecipient].Firstname as CareRecipientFirstName" +
                               ", [CareRecipient].LastName as CareRecipientLastName" +

                               " FROM[dbo].[ChatLog] AS Chatlog" +

                               " INNER JOIN[User] As Volunteer ON Volunteer.UserID = VolunteerID" +
                               " INNER JOIN[User] As CareRecipient ON CareRecipient.UserID = CareRecipientID" +
                               " INNER JOIN[Reaction] As Reaction on Reaction.ReactionID = Chatlog.ReactionID" +
                               " INNER JOIN[Question] AS Question ON Question.QuestionID = Reaction.QuestionID" +
                               " WHERE Chatlog.[VolunteerID] = @UserId";

                     _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);
                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@UserId",
                    Value = userid
                });

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    int chatLogID = Convert.ToInt32(dr["ChatLogID"].ToString());
                    string questionTitle = (dr["Title"].ToString());
                    int careRecipientID = Convert.ToInt32(dr["CareRecipientID"].ToString());
                    int volunteerID = Convert.ToInt32(dr["VolunteerID"].ToString());
                    string careRecipientFirstName = dr["CareRecipientFirstName"].ToString();
                    string careRecipientLastName = dr["CareRecipientLastName"].ToString();

                    string volunteerFirstName = dr["VolunteerFirstName"].ToString();
                    string volunteerLastName = dr["VolunteerLastName"].ToString();

                    DateTime timeStamp = Convert.ToDateTime(dr["TimeStamp"].ToString());


                    ChatLog chatLog = new ChatLog(chatLogID, questionTitle, careRecipientID, volunteerID, careRecipientFirstName, careRecipientLastName, volunteerFirstName, volunteerLastName, timeStamp);
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

        public List<ChatLog> GetAllOpenChatsWithCareRecipientID(int userid)
        {
            List<ChatLog> chatLogList = new List<ChatLog>();
            try
            {
                string query = "SELECT Chatlog.[ChatLogID]" +
                               ", Chatlog.[ReactionID]" +
                               ", Chatlog.[CareRecipientID]" +
                               ", Chatlog.[VolunteerID]" +
                               ", Chatlog.[TimeStamp]" +
                               ", Question.[Title]" +


                               ", [Volunteer].Firstname as VolunteerFirstName," +
                               ", [Volunteer].LastName as VolunteerLastName" +

                               ", [CareRecipient].Firstname as CareRecipientFirstName" +
                               ", [CareRecipient].LastName as CareRecipientLastName" +

                               " FROM[dbo].[ChatLog] AS Chatlog" +

                               " INNER JOIN[User] As Volunteer ON Volunteer.UserID = VolunteerID" +
                               " INNER JOIN[User] As CareRecipient ON CareRecipient.UserID = CareRecipientID" +
                               " INNER JOIN[Reaction] As Reaction on Reaction.ReactionID = Chatlog.ReactionID" +
                               " INNER JOIN[Question] AS Question ON Question.QuestionID = Reaction.QuestionID" +
                               " WHERE Chatlog.[CareRecipientID] = " + userid + " ;";

                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);
                
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    int chatLogID = Convert.ToInt32(dr["ChatLogID"].ToString());
                    string questionTitle = (dr["Title"].ToString());
                    int careRecipientID = Convert.ToInt32(dr["CareRecipientID"].ToString());
                    int volunteerID = Convert.ToInt32(dr["VolunteerID"].ToString());
                    string careRecipientFirstName = dr["CareRecipientFirstName"].ToString();
                    string careRecipientLastName = dr["CareRecipientLastName"].ToString();

                    string volunteerFirstName = dr["VolunteerFirstName"].ToString();
                    string volunteerLastName = dr["VolunteerLastName"].ToString();

                    DateTime timeStamp = Convert.ToDateTime(dr["TimeStamp"].ToString());


                    ChatLog chatLog = new ChatLog(chatLogID, questionTitle, careRecipientID, volunteerID, careRecipientFirstName, careRecipientLastName, volunteerFirstName, volunteerLastName, timeStamp);
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

        public List<ChatMessage> LoadMessageAsListUsingChatLogID(int chatID)
        {
            List<ChatMessage> chatMessageList = new List<ChatMessage>();
            try
            {
                string query = "SELECT" +
                               " M.ChatID" +
                               ", M.SenderID" +
                               ", M.ReceiverID" +
                               ", M.Content" +
                               ", M.TimeStamp" +
                               " FROM [Message] M " +
                               "INNER JOIN ChatLog C ON C.ChatLogID = M.ChatID " +
                               "WHERE M.ChatID = " + chatID + "" +
                               "ORDER BY M.TimeStamp asc";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    int chatlogID = Convert.ToInt32(dr["ChatID"].ToString());
                    string content = (dr["Content"].ToString());
                    
                    int senderID = Convert.ToInt32(dr["SenderID"].ToString());
                    int receiverID = Convert.ToInt32(dr["ReceiverID"].ToString());

                    DateTime timeStamp = Convert.ToDateTime(dr["TimeStamp"].ToString());

                    ChatMessage chatMessage = new ChatMessage(chatlogID, receiverID, senderID, content, timeStamp );
                    chatMessageList.Add(chatMessage);
                }

                return chatMessageList;

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
