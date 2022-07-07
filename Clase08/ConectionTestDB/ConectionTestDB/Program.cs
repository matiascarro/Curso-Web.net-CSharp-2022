using System.Data.SqlClient;
using System;

namespace ConectionTestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string sql = "select od.OrderId as orderId, p.ProductId, p.ProductName as ProductName, od.[UnitPrice], od.[Quantity], od.[Discount], o.[OrderDate]" +
                " from Products p " + " Inner Join OrderDetails od " + " on od.ProductId = p.ProductId " + "Inner Join[Orders] o on o.OrderId = od.OrderId  order by p.ProductId";
            string connectionString = "Data Source=DESKTOP-8104O1D\\SQLEXPRESS;Initial Catalog=Northwind;"
                                        + "Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                try
                {
                    
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["orderId"] + "\t" + reader["ProductName"]);
                    }
                    reader.Close();
                    Console.ReadKey();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
