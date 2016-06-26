using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dataConnection = new SqlConnection();
            try
            {
                // Build SqlConnection Object
                // TODO Prompt for user name and password
                Console.WriteLine("Please enter user name:");
                string userName = Console.ReadLine();
                Console.WriteLine("Please enter password:");
                string password = Console.ReadLine();
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "langw7.cs.camosun.bc.ca";
                builder.InitialCatalog = "AdventureWorks";
                // TODO remove hard-coded user name and password
                builder.UserID = userName;
                builder.Password = password;
                dataConnection.ConnectionString = builder.ConnectionString;
                dataConnection.Open();

                // Get SalesPersonID from input
                Console.WriteLine("Please enter a sales person ID number:");
                string SalesPersonID = Console.ReadLine();

                // Set up the DB Query
                SqlCommand dataCommand = new SqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandType = CommandType.Text;
                dataCommand.CommandText = "SELECT FirstName, LastName, JobTitle, City, StateProvinceName, SalesQuota, SalesYTD " +
                " FROM Sales.vSalesPerson where SalesPersonID=@SalesIdParam";

                // Set up the query SalesPersonID
                SqlParameter param = new SqlParameter("@SalesIdParam", SqlDbType.Char, 5);
                param.Value = SalesPersonID;
                dataCommand.Parameters.Add(param);

                // Read data from query result
                Console.WriteLine("\nAbout to find data on sales person {0}\n", SalesPersonID);
                SqlDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string FirstName = dataReader.GetString(0);
                    string LastName = dataReader.GetString(1);
                    string JobTitle = dataReader.GetString(2);
                    string City = dataReader.GetString(3);
                    string StateProvinceName = dataReader.GetString(4);
                    string SalesQuota = dataReader.GetDecimal(5).ToString();
                    string SalesYTD = dataReader.GetDecimal(6).ToString();

                    Console.WriteLine("{1}, {0}:\n\t{2}\n\t{3}, {4}\n\tQuota: {5} | YTD: {6}",
                    FirstName, LastName, JobTitle, City, StateProvinceName, SalesQuota, SalesYTD);
                    string resp = Console.ReadLine();
                }
                dataReader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error accessing the database: {0}", e.Message);
                string exceptresp = Console.ReadLine();
            }
            finally
            {
                dataConnection.Close();
            }
        }
    }
}
