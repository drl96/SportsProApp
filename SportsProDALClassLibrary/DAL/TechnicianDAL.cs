using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//added these
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class TechnicianDAL
    {
        public DataTable RetreiveTechnicianNames()
        {
            SqlCommand cmdAllTechnicianNames = new SqlCommand();

            cmdAllTechnicianNames.CommandText = "SELECT TECHID, NAME FROM DBO.TECHNICIANS";
            cmdAllTechnicianNames.CommandType = CommandType.Text;


            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();
            techSupportConnection.Open();//OPEN CONNECTION
            cmdAllTechnicianNames.Connection = techSupportConnection;

            DataTable dtAllTechnicianNames = new DataTable();
            dtAllTechnicianNames.Load(cmdAllTechnicianNames.ExecuteReader());
            techSupportConnection.Close();//CLOSE CONNECTION

            return dtAllTechnicianNames;          
        }



        public DataTable RetrieveTechnicianDetails(int techID)
        {
            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();
            techSupportConnection.Open();//OPEN CONNECTION

            SqlCommand cmdRetrieveTechnicianDetails = new SqlCommand();
            cmdRetrieveTechnicianDetails.CommandText = "SELECT EMAIL, PHONE FROM DBO.TECHNICIANS WHERE TECHID = @techID";
            cmdRetrieveTechnicianDetails.CommandType = CommandType.Text;
            cmdRetrieveTechnicianDetails.Parameters.AddWithValue("@techID", techID);
           
            cmdRetrieveTechnicianDetails.Connection = techSupportConnection;

            DataTable dtTechnicianDetails = new DataTable();
            dtTechnicianDetails.Load(cmdRetrieveTechnicianDetails.ExecuteReader());
            techSupportConnection.Close();//CLOSE CONNECTION

            return dtTechnicianDetails;
        }


        public TechnicianDAL()//not specified in specs
        { }
    }
}
