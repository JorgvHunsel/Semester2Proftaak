using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;

namespace Fontys.PTS2.Prototype.Data
{
    class UserContextSQL
    {
        private const string ConnectionString =
            @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public static void AddNewUser(string firstName, string lastName, DateTime birthDate, string gender, string email, string address, string postalCode, string city, string password, string accountType)
        {
            try
            {
                string query = "INSERT INTO [User] (FirstName, LastName, Birthdate, Sex, Email, Address, PostalCode, City, Password, AccountType) VALUES (@FirstName, @LastName, @Birthdate, @Sex, @Email, @Address, @PostalCode, @City, @Password, @AccountType)";
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Birthdate", birthDate);
                    cmd.Parameters.AddWithValue("@Sex", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@AccountType", accountType);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                _conn.Close();
            }
        }

        public static List<string> GetAllUsers()
        {
            try
            {
                string query = "SELECT [FirstName] FROM [User] ";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                List<string> userNames = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    string userName = row["FirstName"].ToString();
                    userNames.Add(userName);
                }

                return userNames;
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

        // To do:
        public static List<string> GetUserById(int userID)
        {
            try
            {
                string query = "SELECT * FROM [User] WHERE UserID = '" + userID + "' ";
                _conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, _conn);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                List<string> user = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    //string categoryID = row["CategoryID"].ToString();
                    //string categoryName = row["Name"].ToString();
                    //string categoryDescription = row["Description"].ToString();

                    
                    user.Add(Convert.ToString(row));
                }

                return user;
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

        public static int GetUserId(string firstName)
        {
            try
            {
                string query = "SELECT [UserID] FROM [User] WHERE [FirstName] = '" + firstName + "'";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);

                int UserId = (int)cmd.ExecuteScalar();

                return UserId;
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
