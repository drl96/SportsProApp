using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    /// <summary>
    /// Incident entity class. Contains the private variables, property methods and the parameterless constructor
    /// </summary>
    public class Incident
    {
        private int incidentID;//the private variables do not effect the order the information is displayed
        private int customerID;
        private string productCode;
        private int? techID;//nullable
        private DateTime dateOpened;
        private DateTime? dateClosed;//nullable
        private string title;
        private string description;


        public int IncidentID//the order of the property methods is the only thing that effects the order in the rest of the program
        {
            get { return incidentID; }
            set { incidentID = value; }
        }

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

        public int? TechID
        {
            get
            {
                if (techID.HasValue)
                    return techID;
                else
                    return null;
            }
            set { techID = value; }
        }

        public DateTime DateOpened
        {
            get { return dateOpened; }
            set { dateOpened = value; }
        }

        public DateTime? DateClosed
        {
            get
            {
                if (dateClosed.HasValue)
                    return dateClosed;
                else
                    return null;
            }
            set { dateClosed = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public Incident()
        { }
    }
}

