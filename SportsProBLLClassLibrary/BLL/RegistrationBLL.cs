using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class RegistrationBLL//added for 3B
    {
        public bool AddNewRegistration(Registration aRegistration)
        {
            RegistrationDAL regDAL = new RegistrationDAL();

            //cast registration object into individual properties??
            int cID = aRegistration.CustomerID;
            string pCode = aRegistration.ProductCode;
            DateTime rDate = aRegistration.RegistrationDate;


            bool registerProduct = regDAL.RegisterProduct(pCode, cID, rDate);

            if (registerProduct == true)
            {
                return true;
            }
            else// if RegisterProduct() returns false, a record already exists!
            {
                return false;
            }
        }




        public RegistrationBLL()
        { }
    }
}
