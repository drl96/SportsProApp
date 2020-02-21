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
    public partial class FrmViewIncidentsByTechnician : Form
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

        public FrmViewIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void btnMainMenuFromIncidentsByTechnician_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGetIncidentsByTechnician_Click(object sender, EventArgs e)
        {
            IncidentBLL incidentBLL = new IncidentBLL();
            int technicianID;
            technicianID = int.Parse(txtTechnicianID.Text);
            dgvIncidentsByTechnician.DataSource = incidentBLL.GetIncidentsByTechnician(technicianID);
            //dgvIncidentsByTechnician.Columns["TechID"].Visible = false;
        }
    }
}
