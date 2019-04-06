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
    public class ReactionContextSQL : IReactionContext
    {
        private const string ConnectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static readonly SqlConnection _conn = new SqlConnection(ConnectionString);
        //er mogen hier geen static methodes voorkomen, deze moeten pas static worden in de logic layer.
        public void PostReaction(Reaction reaction)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {

                    CommandType = System.Data.CommandType.Text,
                    CommandText =
                        "INSERT INTO [Reaction] ([QuestionID], [SenderID], [Description])" +
                        $"VALUES ({reaction.ToString()})"
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

        public List<Reaction> GetAllCommentsWithQuestionID(int questionid)
        {
            List<Reaction> reactionList = new List<Reaction>();
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllCommentsByQuestionID", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@questionID", SqlDbType.Int).Value = questionid;

                _conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow dr in dt.Rows)
                {
                    string volunteerName = dr["VolunteerName"].ToString();
                    string description = dr["Description"].ToString();
                    int volunteerID = Convert.ToInt32(dr["SenderID"].ToString());

                    DateTime timeStamp = Convert.ToDateTime(dr["Timestamp"].ToString());

                    
                    reactionList.Add(new Reaction(questionid, volunteerID, description, volunteerName));
                }

                return reactionList;
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
