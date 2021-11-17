
namespace JRProjetCampagneGUI
{
    partial class FrmModifVIP
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
            this.pnlAjout = new System.Windows.Forms.Panel();
            this.cbxCategVIP = new System.Windows.Forms.ComboBox();
            this.lblCategVIP = new System.Windows.Forms.Label();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblRue = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblModif = new System.Windows.Forms.Label();
            this.cbxVIP = new System.Windows.Forms.ComboBox();
            this.pnlAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAjout
            // 
            this.pnlAjout.Controls.Add(this.cbxCategVIP);
            this.pnlAjout.Controls.Add(this.lblCategVIP);
            this.pnlAjout.Controls.Add(this.btnEnvoyer);
            this.pnlAjout.Controls.Add(this.cbxVille);
            this.pnlAjout.Controls.Add(this.lblVille);
            this.pnlAjout.Controls.Add(this.txtRue);
            this.pnlAjout.Controls.Add(this.lblRue);
            this.pnlAjout.Controls.Add(this.txtMail);
            this.pnlAjout.Controls.Add(this.lblMail);
            this.pnlAjout.Controls.Add(this.txtNom);
            this.pnlAjout.Controls.Add(this.lblNom);
            this.pnlAjout.Location = new System.Drawing.Point(248, 196);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(495, 340);
            this.pnlAjout.TabIndex = 3;
            // 
            // cbxCategVIP
            // 
            this.cbxCategVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategVIP.FormattingEnabled = true;
            this.cbxCategVIP.Location = new System.Drawing.Point(185, 134);
            this.cbxCategVIP.Name = "cbxCategVIP";
            this.cbxCategVIP.Size = new System.Drawing.Size(185, 24);
            this.cbxCategVIP.TabIndex = 10;
            // 
            // lblCategVIP
            // 
            this.lblCategVIP.AutoSize = true;
            this.lblCategVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategVIP.Location = new System.Drawing.Point(76, 134);
            this.lblCategVIP.Name = "lblCategVIP";
            this.lblCategVIP.Size = new System.Drawing.Size(86, 20);
            this.lblCategVIP.TabIndex = 9;
            this.lblCategVIP.Text = "Catégorie :";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(219, 293);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(102, 38);
            this.btnEnvoyer.TabIndex = 8;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // cbxVille
            // 
            this.cbxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(185, 236);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(212, 24);
            this.cbxVille.TabIndex = 7;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(113, 236);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(50, 20);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville : ";
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(185, 187);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(234, 23);
            this.txtRue.TabIndex = 5;
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(113, 187);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(51, 20);
            this.lblRue.TabIndex = 4;
            this.lblRue.Text = "Rue : ";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(185, 77);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 23);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(113, 80);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 20);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail : ";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(185, 23);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(185, 23);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(108, 23);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(369, 39);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(298, 36);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Modification d\'un VIP";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // lblModif
            // 
            this.lblModif.AutoSize = true;
            this.lblModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModif.Location = new System.Drawing.Point(245, 142);
            this.lblModif.Name = "lblModif";
            this.lblModif.Size = new System.Drawing.Size(269, 18);
            this.lblModif.TabIndex = 4;
            this.lblModif.Text = "Veuillez sélectionner un VIP à modifier : ";
            // 
            // cbxVIP
            // 
            this.cbxVIP.FormattingEnabled = true;
            this.cbxVIP.Location = new System.Drawing.Point(576, 142);
            this.cbxVIP.Name = "cbxVIP";
            this.cbxVIP.Size = new System.Drawing.Size(121, 21);
            this.cbxVIP.TabIndex = 5;
            this.cbxVIP.SelectionChangeCommitted += new System.EventHandler(this.cbxVIP_SelectionChangeCommitted);
            // 
            // FrmModifVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 559);
            this.Controls.Add(this.cbxVIP);
            this.Controls.Add(this.lblModif);
            this.Controls.Add(this.pnlAjout);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmModifVIP";
            this.Text = "FrmModifVIP";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjout;
        private System.Windows.Forms.ComboBox cbxCategVIP;
        private System.Windows.Forms.Label lblCategVIP;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblModif;
        private System.Windows.Forms.ComboBox cbxVIP;
    }
}