namespace SportsProUserInterfaceLayer
{
    partial class FrmViewIncidentsByTechnician
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
            this.lblEnterTechnicianID = new System.Windows.Forms.Label();
            this.txtTechnicianID = new System.Windows.Forms.TextBox();
            this.btnGetIncidentsByTechnician = new System.Windows.Forms.Button();
            this.dgvIncidentsByTechnician = new System.Windows.Forms.DataGridView();
            this.btnMainMenuFromIncidentsByTechnician = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentsByTechnician)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterTechnicianID
            // 
            this.lblEnterTechnicianID.AutoSize = true;
            this.lblEnterTechnicianID.Location = new System.Drawing.Point(31, 62);
            this.lblEnterTechnicianID.Name = "lblEnterTechnicianID";
            this.lblEnterTechnicianID.Size = new System.Drawing.Size(182, 17);
            this.lblEnterTechnicianID.TabIndex = 0;
            this.lblEnterTechnicianID.Text = "Please enter Technician ID:";
            // 
            // txtTechnicianID
            // 
            this.txtTechnicianID.Location = new System.Drawing.Point(219, 59);
            this.txtTechnicianID.Name = "txtTechnicianID";
            this.txtTechnicianID.Size = new System.Drawing.Size(100, 22);
            this.txtTechnicianID.TabIndex = 1;
            this.txtTechnicianID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGetIncidentsByTechnician
            // 
            this.btnGetIncidentsByTechnician.Location = new System.Drawing.Point(357, 58);
            this.btnGetIncidentsByTechnician.Name = "btnGetIncidentsByTechnician";
            this.btnGetIncidentsByTechnician.Size = new System.Drawing.Size(148, 25);
            this.btnGetIncidentsByTechnician.TabIndex = 2;
            this.btnGetIncidentsByTechnician.Text = "Get Incidents";
            this.btnGetIncidentsByTechnician.UseVisualStyleBackColor = true;
            this.btnGetIncidentsByTechnician.Click += new System.EventHandler(this.btnGetIncidentsByTechnician_Click);
            // 
            // dgvIncidentsByTechnician
            // 
            this.dgvIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidentsByTechnician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncidentsByTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidentsByTechnician.Location = new System.Drawing.Point(1, 110);
            this.dgvIncidentsByTechnician.Name = "dgvIncidentsByTechnician";
            this.dgvIncidentsByTechnician.RowTemplate.Height = 24;
            this.dgvIncidentsByTechnician.Size = new System.Drawing.Size(651, 378);
            this.dgvIncidentsByTechnician.TabIndex = 3;
            // 
            // btnMainMenuFromIncidentsByTechnician
            // 
            this.btnMainMenuFromIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuFromIncidentsByTechnician.Location = new System.Drawing.Point(462, 494);
            this.btnMainMenuFromIncidentsByTechnician.Name = "btnMainMenuFromIncidentsByTechnician";
            this.btnMainMenuFromIncidentsByTechnician.Size = new System.Drawing.Size(179, 44);
            this.btnMainMenuFromIncidentsByTechnician.TabIndex = 4;
            this.btnMainMenuFromIncidentsByTechnician.Text = "Return To Main Menu";
            this.btnMainMenuFromIncidentsByTechnician.UseVisualStyleBackColor = true;
            this.btnMainMenuFromIncidentsByTechnician.Click += new System.EventHandler(this.btnMainMenuFromIncidentsByTechnician_Click);
            // 
            // FrmViewIncidentsByTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 550);
            this.Controls.Add(this.btnMainMenuFromIncidentsByTechnician);
            this.Controls.Add(this.dgvIncidentsByTechnician);
            this.Controls.Add(this.btnGetIncidentsByTechnician);
            this.Controls.Add(this.txtTechnicianID);
            this.Controls.Add(this.lblEnterTechnicianID);
            this.Name = "FrmViewIncidentsByTechnician";
            this.Text = "All Incidents By Technician View";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentsByTechnician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTechnicianID;
        private System.Windows.Forms.TextBox txtTechnicianID;
        private System.Windows.Forms.Button btnGetIncidentsByTechnician;
        private System.Windows.Forms.DataGridView dgvIncidentsByTechnician;
        private System.Windows.Forms.Button btnMainMenuFromIncidentsByTechnician;
    }
}