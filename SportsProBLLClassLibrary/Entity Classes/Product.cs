using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Product//added for 3B
    {
        //______________ (blank private field???)
        private string name;
        private string productCode;


        //constructor of the blank field would go here???


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }


        public Product()
        { }

    }
}
