
namespace JRProjetCampagneGUI
{
    partial class FrmSupCampagne
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
            this.lblCampagne = new System.Windows.Forms.Label();
            this.cbxCampagne = new System.Windows.Forms.ComboBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitre.Location = new System.Drawing.Point(434, 85);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(370, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Suppression d\'une campagne";
            // 
            // lblCampagne
            // 
            this.lblCampagne.AutoSize = true;
            this.lblCampagne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCampagne.Location = new System.Drawing.Point(195, 203);
            this.lblCampagne.Name = "lblCampagne";
            this.lblCampagne.Size = new System.Drawing.Size(216, 20);
            this.lblCampagne.TabIndex = 1;
            this.lblCampagne.Text = "Sélectionner une campagne :";
            // 
            // cbxCampagne
            // 
            this.cbxCampagne.FormattingEnabled = true;
            this.cbxCampagne.Location = new System.Drawing.Point(417, 202);
            this.cbxCampagne.Name = "cbxCampagne";
            this.cbxCampagne.Size = new System.Drawing.Size(387, 21);
            this.cbxCampagne.TabIndex = 2;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(552, 381);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(101, 42);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // FrmSupCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1214, 633);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.cbxCampagne);
            this.Controls.Add(this.lblCampagne);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmSupCampagne";
            this.Text = "Suppression d\'une campagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblCampagne;
        private System.Windows.Forms.ComboBox cbxCampagne;
        private System.Windows.Forms.Button btnSuppr;
    }
}