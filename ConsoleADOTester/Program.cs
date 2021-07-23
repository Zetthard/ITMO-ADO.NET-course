using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ConsoleADOTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionStr = @"Server=DESKTOP-4A84H8M\SQLEXPRESS; Integrated Security=true; Initial Catalog=ApressFinancial;";

            // 1
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();

                // 2
                using (SqlCommand cmd = new SqlCommand("SELECT [CustomerId],[CustomerFirstName],[CustomerLastName] FROM [CustomerDetails].[Customers] ORDER BY CustomerId", connect))
                {
                    // 3
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["CustomerId"] + " " + reader["CustomerFirstName"] + " " + reader["CustomerLastName"]);
                        }
                    }
                }
            }

        }
    }
}
