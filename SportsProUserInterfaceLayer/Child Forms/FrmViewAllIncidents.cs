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
    public partial class FrmViewAllIncidents : Form
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


        public FrmViewAllIncidents()
        {
            InitializeComponent();
        }

        private void btnMainMenuFromAllIncidents_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmViewAllIncidents_Load(object sender, EventArgs e)
        {
            IncidentBLL incidentBLL = new IncidentBLL();

            dgvAllIncidents.DataSource = incidentBLL.GetAllIncidents();

            //dgvAllIncidents.Columns["IncidentID"].Visible = false;
            //dgvAllIncidents.Columns["CustomerID"].Visible = false;           
            //dgvAllIncidents.Columns["ProductCode"].Visible = false;
            //dgvAllIncidents.Columns["TechID"].Visible = false;
            //dgvAllIncidents.Columns["DateOpened"].Visible = false;
            //dgvAllIncidents.Columns["DateClosed"].Visible = false;
            //dgvAllIncidents.Columns["Title"].Visible = false;
            //dgvAllIncidents.Columns["Description"].Visible = false;
        }
    }
}
