namespace SportsProUserInterfaceLayer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuStripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemMaintainProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemMaintainCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemMaintainRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemAddRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemUpdateRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemDeleteRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemMaintainTechnicians = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemAddTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemUpdateTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemDeleteTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemAllIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemAllIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemCreateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemUpdateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemOpenIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemFile,
            this.menuStripItemMaintenance,
            this.menuStripItemRegistration,
            this.menuStripItemIncidents});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(733, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // menuStripItemFile
            // 
            this.menuStripItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemExit});
            this.menuStripItemFile.Name = "menuStripItemFile";
            this.menuStripItemFile.Size = new System.Drawing.Size(44, 24);
            this.menuStripItemFile.Text = "File";
            // 
            // menuStripItemExit
            // 
            this.menuStripItemExit.Name = "menuStripItemExit";
            this.menuStripItemExit.Size = new System.Drawing.Size(108, 26);
            this.menuStripItemExit.Text = "Exit";
            this.menuStripItemExit.Click += new System.EventHandler(this.menuStripItemExit_Click);
            // 
            // menuStripItemMaintenance
            // 
            this.menuStripItemMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemMaintainProducts,
            this.menuStripItemMaintainCustomers,
            this.menuStripItemMaintainRegistrations,
            this.menuStripItemMaintainTechnicians});
            this.menuStripItemMaintenance.Name = "menuStripItemMaintenance";
            this.menuStripItemMaintenance.Size = new System.Drawing.Size(106, 24);
            this.menuStripItemMaintenance.Text = "Maintenance";
            // 
            // menuStripItemMaintainProducts
            // 
            this.menuStripItemMaintainProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemAddProduct,
            this.menuStripItemUpdateProduct,
            this.menuStripItemDeleteProduct});
            this.menuStripItemMaintainProducts.Name = "menuStripItemMaintainProducts";
            this.menuStripItemMaintainProducts.Size = new System.Drawing.Size(232, 26);
            this.menuStripItemMaintainProducts.Text = "Maintain Products";
            // 
            // menuStripItemAddProduct
            // 
            this.menuStripItemAddProduct.Name = "menuStripItemAddProduct";
            this.menuStripItemAddProduct.Size = new System.Drawing.Size(188, 26);
            this.menuStripItemAddProduct.Text = "Add Product";
            // 
            // menuStripItemUpdateProduct
            // 
            this.menuStripItemUpdateProduct.Name = "menuStripItemUpdateProduct";
            this.menuStripItemUpdateProduct.Size = new System.Drawing.Size(188, 26);
            this.menuStripItemUpdateProduct.Text = "Update Product";
            // 
            // menuStripItemDeleteProduct
            // 
            this.menuStripItemDeleteProduct.Name = "menuStripItemDeleteProduct";
            this.menuStripItemDeleteProduct.Size = new System.Drawing.Size(188, 26);
            this.menuStripItemDeleteProduct.Text = "Delete Product";
            // 
            // menuStripItemMaintainCustomers
            // 
            this.menuStripItemMaintainCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemAddCustomer,
            this.menuStripItemUpdateCustomer,
            this.menuStripItemDeleteCustomer});
            this.menuStripItemMaintainCustomers.Name = "menuStripItemMaintainCustomers";
            this.menuStripItemMaintainCustomers.Size = new System.Drawing.Size(232, 26);
            this.menuStripItemMaintainCustomers.Text = "Maintain Customers";
            // 
            // menuStripItemAddCustomer
            // 
            this.menuStripItemAddCustomer.Name = "menuStripItemAddCustomer";
            this.menuStripItemAddCustomer.Size = new System.Drawing.Size(200, 26);
            this.menuStripItemAddCustomer.Text = "Add Customer";
            // 
            // menuStripItemUpdateCustomer
            // 
            this.menuStripItemUpdateCustomer.Name = "menuStripItemUpdateCustomer";
            this.menuStripItemUpdateCustomer.Size = new System.Drawing.Size(200, 26);
            this.menuStripItemUpdateCustomer.Text = "Update Customer";
            // 
            // menuStripItemDeleteCustomer
            // 
            this.menuStripItemDeleteCustomer.Name = "menuStripItemDeleteCustomer";
            this.menuStripItemDeleteCustomer.Size = new System.Drawing.Size(200, 26);
            this.menuStripItemDeleteCustomer.Text = "Delete Customer";
            // 
            // menuStripItemMaintainRegistrations
            // 
            this.menuStripItemMaintainRegistrations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemAddRegistration,
            this.menuStripItemUpdateRegistration,
            this.menuStripItemDeleteRegistration});
            this.menuStripItemMaintainRegistrations.Name = "menuStripItemMaintainRegistrations";
            this.menuStripItemMaintainRegistrations.Size = new System.Drawing.Size(232, 26);
            this.menuStripItemMaintainRegistrations.Text = "Maintain Registrations";
            // 
            // menuStripItemAddRegistration
            // 
            this.menuStripItemAddRegistration.Name = "menuStripItemAddRegistration";
            this.menuStripItemAddRegistration.Size = new System.Drawing.Size(217, 26);
            this.menuStripItemAddRegistration.Text = "Add Registration";
            this.menuStripItemAddRegistration.Click += new System.EventHandler(this.menuStripItemAddRegistration_Click);
            // 
            // menuStripItemUpdateRegistration
            // 
            this.menuStripItemUpdateRegistration.Name = "menuStripItemUpdateRegistration";
            this.menuStripItemUpdateRegistration.Size = new System.Drawing.Size(217, 26);
            this.menuStripItemUpdateRegistration.Text = "Update Registration";
            // 
            // menuStripItemDeleteRegistration
            // 
            this.menuStripItemDeleteRegistration.Name = "menuStripItemDeleteRegistration";
            this.menuStripItemDeleteRegistration.Size = new System.Drawing.Size(217, 26);
            this.menuStripItemDeleteRegistration.Text = "Delete Registration";
            // 
            // menuStripItemMaintainTechnicians
            // 
            this.menuStripItemMaintainTechnicians.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemAddTechnician,
            this.menuStripItemUpdateTechnician,
            this.menuStripItemDeleteTechnician});
            this.menuStripItemMaintainTechnicians.Name = "menuStripItemMaintainTechnicians";
            this.menuStripItemMaintainTechnicians.Size = new System.Drawing.Size(232, 26);
            this.menuStripItemMaintainTechnicians.Text = "Maintain Technicians";
            // 
            // menuStripItemAddTechnician
            // 
            this.menuStripItemAddTechnician.Name = "menuStripItemAddTechnician";
            this.menuStripItemAddTechnician.Size = new System.Drawing.Size(206, 26);
            this.menuStripItemAddTechnician.Text = "Add Technician";
            // 
            // menuStripItemUpdateTechnician
            // 
            this.menuStripItemUpdateTechnician.Name = "menuStripItemUpdateTechnician";
            this.menuStripItemUpdateTechnician.Size = new System.Drawing.Size(206, 26);
            this.menuStripItemUpdateTechnician.Text = "Update Technician";
            // 
            // menuStripItemDeleteTechnician
            // 
            this.menuStripItemDeleteTechnician.Name = "menuStripItemDeleteTechnician";
            this.menuStripItemDeleteTechnician.Size = new System.Drawing.Size(206, 26);
            this.menuStripItemDeleteTechnician.Text = "Delete Technician";
            // 
            // menuStripItemRegistration
            // 
            this.menuStripItemRegistration.Name = "menuStripItemRegistration";
            this.menuStripItemRegistration.Size = new System.Drawing.Size(101, 24);
            this.menuStripItemRegistration.Text = "Registration";
            // 
            // menuStripItemIncidents
            // 
            this.menuStripItemIncidents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemAllIncidents,
            this.menuStripItemAllIncidentsByTechnician,
            this.menuStripItemCreateIncident,
            this.menuStripItemUpdateIncident,
            this.menuStripItemOpenIncidentsByTechnician});
            this.menuStripItemIncidents.Name = "menuStripItemIncidents";
            this.menuStripItemIncidents.Size = new System.Drawing.Size(80, 24);
            this.menuStripItemIncidents.Text = "Incidents";
            // 
            // menuStripItemAllIncidents
            // 
            this.menuStripItemAllIncidents.Name = "menuStripItemAllIncidents";
            this.menuStripItemAllIncidents.Size = new System.Drawing.Size(329, 26);
            this.menuStripItemAllIncidents.Text = "Display All Incidents";
            this.menuStripItemAllIncidents.Click += new System.EventHandler(this.menuStripItemAllIncidents_Click);
            // 
            // menuStripItemAllIncidentsByTechnician
            // 
            this.menuStripItemAllIncidentsByTechnician.Name = "menuStripItemAllIncidentsByTechnician";
            this.menuStripItemAllIncidentsByTechnician.Size = new System.Drawing.Size(329, 26);
            this.menuStripItemAllIncidentsByTechnician.Text = "Display All Incidents By Technician";
            this.menuStripItemAllIncidentsByTechnician.Click += new System.EventHandler(this.menuStripItemAllIncidentsByTechnician_Click);
            // 
            // menuStripItemCreateIncident
            // 
            this.menuStripItemCreateIncident.Name = "menuStripItemCreateIncident";
            this.menuStripItemCreateIncident.Size = new System.Drawing.Size(329, 26);
            this.menuStripItemCreateIncident.Text = "Create Incident";
            // 
            // menuStripItemUpdateIncident
            // 
            this.menuStripItemUpdateIncident.Name = "menuStripItemUpdateIncident";
            this.menuStripItemUpdateIncident.Size = new System.Drawing.Size(329, 26);
            this.menuStripItemUpdateIncident.Text = "Update Incident";
            // 
            // menuStripItemOpenIncidentsByTechnician
            // 
            this.menuStripItemOpenIncidentsByTechnician.Name = "menuStripItemOpenIncidentsByTechnician";
            this.menuStripItemOpenIncidentsByTechnician.Size = new System.Drawing.Size(329, 26);
            this.menuStripItemOpenIncidentsByTechnician.Text = "Display Open Incidents By Technician";
            this.menuStripItemOpenIncidentsByTechnician.Click += new System.EventHandler(this.menuStripItemOpenIncidentsByTechnician_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 537);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(733, 25);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(352, 20);
            this.toolStripStatusLabelMain.Text = "Sports Pro Application - Designed By Drew Leonard";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 562);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Pro Application - Main Menu";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemMaintenance;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemMaintainProducts;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemMaintainCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemMaintainRegistrations;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemMaintainTechnicians;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemRegistration;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemIncidents;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAllIncidents;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAllIncidentsByTechnician;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemCreateIncident;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAddProduct;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemDeleteProduct;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAddRegistration;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemUpdateRegistration;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemDeleteRegistration;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAddTechnician;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemUpdateTechnician;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemDeleteTechnician;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemUpdateIncident;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemOpenIncidentsByTechnician;
    }
}

