using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class TechnicianBLL
    {
        public DataTable GetTechnicianNames()
        {
            TechnicianDAL techDAL = new TechnicianDAL();
            DataTable dtAllTechnicianNames = new DataTable();
            dtAllTechnicianNames = techDAL.RetreiveTechnicianNames();

            return dtAllTechnicianNames;

            //InvoicesDAL invDal = new InvoicesDAL();//this would work as well
            //return invDal.RetreiveAllInvoiceDates();
        }



        public Technician GetTechnicianDetails(int techID)
        {
            /*this does not need a loop because the code is run every time the user changes the selection
            in the text box.
            
             this method is passed a DataTable which should only contain the phone number and email
             of a single technician.

             The method must return a Technician object*/




            //instantiate the class
            TechnicianDAL techDAL = new TechnicianDAL();

            //instantiate the entity class that the data table values will be passed to
            Technician aTechnician = new Technician();

            //instantiate the DataTable that will recieve the DataTable from RetrieveTechnicianDetails
            DataTable dtATechnician = new DataTable();



            dtATechnician = techDAL.RetrieveTechnicianDetails(techID);

            aTechnician.TechEmail = dtATechnician.Rows[0]["Email"].ToString();
            aTechnician.TechPhone = dtATechnician.Rows[0]["Phone"].ToString();
        
            //foreach (DataRow dr in dtATechnician.Rows)//can i write this not as a loop???
            //{
            //    aTechnician.TechEmail = dr["Email"].ToString();
            //    aTechnician.TechPhone = dr["Phone"].ToString();
            //}



            return aTechnician;
        }


        public TechnicianBLL()
        { }
    }
}
