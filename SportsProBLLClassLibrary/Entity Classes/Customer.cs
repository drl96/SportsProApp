using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Customer//added for 3B
    {
        //______________ (blank private field???)
        private int customerID;
        private string name;




        //constructor of the blank field would go here???


        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Customer()
        { }
    }
}
