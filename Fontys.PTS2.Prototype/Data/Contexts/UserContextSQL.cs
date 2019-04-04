using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public void EditUser(User currentUser, string password)
        {
            try
            {
                string query = "UPDATE [User] " +
                               "SET FirstName = @FirstName, LastName = @LastName, Birthdate = @Birthdate, Sex = @Sex, Email = @Email, Address = @Address, PostalCode = @PostalCode, City = @City " +
                               "WHERE UserID = @UserID";
                if (password != "")
                {
                    query = "UPDATE [User] " +
                            "SET FirstName = @FirstName, LastName = @LastName, Birthdate = @Birthdate, Sex = @Sex, Email = @Email, Address = @Address, PostalCode = @PostalCode, City = @City, Password = @Password" +
                            "WHERE UserID = @UserID";
                }
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = currentUser.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = currentUser.LastName;
                    cmd.Parameters.Add("@Birthdate", SqlDbType.DateTime).Value = currentUser.BirthDate;
                    cmd.Parameters.Add("@Sex", SqlDbType.Char).Value = currentUser.UserGender;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = currentUser.EmailAddress;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = currentUser.Address;
                    cmd.Parameters.Add("@PostalCode", SqlDbType.NChar).Value = currentUser.PostalCode;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = currentUser.City;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = currentUser.UserId;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;


                    //cmd.Parameters.AddWithValue("@FirstName", currentUser.FirstName);
                    //cmd.Parameters.AddWithValue("@LastName", currentUser.LastName);
                    //cmd.Parameters.AddWithValue("@Birthdate", currentUser.BirthDate);
                    //cmd.Parameters.AddWithValue("@Sex", currentUser.UserGender);
                    //cmd.Parameters.AddWithValue("@Email", currentUser.EmailAddress);
                    //cmd.Parameters.AddWithValue("@Address", currentUser.Address);
                    //cmd.Parameters.AddWithValue("@PostalCode", currentUser.PostalCode);
                    //cmd.Parameters.AddWithValue("@City", currentUser.City);
                    //cmd.Parameters.AddWithValue("@UserID", currentUser.UserId);
                    //cmd.Parameters.AddWithValue("@Password", password);
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
                MessageBox.Show("epic win");
                _conn.Close();
            }
        }

       
        public List<string> GetAllUsers()
        {
            try
            {
                string query = "SELECT [FirstName] FROM [User]";
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
                string query = "SELECT [UserID] FROM [User] WHERE [Email] = @email";
                _conn.Open();

                SqlParameter emailParam = new SqlParameter();
                emailParam.ParameterName = "@email";

                SqlCommand cmd = new SqlCommand(query, _conn);
                emailParam.Value = email;
                cmd.Parameters.Add(emailParam);

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
            try
            {
                string query =
                    "SELECT [Email], [Password] FROM [User] WHERE [Email] = @email AND [Password] = @password";
                _conn.Open();

                SqlParameter emailParam = new SqlParameter();
                emailParam.ParameterName = "@email";
                SqlParameter passParam = new SqlParameter();
                passParam.ParameterName = "@password";

                SqlCommand cmd = new SqlCommand(query, _conn);
                emailParam.Value = email;
                passParam.Value = password;
                cmd.Parameters.Add(emailParam);
                cmd.Parameters.Add(passParam);

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
            return false;
        }

        public bool CheckIfUserAlreadyExists(string email)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM [User] WHERE [Email] = @email";

                _conn.Open();

                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@email",
                    Value = email
                });

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    return false;
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
            return true;
        }

        public User getCurrentUserInfo(string email)
        {
            try
            {
                string query = "SELECT * FROM [User] WHERE [Email] = @email";
                _conn.Open();
                SqlParameter emailParam = new SqlParameter();
                emailParam.ParameterName = "@email";
                SqlCommand cmd = new SqlCommand(query, _conn);
                emailParam.Value = email;
                cmd.Parameters.Add(emailParam);
                User currentUser = new Admin("a", "b", "c,", "d", "e", "f", Convert.ToDateTime("1988/12/20"), User.Gender.M, true, User.AccountType.CareRecipient);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string accountType = reader.GetString(1);

                        if (accountType == "Admin")
                        {
                            User.Gender gender = (User.Gender)Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new Admin(reader.GetString(2), reader.GetString(3), reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.Admin);
                        }
                        else if (accountType == "Professional")
                        {
                            User.Gender gender = (User.Gender)Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new Professional(reader.GetString(2), reader.GetString(3),
                                reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.Professional);
                        }
                        else if (accountType == "Volunteer")
                        {
                            User.Gender gender = (User.Gender)Enum.Parse(typeof(User.Gender), reader.GetString(5));
                            bool status = true;
                            currentUser = new Volunteer(reader.GetString(2), reader.GetString(3), reader.GetString(7),
                                reader.GetString(9), reader.GetString(8), reader.GetString(6), reader.GetDateTime(4),
                                gender, status, User.AccountType.Volunteer);
                        }
                        else
                        {
                            User.Gender gender = (User.Gender)Enum.Parse(typeof(User.Gender), reader.GetString(5));
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

        public bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
