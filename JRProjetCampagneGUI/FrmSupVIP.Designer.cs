
namespace JRProjetCampagneGUI
{
    partial class FrmSupVIP
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
            this.lblVIP = new System.Windows.Forms.Label();
            this.cbxVIP = new System.Windows.Forms.ComboBox();
            this.btnSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(284, 75);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(305, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Suppression d\'un VIP";
            // 
            // lblVIP
            // 
            this.lblVIP.AutoSize = true;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIP.Location = new System.Drawing.Point(171, 223);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(218, 20);
            this.lblVIP.TabIndex = 1;
            this.lblVIP.Text = "Veuillez sélectionner un VIP : ";
            // 
            // cbxVIP
            // 
            this.cbxVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVIP.FormattingEnabled = true;
            this.cbxVIP.Location = new System.Drawing.Point(437, 219);
            this.cbxVIP.Name = "cbxVIP";
            this.cbxVIP.Size = new System.Drawing.Size(152, 24);
            this.cbxVIP.TabIndex = 2;
            this.cbxVIP.SelectionChangeCommitted += new System.EventHandler(this.cbxVIP_SelectionChangeCommitted);
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(494, 360);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(95, 32);
            this.btnSup.TabIndex = 4;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // FrmSupVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(899, 644);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.cbxVIP);
            this.Controls.Add(this.lblVIP);
            this.Controls.Add(this.lblTitre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "FrmSupVIP";
            this.Text = "Suppression d\'un VIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.ComboBox cbxVIP;
        private System.Windows.Forms.Button btnSup;
    }
}