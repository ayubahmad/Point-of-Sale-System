using DailyAccounts.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyAccounts.CommonFiles;

namespace DailyAccounts.Data
{
    class ProductRepository
    {
        private string _connectionString;
        public ProductRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void AddProduct(int categoryId, string productName, int availableStock, int salePrice)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"insert tblproduct (category_id,product_name,available_stock,sale_price) values ('{categoryId}','{productName}','{availableStock}','{salePrice}')";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
        public DataTable GetProductsByCategoryId(int categoryId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT id, product_name, available_stock, sale_price FROM tblproduct where category_id = '{categoryId}'";
                command.Connection = connection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dt);
                
            }
            return dt;
        }

        public Product GetProduct(int id)
        {
            DataTable dt = new DataTable();
            Product product = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT id, category_id, product_name, available_stock,sale_price FROM tblproduct where id = '{id}'";
                command.Connection = connection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    product = new Product();
                    product.id = id;
                    product.categoryId = Convert.ToInt32(dt.Rows[0]["category_id"]);
                    product.productName = dt.Rows[0]["product_name"].ToString();
                    product.availableStock =Convert.ToInt32(dt.Rows[0]["available_stock"]);
                    product.saleprice = Convert.ToInt32(dt.Rows[0]["sale_price"]);
                }
            }
            return product;

        }
        public bool deleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"delete from tblproduct where id = '{productId}'";
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

        //public void EditProduct(int categoryId, string updatedName)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand();
        //        command.CommandText = $"update tblproduct set category_name = '{updatedName}' where id = '{categoryId}'";
        //        command.Connection = connection;
        //        command.ExecuteNonQuery();

        //    }
        //}

        public void purchase(int productId, DateTime dateTime, int quantity,int newStock, int paidAmount)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.CommandText= $"insert tblpurchase (product_id,date_time,quantity,paid_amount) values ('{productId}','{dateTime}','{quantity}','{paidAmount}')";
                Command.Connection = connection;
                Command.ExecuteNonQuery();
                Command.CommandText= $"UPDATE tblproduct SET available_stock='{newStock}' WHERE id = '{productId}'";
                Command.ExecuteNonQuery();
            }
        }

        public void sale(List<Item> items,int discount,int totalBill,string remarks, DateTime dateTime)
        {
            List<Item> itemList = items;
            int numberOfItems = items.Count();
            DateTime date = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.CommandText = $"insert tblorder (date_time,items,bill_amount,discount,remarks) values (current_timestamp,'{numberOfItems}','{totalBill}','{discount}','{remarks}')";
                Command.Connection = connection;
                Command.ExecuteNonQuery();
                Command.CommandText = $"SELECT* FROM tblorder WHERE id = (SELECT MAX(id) FROM tblorder)";
                SqlDataReader reader = Command.ExecuteReader();
                reader.Read();
                int orderId= Convert.ToInt16(reader["id"]);
                reader.Close();
                
                foreach (Item item in itemList)
                {
                    Command.CommandText = $"insert tblorder_detail (order_id,product_id,quantity,price) values ('{orderId}','{item.productId}','{item.quantity}','{item.amount}')";
                    Command.ExecuteNonQuery();

                    Command.CommandText = $"select available_stock from tblproduct WHERE id = '{item.productId}' ";
                    reader = Command.ExecuteReader();
                    reader.Read();
                    int oldStock = Convert.ToInt16(reader["available_stock"]);
                    reader.Close();
                    Command.CommandText = $"UPDATE tblproduct SET available_stock='{oldStock-item.quantity}' WHERE id = '{item.productId}' ";
                    Command.ExecuteNonQuery();
                }
                //Command.CommandText = $"UPDATE tblproduct SET available_stock='{newStock}' WHERE id = '{productId}'";
                //Command.ExecuteNonQuery();
            }
        }

        public DataTable getAllOrders()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT * FROM tblorder";
                command.Connection = connection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);

            }
            return dataTable;
        }
    }
}
