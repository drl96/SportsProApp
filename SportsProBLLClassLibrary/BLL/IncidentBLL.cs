using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    /// <summary>
    /// Contains business logic classes having to with the Incident entity
    /// </summary>
    public class IncidentBLL
    {
        public List<Incident> GetAllIncidents()
        {
            List<Incident> lstIncidents = new List<Incident>();
            DataTable dtAllIncidents = new DataTable();

            IncidentDAL incDal = new IncidentDAL();

            dtAllIncidents = incDal.RetrieveAllIncidents();


            foreach (DataRow dr in dtAllIncidents.Rows)
            {
                Incident anIncident = new Incident();
                anIncident.IncidentID = (int)dr["IncidentID"];
                anIncident.CustomerID = (int)dr["CustomerID"];
                anIncident.ProductCode = (string)dr["ProductCode"];
                anIncident.TechID = dr["TechID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["TechID"]);
                anIncident.DateOpened = (DateTime)dr["DateOpened"];
                anIncident.DateClosed = dr["DateClosed"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateClosed"]);
                anIncident.Title = dr["Title"].ToString();
                anIncident.Description = dr["Description"].ToString();

                lstIncidents.Add(anIncident);
            }
            return lstIncidents;
        }




        public List<Incident> GetIncidentsByTechnician(int techID)
        {
            List<Incident> lstIncidentsByTechnician = new List<Incident>();
            DataTable dtIncidentsByTechnician = new DataTable();

            IncidentDAL incDal = new IncidentDAL();

            dtIncidentsByTechnician = incDal.RetrieveIncidentsByTechnician(techID);


            foreach (DataRow dr in dtIncidentsByTechnician.Rows)
            {
                Incident anIncident = new Incident();
                anIncident.IncidentID = (int)dr["IncidentID"];
                anIncident.CustomerID = (int)dr["CustomerID"];
                anIncident.ProductCode = (string)dr["ProductCode"];
                anIncident.TechID = dr["TechID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["TechID"]);
                anIncident.DateOpened = (DateTime)dr["DateOpened"];
                anIncident.DateClosed = dr["DateClosed"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateClosed"]);
                anIncident.Title = dr["Title"].ToString();
                anIncident.Description = dr["Description"].ToString();

                lstIncidentsByTechnician.Add(anIncident);
            }
            return lstIncidentsByTechnician;
        }




        public List<Incident> GetOpenIncidentsByTechnician(int techID)
        {
            List<Incident> lstOpenIncidentsByTechnician = new List<Incident>();
            DataTable dtOpenIncidentsByTechnician = new DataTable();
            IncidentDAL incDal = new IncidentDAL();

            dtOpenIncidentsByTechnician = incDal.RetrieveOpenIncidentsByTechnician(techID);

            //DataRow dr; (cant declare this up here for some reason

            foreach (DataRow dr in dtOpenIncidentsByTechnician.Rows)//this statement needs the "DataRow" before dr
            {
                Incident anIncident = new Incident();
                anIncident.IncidentID = (int)dr["IncidentID"];
                anIncident.CustomerID = (int)dr["CustomerID"];
                anIncident.ProductCode = (string)dr["ProductCode"];
                anIncident.TechID = dr["TechID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["TechID"]);
                anIncident.DateOpened = (DateTime)dr["DateOpened"];
                anIncident.DateClosed = dr["DateClosed"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DateClosed"]);
                anIncident.Title = dr["Title"].ToString();
                anIncident.Description = dr["Description"].ToString();
                lstOpenIncidentsByTechnician.Add(anIncident);
            }
            return lstOpenIncidentsByTechnician;


        }



        public IncidentBLL()//not specified in specs
        { }
    }
}
