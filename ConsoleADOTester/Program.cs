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
            string connectionStr = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=(local)";

            // 1
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();

                // 2
                using (SqlCommand cmd = new SqlCommand("SELECT [ID],[Name],[Age] FROM [dbo].[Students] ORDER BY Name", connect))
                {
                    // 3
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["ID"] + " " + reader["Name"] + " " + reader["Age"]);
                        }
                    }
                }
            }

        }
    }
}
