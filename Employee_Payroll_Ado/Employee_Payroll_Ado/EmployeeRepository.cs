using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_Ado
{
    class EmployeeRepository
    {
        ///Specifying the connection string from the sql server connection.
        public static string connectionString = @"Data Source=DESKTOP-DL043RM;Initial Catalog=Employee_Payroll;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /// Establishing the connection using the Sql
        SqlConnection connection = new SqlConnection(connectionString);

        /// <summary>
        ///UC1 Creating a method for checking for the validity of the connection.
        /// </summary>
        public void EnsureDataBaseConnection()
        {
            this.connection.Open();
            using (connection)
            {
                Console.WriteLine("The Connection is created");
            }
            this.connection.Close();
        }

    }
}
