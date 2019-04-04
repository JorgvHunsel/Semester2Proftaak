using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    class UserContextSQL : IUserContext
    {
        //er mogen hier geen static methodes zijn. deze worden pas gemaakt in de logic layer.
        private const string ConnectionString =
            @"Data Source=mssql.fhict.local;Initial Catalog=dbi423244;User ID=dbi423244;Password=wsx234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public void AddNewUser(string firstName, string lastName, DateTime birthDate, string gender, string email, string address, string postalCode, string city, string password, string accountType)
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

        public List<string> GetAllUsers()
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

        public int GetUserId(string email)
        {
            try
            {
                string query = "SELECT [UserID] FROM [User] WHERE [Email] = '" + email + "'";
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

        public bool CheckValidityUser(string email, string password)
        {
            string query = "SELECT [Email], [Password] FROM [User] WHERE [Email] = '" + email + "' AND [Password] = '" + password + "'";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (password == (string)reader[1])
                    {
                        MessageBox.Show("User found");
                        _conn.Close();
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Gebruiker bestaat niet of wachtwoord is verkeerd!");
                return false;
            }

            reader.Close();


            _conn.Close();
            return false;
        }
        public User getCurrentUserInfo(int userId)
        {
            try
            {
                string query = "SELECT * FROM [User] WHERE [UserID] = @UserId";
                _conn.Open();
                SqlParameter useridParameter = new SqlParameter();
                useridParameter.ParameterName = "@UserId";
                SqlCommand cmd = new SqlCommand(query, _conn);
                useridParameter.Value = userId;
                cmd.Parameters.Add(useridParameter);
                User currentUser = new Admin("a","b","c,","d","e","f", Convert.ToDateTime("1988/12/20"), User.Gender.M,true, User.AccountType.CareRecipient);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string accountType = reader.GetString(1);

                        if (accountType == "Admin")
                        {
                            User.Gender gender = (User.Gender) Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new Admin(reader.GetString(2), reader.GetString(3), reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.Admin);
                        }
                        else if (accountType == "Professional")
                        {
                            User.Gender gender = (User.Gender) Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new Professional(reader.GetString(2), reader.GetString(3),
                                reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.Professional);
                        }
                        else if (accountType == "Volunteer")
                        {
                            User.Gender gender = (User.Gender) Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new Volunteer(reader.GetString(2), reader.GetString(3), reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.Volunteer);
                        }
                        else
                        {
                            User.Gender gender = (User.Gender) Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new CareRecipient(reader.GetString(2), reader.GetString(3),
                                reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.CareRecipient);
                        }
                        return currentUser;
                    }
                    return currentUser;
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
    }
}
