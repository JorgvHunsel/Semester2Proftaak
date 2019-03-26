using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;

namespace Fontys.PTS2.Prototype.Data
{
    class ReactionContextSQL
    {
        private const string ConnectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public static void PostReaction(Reaction reaction)
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
    }
}
