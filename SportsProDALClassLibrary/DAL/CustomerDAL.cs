using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//added these
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class CustomerDAL// added for 3B
    {
        public DataTable GetCustomerIDandName()
        {
            DataTable dtCustomerIDandName = new DataTable();

            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();

            SqlCommand cmdGetCustomerIDandName = new SqlCommand();
            cmdGetCustomerIDandName.CommandText = "SELECT CUSTOMERID, NAME FROM DBO.CUSTOMERS";
            cmdGetCustomerIDandName.CommandType = CommandType.Text;
            
            cmdGetCustomerIDandName.Connection = techSupportConnection;

            techSupportConnection.Open();
            dtCustomerIDandName.Load(cmdGetCustomerIDandName.ExecuteReader());
            techSupportConnection.Close();

            return dtCustomerIDandName;
        }


        public CustomerDAL()//parameterless constructor
        { }
    }
}
