namespace SportsProUserInterfaceLayer
{
    partial class FrmViewAllIncidents
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
            this.btnMainMenuFromAllIncidents = new System.Windows.Forms.Button();
            this.dgvAllIncidents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllIncidents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenuFromAllIncidents
            // 
            this.btnMainMenuFromAllIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuFromAllIncidents.Location = new System.Drawing.Point(665, 575);
            this.btnMainMenuFromAllIncidents.Name = "btnMainMenuFromAllIncidents";
            this.btnMainMenuFromAllIncidents.Size = new System.Drawing.Size(184, 44);
            this.btnMainMenuFromAllIncidents.TabIndex = 1;
            this.btnMainMenuFromAllIncidents.Text = "Return to Main Menu";
            this.btnMainMenuFromAllIncidents.UseVisualStyleBackColor = true;
            this.btnMainMenuFromAllIncidents.Click += new System.EventHandler(this.btnMainMenuFromAllIncidents_Click);
            // 
            // dgvAllIncidents
            // 
            this.dgvAllIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllIncidents.Location = new System.Drawing.Point(1, 0);
            this.dgvAllIncidents.Name = "dgvAllIncidents";
            this.dgvAllIncidents.RowTemplate.Height = 24;
            this.dgvAllIncidents.Size = new System.Drawing.Size(860, 569);
            this.dgvAllIncidents.TabIndex = 2;
            // 
            // FrmViewAllIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 631);
            this.Controls.Add(this.btnMainMenuFromAllIncidents);
            this.Controls.Add(this.dgvAllIncidents);
            this.Name = "FrmViewAllIncidents";
            this.Text = "All Incidents View";
            this.Load += new System.EventHandler(this.FrmViewAllIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllIncidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenuFromAllIncidents;
        private System.Windows.Forms.DataGridView dgvAllIncidents;
    }
}