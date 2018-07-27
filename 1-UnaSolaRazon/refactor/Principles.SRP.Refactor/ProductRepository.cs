using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.SRP.Refactor
{
    class ProductRepository
    {

        private SqliteConnection masterConnection;

        public ProductRepository() {
            InitDatabase();
        }

        public void Save(Product newProduct) {
            var insertCommand = masterConnection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO Product ( ProductId, Name, Price ) " +
                                        "VALUES ( $id, $name, $price )";
            insertCommand.Parameters.AddWithValue("$id", newProduct.ProductId);
            insertCommand.Parameters.AddWithValue("$name", newProduct.Name);
            insertCommand.Parameters.AddWithValue("$price", newProduct.Price);
            insertCommand.ExecuteNonQuery();
        }

        public List<Product> List() {

            var products = new List<Product>();

            var selectCommand = masterConnection.CreateCommand();
            selectCommand.CommandText = "SELECT ProductId, Name, Price FROM Product";
            using (var reader = selectCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var product = new Product
                    {
                        ProductId = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDouble(2)
                    };
                    products.Add(product);
                }
            }

            return products;
        }

        private void InitDatabase()
        {

            const string connectionString = "DataSource=Example;Mode=Memory;Cache=Shared";
            masterConnection = new SqliteConnection(connectionString);
            masterConnection.Open();

            var createCommand = masterConnection.CreateCommand();
            createCommand.CommandText =
            @"
                CREATE TABLE Product (
                    ProductId INTEGER,
                    Name TEXT,
                    Price REAL
                )
            ";
            createCommand.ExecuteNonQuery();
        }


    }
}
