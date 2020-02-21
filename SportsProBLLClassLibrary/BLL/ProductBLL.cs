using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class ProductBLL//added for 3B
    {
        public List<Product> RetrieveProductNameAndCode()
        {
            List<Product> lstProducts = new List<Product>();
            DataTable dtProductNameAndCode = new DataTable();//need data dable to recieve the data

            ProductDAL prodDAL = new ProductDAL();

            dtProductNameAndCode = prodDAL.GetProductNameAndCode();

            foreach (DataRow dr in dtProductNameAndCode.Rows)
            {
                Product aProduct = new Product();
                aProduct.ProductCode = (string)dr["PRODUCTCODE"];
                aProduct.Name = (string)dr["NAME"];
                lstProducts.Add(aProduct);
            }
            return lstProducts;
        }


        public ProductBLL()
        { }
    }
}
