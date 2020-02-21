using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmMain : Form
    {
        FrmViewAllIncidents frmAllIncidents = new FrmViewAllIncidents();
        FrmViewIncidentsByTechnician frmIncidentsByTechnician = new FrmViewIncidentsByTechnician();
        FrmOpenIncidentsByTechnician frmOpenIncidentsByTechnician = new FrmOpenIncidentsByTechnician();
        FrmAddRegistration frmAddRegistration = new FrmAddRegistration();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowFormInMDI(Form aForm)
        {
            aForm.MdiParent = this;
            aForm.Anchor = AnchorStyles.Top;
            aForm.Anchor = AnchorStyles.Left;
            aForm.Dock = DockStyle.Fill;
            aForm.Show();
        }

        private void menuStripItemExit_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            this.Close();
            Application.Exit();
        }

        private void menuStripItemAllIncidents_Click(object sender, EventArgs e)
        {
            ShowFormInMDI(frmAllIncidents);
        }

        private void menuStripItemAllIncidentsByTechnician_Click(object sender, EventArgs e)
        {
            ShowFormInMDI(frmIncidentsByTechnician);
        }

        private void menuStripItemOpenIncidentsByTechnician_Click(object sender, EventArgs e)
        {
            ShowFormInMDI(frmOpenIncidentsByTechnician);
        }

        private void menuStripItemAddRegistration_Click(object sender, EventArgs e)
        {
            ShowFormInMDI(frmAddRegistration);
        }
    }
}
