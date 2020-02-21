using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;//added these
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class TechSupportDB
    {
        public static SqlConnection GetTechSupportConnection()
        {
            SqlConnection techSupportConnnection = new SqlConnection();
            string connectionString = "Data Source = CISSQL.MATRIX.TXSTATE.EDU\\CIS3325FALL18; Initial Catalog = TechSupport; Integrated Security = true";
            techSupportConnnection.ConnectionString = connectionString;
            return techSupportConnnection;
        }
    }
}
