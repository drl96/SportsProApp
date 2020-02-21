using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Registration//added for 3B
    {
        private int customerID;
        private string productCode;
        private DateTime registrationDate;


        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }


        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }


        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }


        public Registration()
        { }
    }
}
