using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DailyAccounts.Data
{
    public class CategoryRepository
    {
        private string _connectionString;
        public CategoryRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void addCategory(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText= $"insert tblcategory (category_name) values ('{categoryName}')";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
        public int getId(string categoryName)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select id from tblcategory where category_name = '{categoryName}'";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                id = Convert.ToInt16(reader["id"]);
            }
            return id;
        }

        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT id, category_name FROM tblcategory";
                command.Connection = connection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dt);

            }
            return dt;
        }

        public bool deleteCategory(int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"delete from tblcategory where id = '{categoryId}'";
                command.Connection = connection;
                int numberOfRows = command.ExecuteNonQuery();
                if (numberOfRows > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public void EditCategory(int categoryId, string updatedName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"update tblcategory set category_name = '{updatedName}' where id = '{categoryId}'";
                command.Connection = connection;
                command.ExecuteNonQuery();
                //int numberOfRows = command.ExecuteNonQuery();
                //if (numberOfRows > 0)
                //{
                //    return true;
                //}
                //else
                //   return false;
            }
        }


    }
}
