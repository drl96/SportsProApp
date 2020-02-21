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
    public partial class FrmOpenIncidentsByTechnician : Form
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

        public FrmOpenIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void btnMainMenuFromOpenIncidentsByTechnician_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmOpenIncidentsByTechnician_Load(object sender, EventArgs e)
        {
            TechnicianBLL techBLL = new TechnicianBLL();
            //DataTable dtAllTechnicianNames = techBLL.GetTechnicianNames();// not needed because a DataTable is not being used here
            cboTechnicians.DataSource = techBLL.GetTechnicianNames();

            cboTechnicians.DisplayMember = "NAME";
            cboTechnicians.ValueMember = "TECHID";
            //cboTechnicians.SelectedValue = 0;// this is what I originally put
            cboTechnicians.SelectedIndex = -1;// this is the corrected way prof showed me
        }

        private void cboTechnicians_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TechnicianBLL technicianBLL = new TechnicianBLL();//instantiate the class
            int selectedTechnician = (int)cboTechnicians.SelectedValue;

            Technician techDetails = technicianBLL.GetTechnicianDetails(selectedTechnician);

            lblOutputTechnicianEmail.Text = techDetails.TechEmail.ToString();
            lblOutputTechnicianPhone.Text = techDetails.TechPhone.ToString();

            

            IncidentBLL incidentBLL = new IncidentBLL();
            //List<Incident> lstOpenIncidentsByTechnician = new List<Incident>();

            List<Incident> lstOpenIncidentsByTechnician = incidentBLL.GetOpenIncidentsByTechnician(selectedTechnician);

            dgvOpenIncidentsByTechnician.DataSource = lstOpenIncidentsByTechnician;
        }
    }
}
