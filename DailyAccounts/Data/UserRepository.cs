using DailyAccounts.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts.Data
{
    public class UserRepository
    {
        private string _connectionString;

        public UserRepository(string connectionstring)
        {
            this._connectionString = connectionstring;
        }
        public User Authenticate(string username, string password)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select id,user_name,user_password from tbluser where user_name='{username}' and user_password = '{password}'";
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    user = new User();
                    user.id = Convert.ToInt16(reader["id"]);
                    user.userName = reader["user_name"].ToString();
                    user.userPassword = reader["user_password"].ToString();
                }
            }
            return user;
        }
    }
}
