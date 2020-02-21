using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//added these
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class ProductDAL//added for 3B
    {
        public DataTable GetProductNameAndCode()         
        {          
            DataTable dtProductNameAndCode = new DataTable();

            //1) make connection 2) make command 3) assign connection to command 4) open, load dt, close
            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();

            SqlCommand cmdProductNameAndCode = new SqlCommand();
            cmdProductNameAndCode.CommandText = "SELECT PRODUCTCODE, NAME FROM DBO.PRODUCTS";
            cmdProductNameAndCode.CommandType = CommandType.Text;

            cmdProductNameAndCode.Connection = techSupportConnection;

            techSupportConnection.Open();
            dtProductNameAndCode.Load(cmdProductNameAndCode.ExecuteReader());
            techSupportConnection.Close();

            return dtProductNameAndCode;
        }


        public ProductDAL()
        { }
    }
}
