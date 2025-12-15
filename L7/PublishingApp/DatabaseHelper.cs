using PublishingApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PublishingApp
{
    public class DatabaseHelper : IDisposable
    {
        private string connectionString = @"Data Source=DESKTOP-33V95C9\SQLEXPRESS;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30";

        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.Id_Publication, p.Name, p.Id_Author, 
                           p.PreorderPrice,
                           a.Surname + ' ' + a.Name as AuthorName,
                           p.ReleaseYear, p.VolumeOfSheets, p.Circulation
                    FROM Publications p
                    LEFT JOIN Authors a ON p.Id_Author = a.Id_Author
                    ORDER BY p.Name";

                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id = (int)reader["Id_Publication"],
                            Title = reader["Name"].ToString(),
                            AuthorId = reader["Id_Author"] != DBNull.Value ? (int)reader["Id_Author"] : 0,
                            AuthorName = reader["AuthorName"].ToString(),
                            ReleaseYear = (int)reader["ReleaseYear"],
                            Pages = (int)reader["VolumeOfSheets"],
                            Circulation = (int)reader["Circulation"],
                            Price = (int)reader["PreorderPrice"]
                        });
                    }
                }
            }

            return books;
        }

        public List<Office> GetOffices()
        {
            var offices = new List<Office>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id_Office, Office, Address, Phone FROM Offices ORDER BY Office";

                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        offices.Add(new Office
                        {
                            Id = (int)reader["Id_Office"],
                            Name = reader["Office"].ToString(),
                            Address = reader["Address"].ToString(),
                            Phone = reader["Phone"].ToString()
                        });
                    }
                }
            }

            return offices;
        }

        public int CreateOrder(Order order)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO Orders (Id_Type, Id_Publication, Id_Office, Id_Customer, 
                                        DateOfAdmission, DateOfCompletion, Price)
                    VALUES (7, @Publication, @Office, @Customer, 
                            @DateOfAdmission, @DateOfCompletion, @Price);
                    SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Publication", order.BookId);
                    command.Parameters.AddWithValue("@Office", order.OfficeId);
                    command.Parameters.AddWithValue("@Customer", order.CustomerId);
                    command.Parameters.AddWithValue("@DateOfAdmission", order.OrderDate);

                    if (order.CompletionDate.HasValue)
                        command.Parameters.AddWithValue("@DateOfCompletion", order.CompletionDate.Value);
                    else
                        command.Parameters.AddWithValue("@DateOfCompletion", DBNull.Value);

                    command.Parameters.AddWithValue("@Price", order.Price);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public int CreateCustomer(Customer customer)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO Customers (Name, Id_Type, Address, Phone)
                    VALUES (@Name, 1, @Address, @Phone);
                    SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Address",
                        string.IsNullOrEmpty(customer.Address) ? (object)DBNull.Value : customer.Address);
                    command.Parameters.AddWithValue("@Phone",
                        string.IsNullOrEmpty(customer.Phone) ? (object)DBNull.Value : customer.Phone);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public Order GetOrderDetails(int orderId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT o.Id_Order, o.DateOfAdmission, 
                           o.Price, p.Name as BookTitle, c.Name as CustomerName,
                           ofc.Office as OfficeName
                    FROM Orders o
                    LEFT JOIN Publications p ON o.Id_Publication = p.Id_Publication
                    LEFT JOIN Customers c ON o.Id_Customer = c.Id_Customer
                    LEFT JOIN Offices ofc ON o.Id_Office = ofc.Id_Office
                    WHERE o.Id_Order = @OrderId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Order
                            {
                                Id = (int)reader["Id_Order"],
                                BookTitle = reader["BookTitle"].ToString(),
                                CustomerName = reader["CustomerName"].ToString(),
                                OfficeName = reader["OfficeName"].ToString(),
                                OrderDate = (DateTime)reader["DateOfAdmission"],
                                Price = (decimal)reader["Price"]
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection test failed: {ex.Message}");
                return false;
            }
        }

        public void Dispose()
        {
        }
    }

}
