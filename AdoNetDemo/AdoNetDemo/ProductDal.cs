using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    public class ProductDal
    {
        private SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = Convert.ToString(sqlDataReader["Name"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"])
                };
                products.Add(product);
            }
            sqlDataReader.Close();
            _conn.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _conn);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Update Products set Name=@name,UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _conn);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Delete from Products where Id=@id", _conn);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
