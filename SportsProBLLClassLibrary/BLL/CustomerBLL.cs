using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class CustomerBLL//added for 3B
    {
        public List<Customer> RetrieveCustomerIDandName()
        {
            CustomerDAL custDAL = new CustomerDAL();

            List<Customer> lstCustomers = new List<Customer>();
            DataTable dtCustomerIDandName = new DataTable();

            dtCustomerIDandName = custDAL.GetCustomerIDandName();

            foreach (DataRow dr in dtCustomerIDandName.Rows)
            {
                Customer aCustomer = new Customer();
                aCustomer.CustomerID = (int)dr["CUSTOMERID"];
                aCustomer.Name = (string)dr["NAME"];

                lstCustomers.Add(aCustomer);
            }

            return lstCustomers;
        }





        public CustomerBLL()
        { }
    }
}
