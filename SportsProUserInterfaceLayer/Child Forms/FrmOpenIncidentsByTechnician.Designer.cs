namespace SportsProUserInterfaceLayer
{
    partial class FrmOpenIncidentsByTechnician
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
            this.cboTechnicians = new System.Windows.Forms.ComboBox();
            this.dgvOpenIncidentsByTechnician = new System.Windows.Forms.DataGridView();
            this.btnMainMenuFromOpenIncidentsByTechnician = new System.Windows.Forms.Button();
            this.lblSelectTechnician = new System.Windows.Forms.Label();
            this.lblTechnicianEmail = new System.Windows.Forms.Label();
            this.lblTechnicianPhone = new System.Windows.Forms.Label();
            this.lblOutputTechnicianEmail = new System.Windows.Forms.Label();
            this.lblOutputTechnicianPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenIncidentsByTechnician)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTechnicians
            // 
            this.cboTechnicians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTechnicians.FormattingEnabled = true;
            this.cboTechnicians.Location = new System.Drawing.Point(256, 26);
            this.cboTechnicians.Name = "cboTechnicians";
            this.cboTechnicians.Size = new System.Drawing.Size(232, 24);
            this.cboTechnicians.TabIndex = 0;
            this.cboTechnicians.SelectionChangeCommitted += new System.EventHandler(this.cboTechnicians_SelectionChangeCommitted);
            // 
            // dgvOpenIncidentsByTechnician
            // 
            this.dgvOpenIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOpenIncidentsByTechnician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenIncidentsByTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenIncidentsByTechnician.Location = new System.Drawing.Point(0, 164);
            this.dgvOpenIncidentsByTechnician.Name = "dgvOpenIncidentsByTechnician";
            this.dgvOpenIncidentsByTechnician.RowTemplate.Height = 24;
            this.dgvOpenIncidentsByTechnician.Size = new System.Drawing.Size(673, 240);
            this.dgvOpenIncidentsByTechnician.TabIndex = 1;
            // 
            // btnMainMenuFromOpenIncidentsByTechnician
            // 
            this.btnMainMenuFromOpenIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuFromOpenIncidentsByTechnician.Location = new System.Drawing.Point(482, 410);
            this.btnMainMenuFromOpenIncidentsByTechnician.Name = "btnMainMenuFromOpenIncidentsByTechnician";
            this.btnMainMenuFromOpenIncidentsByTechnician.Size = new System.Drawing.Size(179, 44);
            this.btnMainMenuFromOpenIncidentsByTechnician.TabIndex = 5;
            this.btnMainMenuFromOpenIncidentsByTechnician.Text = "Return To Main Menu";
            this.btnMainMenuFromOpenIncidentsByTechnician.UseVisualStyleBackColor = true;
            this.btnMainMenuFromOpenIncidentsByTechnician.Click += new System.EventHandler(this.btnMainMenuFromOpenIncidentsByTechnician_Click);
            // 
            // lblSelectTechnician
            // 
            this.lblSelectTechnician.AutoSize = true;
            this.lblSelectTechnician.Location = new System.Drawing.Point(61, 29);
            this.lblSelectTechnician.Name = "lblSelectTechnician";
            this.lblSelectTechnician.Size = new System.Drawing.Size(171, 17);
            this.lblSelectTechnician.TabIndex = 6;
            this.lblSelectTechnician.Text = "Please Select Technician:";
            // 
            // lblTechnicianEmail
            // 
            this.lblTechnicianEmail.AutoSize = true;
            this.lblTechnicianEmail.Location = new System.Drawing.Point(68, 78);
            this.lblTechnicianEmail.Name = "lblTechnicianEmail";
            this.lblTechnicianEmail.Size = new System.Drawing.Size(119, 17);
            this.lblTechnicianEmail.TabIndex = 7;
            this.lblTechnicianEmail.Text = "Technician Email:";
            // 
            // lblTechnicianPhone
            // 
            this.lblTechnicianPhone.AutoSize = true;
            this.lblTechnicianPhone.Location = new System.Drawing.Point(61, 126);
            this.lblTechnicianPhone.Name = "lblTechnicianPhone";
            this.lblTechnicianPhone.Size = new System.Drawing.Size(126, 17);
            this.lblTechnicianPhone.TabIndex = 8;
            this.lblTechnicianPhone.Text = "Technician Phone:";
            // 
            // lblOutputTechnicianEmail
            // 
            this.lblOutputTechnicianEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputTechnicianEmail.Location = new System.Drawing.Point(240, 72);
            this.lblOutputTechnicianEmail.Name = "lblOutputTechnicianEmail";
            this.lblOutputTechnicianEmail.Size = new System.Drawing.Size(315, 23);
            this.lblOutputTechnicianEmail.TabIndex = 9;
            // 
            // lblOutputTechnicianPhone
            // 
            this.lblOutputTechnicianPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputTechnicianPhone.Location = new System.Drawing.Point(240, 126);
            this.lblOutputTechnicianPhone.Name = "lblOutputTechnicianPhone";
            this.lblOutputTechnicianPhone.Size = new System.Drawing.Size(315, 23);
            this.lblOutputTechnicianPhone.TabIndex = 10;
            // 
            // FrmOpenIncidentsByTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 466);
            this.Controls.Add(this.btnMainMenuFromOpenIncidentsByTechnician);
            this.Controls.Add(this.cboTechnicians);
            this.Controls.Add(this.lblOutputTechnicianPhone);
            this.Controls.Add(this.lblOutputTechnicianEmail);
            this.Controls.Add(this.lblTechnicianPhone);
            this.Controls.Add(this.lblTechnicianEmail);
            this.Controls.Add(this.lblSelectTechnician);
            this.Controls.Add(this.dgvOpenIncidentsByTechnician);
            this.Name = "FrmOpenIncidentsByTechnician";
            this.Text = "List of Incidents Assigned to Specified Technician";
            this.Load += new System.EventHandler(this.FrmOpenIncidentsByTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenIncidentsByTechnician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTechnicians;
        private System.Windows.Forms.DataGridView dgvOpenIncidentsByTechnician;
        private System.Windows.Forms.Button btnMainMenuFromOpenIncidentsByTechnician;
        private System.Windows.Forms.Label lblSelectTechnician;
        private System.Windows.Forms.Label lblTechnicianEmail;
        private System.Windows.Forms.Label lblTechnicianPhone;
        private System.Windows.Forms.Label lblOutputTechnicianEmail;
        private System.Windows.Forms.Label lblOutputTechnicianPhone;
    }
}