using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//added these
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class RegistrationDAL//added for 3B
    {
        private bool AddRegistration(int customerID, string productCode, DateTime regDate)
        {
            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();
            techSupportConnection.Open();

            SqlCommand cmdAddRegistration = new SqlCommand("spAddRegistration", techSupportConnection);
            cmdAddRegistration.Parameters.AddWithValue("@CustomerID", customerID);
            cmdAddRegistration.Parameters.AddWithValue("@ProductCode", productCode);
            cmdAddRegistration.Parameters.AddWithValue("@RegistrationDate", regDate);
            cmdAddRegistration.CommandType = CommandType.StoredProcedure;

            cmdAddRegistration.Connection = techSupportConnection;

            int rowsAffected = (int)cmdAddRegistration.ExecuteNonQuery();
            techSupportConnection.Close();

            if (rowsAffected == 1)//record insertion successful!
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool CheckRegistration(int customerID, string productCode)
        {
            SqlConnection techSupportConnection = new SqlConnection();
            techSupportConnection = TechSupportDB.GetTechSupportConnection();
            techSupportConnection.Open();

            SqlCommand cmdCheckRegistration = new SqlCommand();
            cmdCheckRegistration.Parameters.AddWithValue("@CustomerID", customerID);
            cmdCheckRegistration.Parameters.AddWithValue("@ProductCode", productCode);
            cmdCheckRegistration.CommandText = "SELECT COUNT (*) FROM DBO.REGISTRATIONS WHERE PRODUCTCODE = @ProductCode and CUSTOMERID = @CustomerID";
            cmdCheckRegistration.CommandType = CommandType.Text;//needed system.data for this????

            cmdCheckRegistration.Connection = techSupportConnection;

            int countValue = (int)cmdCheckRegistration.ExecuteScalar();
            techSupportConnection.Close();

            if (countValue == 1)//record already exists!
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        //ACTUAL PROCESS
        public bool RegisterProduct(string prodCode, int custID, DateTime regDate)
        {
            bool checkRegistration = CheckRegistration(custID, prodCode);    
            
            if (checkRegistration == true)//record already exists!
            {
                return false;
            }
            else
            {
                bool addRegistration = AddRegistration(custID, prodCode, regDate);

                if (addRegistration == true)//record insertion successful!
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        public RegistrationDAL()
        { }
    }
}