namespace SportsProUserInterfaceLayer
{
    partial class FrmAddRegistration
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
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.btnMainMenuFromAddRegistration = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(59, 165);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(238, 24);
            this.cboCustomerName.TabIndex = 0;
            // 
            // btnMainMenuFromAddRegistration
            // 
            this.btnMainMenuFromAddRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainMenuFromAddRegistration.Location = new System.Drawing.Point(390, 300);
            this.btnMainMenuFromAddRegistration.Name = "btnMainMenuFromAddRegistration";
            this.btnMainMenuFromAddRegistration.Size = new System.Drawing.Size(184, 44);
            this.btnMainMenuFromAddRegistration.TabIndex = 2;
            this.btnMainMenuFromAddRegistration.Text = "Return to Main Menu";
            this.btnMainMenuFromAddRegistration.UseVisualStyleBackColor = true;
            this.btnMainMenuFromAddRegistration.Click += new System.EventHandler(this.btnMainMenuFromAddRegistration_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistration.Location = new System.Drawing.Point(59, 300);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(184, 44);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(56, 91);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(113, 17);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(387, 91);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(61, 17);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";
            // 
            // cboProductName
            // 
            this.cboProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(390, 165);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(238, 24);
            this.cboProductName.TabIndex = 6;
            // 
            // FrmAddRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 444);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnMainMenuFromAddRegistration);
            this.Controls.Add(this.cboCustomerName);
            this.Name = "FrmAddRegistration";
            this.Text = "Add Registration";
            this.Load += new System.EventHandler(this.FrmAddRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Button btnMainMenuFromAddRegistration;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cboProductName;
    }
}