using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//added these
using System.Data.SqlClient;


namespace SportsProDALClassLibrary
{
    /// <summary>
    /// Contains the data access classes having to do with the Incident entity
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// method that retrieves all incidents from TechSupportDB and stores them in a datatable
        /// </summary>
        /// <returns DataTable ></returns>
        public DataTable RetrieveAllIncidents()
        {
            SqlCommand cmdRetrieveAllIncidents = new SqlCommand();
            cmdRetrieveAllIncidents.CommandText = "SELECT INCIDENTID, CUSTOMERID, PRODUCTCODE, TECHID, DATEOPENED, DATECLOSED, TITLE, DESCRIPTION FROM DBO.INCIDENTS";
            cmdRetrieveAllIncidents.CommandType = CommandType.Text;

            //SqlConnection techSupportConnection = TechSupportDB.GetTechSupportConnection();//this is different form in class example
            SqlConnection techSupportConnection = new SqlConnection();//in class example did it this way
            techSupportConnection = TechSupportDB.GetTechSupportConnection();//in class example did it this way
            techSupportConnection.Open();//OPEN CONNECTION
            cmdRetrieveAllIncidents.Connection = techSupportConnection;

            DataTable dtAllIncidents = new DataTable();
            dtAllIncidents.Load(cmdRetrieveAllIncidents.ExecuteReader());
            techSupportConnection.Close();//CLOSE CONNECTION
            return dtAllIncidents;
        }




        /// <summary>
        /// method that retrieves all incidents by technician
        /// </summary>
        /// <param name="techID"></param>
        /// <returns DataTable ></returns>
        public DataTable RetrieveIncidentsByTechnician(int techID)
        {

            SqlParameter invParm = new SqlParameter();//as shown in in class example
            invParm.ParameterName = "@TechnicianID";
            invParm.Value = techID;
            invParm.Direction = ParameterDirection.Input;

            SqlCommand cmdRetrieveIncidentsByTechnician = new SqlCommand();

            cmdRetrieveIncidentsByTechnician.Parameters.Add(invParm);//as shown in in class example

            //cmdRetrieveIncidentsByTechnician.Parameters.AddWithValue("@TechnicianID", techID);//different way from in class example// he said "this will work too!"


            cmdRetrieveIncidentsByTechnician.CommandText = "SELECT INCIDENTID, CUSTOMERID, PRODUCTCODE, TECHID, DATEOPENED, DATECLOSED, TITLE, DESCRIPTION FROM DBO.INCIDENTS WHERE TECHID = @TechnicianID";
            cmdRetrieveIncidentsByTechnician.CommandType = CommandType.Text;

            //SqlConnection techSupportConnection = TechSupportDB.GetTechSupportConnection();//this is different form in class example
            SqlConnection techSupportConnection = new SqlConnection();//in class example did it this way
            techSupportConnection = TechSupportDB.GetTechSupportConnection();//in class example did it this way
            techSupportConnection.Open();//OPEN CONNECTION
            cmdRetrieveIncidentsByTechnician.Connection = techSupportConnection;
         
            DataTable dtIncidentsByTechnician = new DataTable();
            dtIncidentsByTechnician.Load(cmdRetrieveIncidentsByTechnician.ExecuteReader());
            techSupportConnection.Close();//CLOSE CONNECTION
            return dtIncidentsByTechnician;
        }




        public DataTable RetrieveOpenIncidentsByTechnician(int techID)
        {
            //command stuff
            SqlCommand cmdRetrieveOpenIncidentsByTechnician = new SqlCommand();
            cmdRetrieveOpenIncidentsByTechnician.Parameters.AddWithValue("@TechnicianID", techID);

            cmdRetrieveOpenIncidentsByTechnician.CommandText = "SELECT INCIDENTID, CUSTOMERID, PRODUCTCODE, TECHID, DATEOPENED, DATECLOSED, TITLE, DESCRIPTION from dbo.Incidents where DateClosed is null and TechID = @TechnicianID";
            cmdRetrieveOpenIncidentsByTechnician.CommandType = CommandType.Text;

            //connection stuff
            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();
            techSupportConnection.Open();//OPEN CONNECTION
            cmdRetrieveOpenIncidentsByTechnician.Connection = techSupportConnection;

            //convert to data table stuff
            DataTable dtOpenIncidentsByTechnician = new DataTable();
            dtOpenIncidentsByTechnician.Load(cmdRetrieveOpenIncidentsByTechnician.ExecuteReader());
            techSupportConnection.Close();//CLOSE CONNECTION
            return dtOpenIncidentsByTechnician;

            //select * from Incidents where DateClosed is null and TechID = 12 (sql code used for testing)
        }


        public IncidentDAL()//not specified in specs
        { }
    }
}

