
namespace JRProjetCampagneGUI
{
    partial class FrmSuppAgence
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAgenceSupp = new System.Windows.Forms.Label();
            this.cbxAgenceSupp = new System.Windows.Forms.ComboBox();
            this.pnlAgenceSupp = new System.Windows.Forms.Panel();
            this.btnSuppSupp = new System.Windows.Forms.Button();
            this.pnlAgenceSupp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lblTitre.Location = new System.Drawing.Point(418, 67);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(361, 33);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Suppression d\'une Agence";
            // 
            // lblAgenceSupp
            // 
            this.lblAgenceSupp.AutoSize = true;
            this.lblAgenceSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAgenceSupp.Location = new System.Drawing.Point(336, 285);
            this.lblAgenceSupp.Name = "lblAgenceSupp";
            this.lblAgenceSupp.Size = new System.Drawing.Size(281, 20);
            this.lblAgenceSupp.TabIndex = 9;
            this.lblAgenceSupp.Text = "Sélectionner une agence à supprimer :";
            // 
            // cbxAgenceSupp
            // 
            this.cbxAgenceSupp.FormattingEnabled = true;
            this.cbxAgenceSupp.Location = new System.Drawing.Point(623, 287);
            this.cbxAgenceSupp.Name = "cbxAgenceSupp";
            this.cbxAgenceSupp.Size = new System.Drawing.Size(241, 21);
            this.cbxAgenceSupp.TabIndex = 10;
            this.cbxAgenceSupp.SelectionChangeCommitted += new System.EventHandler(this.cbxAgenceMod_SelectionChangeCommitted);
            // 
            // pnlAgenceSupp
            // 
            this.pnlAgenceSupp.Controls.Add(this.btnSuppSupp);
            this.pnlAgenceSupp.Location = new System.Drawing.Point(340, 417);
            this.pnlAgenceSupp.Name = "pnlAgenceSupp";
            this.pnlAgenceSupp.Size = new System.Drawing.Size(524, 120);
            this.pnlAgenceSupp.TabIndex = 11;
            this.pnlAgenceSupp.Visible = false;
            // 
            // btnSuppSupp
            // 
            this.btnSuppSupp.Location = new System.Drawing.Point(211, 53);
            this.btnSuppSupp.Name = "btnSuppSupp";
            this.btnSuppSupp.Size = new System.Drawing.Size(104, 26);
            this.btnSuppSupp.TabIndex = 0;
            this.btnSuppSupp.Text = "Supprimer";
            this.btnSuppSupp.UseVisualStyleBackColor = true;
            this.btnSuppSupp.Click += new System.EventHandler(this.btnSuppSupp_Click);
            // 
            // FrmSuppAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1241, 655);
            this.Controls.Add(this.pnlAgenceSupp);
            this.Controls.Add(this.cbxAgenceSupp);
            this.Controls.Add(this.lblAgenceSupp);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmSuppAgence";
            this.Text = "FrmSuppAgence";
            this.pnlAgenceSupp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAgenceSupp;
        private System.Windows.Forms.ComboBox cbxAgenceSupp;
        private System.Windows.Forms.Panel pnlAgenceSupp;
        private System.Windows.Forms.Button btnSuppSupp;
    }
}