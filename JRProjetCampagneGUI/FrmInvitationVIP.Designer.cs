
namespace JRProjetCampagneGUI
{
    partial class FrmInvitationVIP
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
            this.pnlAjout = new System.Windows.Forms.Panel();
            this.cbxEvenement = new System.Windows.Forms.ComboBox();
            this.lblEvenement = new System.Windows.Forms.Label();
            this.cbxVIP = new System.Windows.Forms.ComboBox();
            this.lblVIP = new System.Windows.Forms.Label();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.pnlAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(380, 63);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(421, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Inviter un VIP à un événement ";
            // 
            // pnlAjout
            // 
            this.pnlAjout.Controls.Add(this.btnEnvoyer);
            this.pnlAjout.Controls.Add(this.cbxEvenement);
            this.pnlAjout.Controls.Add(this.lblEvenement);
            this.pnlAjout.Controls.Add(this.cbxVIP);
            this.pnlAjout.Controls.Add(this.lblVIP);
            this.pnlAjout.Location = new System.Drawing.Point(297, 225);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(693, 463);
            this.pnlAjout.TabIndex = 1;
            // 
            // cbxEvenement
            // 
            this.cbxEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvenement.FormattingEnabled = true;
            this.cbxEvenement.Location = new System.Drawing.Point(209, 166);
            this.cbxEvenement.Name = "cbxEvenement";
            this.cbxEvenement.Size = new System.Drawing.Size(313, 24);
            this.cbxEvenement.TabIndex = 3;
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenement.Location = new System.Drawing.Point(60, 166);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(102, 20);
            this.lblEvenement.TabIndex = 2;
            this.lblEvenement.Text = "Événement : ";
            // 
            // cbxVIP
            // 
            this.cbxVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVIP.FormattingEnabled = true;
            this.cbxVIP.Location = new System.Drawing.Point(209, 84);
            this.cbxVIP.Name = "cbxVIP";
            this.cbxVIP.Size = new System.Drawing.Size(121, 24);
            this.cbxVIP.TabIndex = 1;
            // 
            // lblVIP
            // 
            this.lblVIP.AutoSize = true;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIP.Location = new System.Drawing.Point(115, 84);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(47, 20);
            this.lblVIP.TabIndex = 0;
            this.lblVIP.Text = "VIP : ";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.Location = new System.Drawing.Point(436, 275);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(86, 36);
            this.btnEnvoyer.TabIndex = 4;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // FrmInvitationVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1238, 733);
            this.Controls.Add(this.pnlAjout);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmInvitationVIP";
            this.Text = "Invitation d\'un VIP";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlAjout;
        private System.Windows.Forms.ComboBox cbxEvenement;
        private System.Windows.Forms.Label lblEvenement;
        private System.Windows.Forms.ComboBox cbxVIP;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.Button btnEnvoyer;
    }
}