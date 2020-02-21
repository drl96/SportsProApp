using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmAddRegistration : Form
    {

        private const int CP_NOCLOSE_BUTTON = 0x200;//removes x button
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public FrmAddRegistration()
        {
            InitializeComponent();
        }

        private void btnMainMenuFromAddRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAddRegistration_Load(object sender, EventArgs e)
        {
            //populate customer ComboBox
            CustomerBLL custBLL = new CustomerBLL();
            cboCustomerName.DataSource = custBLL.RetrieveCustomerIDandName();

            cboCustomerName.DisplayMember = "NAME";
            cboCustomerName.ValueMember = "CUSTOMERID";
            cboCustomerName.SelectedIndex = -1;


            //populate product ComboBox
            ProductBLL prodBLL = new ProductBLL();
            cboProductName.DataSource = prodBLL.RetrieveProductNameAndCode();

            cboProductName.DisplayMember = "NAME";
            cboProductName.ValueMember = "PRODUCTCODE";
            cboProductName.SelectedIndex = -1;

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //add customer id and product id attributes to the registration object and pass that to the BLL

            RegistrationBLL regBLL = new RegistrationBLL();
            Registration registration = new Registration();
            int selectedCustomer = (int)cboCustomerName.SelectedValue;
            string selectedProduct = (string)cboProductName.SelectedValue;

            registration.CustomerID = selectedCustomer;
            registration.ProductCode = selectedProduct;
            registration.RegistrationDate = (DateTime)DateTime.Today;

            bool addRegistration = regBLL.AddNewRegistration(registration);//returns true or false depending on weather the registration was successful or not

            if (addRegistration == true)//record insertion successful!
            {
                //CHANGE THESE MESSAGE BOX CONSTRUCTORS
                MessageBox.Show("The Product was successfully registered", "Add Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The registration already exists", "Add Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
