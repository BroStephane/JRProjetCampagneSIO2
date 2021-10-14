
namespace JRProjetCampagneGUI
{
    partial class FrmAjoutVIP
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
            this.pnlAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(380, 87);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(207, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'un VIP";
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
            this.pnlAjout.Location = new System.Drawing.Point(232, 160);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(495, 397);
            this.pnlAjout.TabIndex = 1;
            // 
            // cbxCategVIP
            // 
            this.cbxCategVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategVIP.FormattingEnabled = true;
            this.cbxCategVIP.Location = new System.Drawing.Point(170, 171);
            this.cbxCategVIP.Name = "cbxCategVIP";
            this.cbxCategVIP.Size = new System.Drawing.Size(185, 24);
            this.cbxCategVIP.TabIndex = 10;
            // 
            // lblCategVIP
            // 
            this.lblCategVIP.AutoSize = true;
            this.lblCategVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategVIP.Location = new System.Drawing.Point(61, 171);
            this.lblCategVIP.Name = "lblCategVIP";
            this.lblCategVIP.Size = new System.Drawing.Size(86, 20);
            this.lblCategVIP.TabIndex = 9;
            this.lblCategVIP.Text = "Catégorie :";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(204, 330);
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
            this.cbxVille.Location = new System.Drawing.Point(170, 273);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(185, 24);
            this.cbxVille.TabIndex = 7;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(98, 273);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(50, 20);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville : ";
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(170, 224);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(185, 23);
            this.txtRue.TabIndex = 5;
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(98, 224);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(51, 20);
            this.lblRue.TabIndex = 4;
            this.lblRue.Text = "Rue : ";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(170, 114);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 23);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(98, 117);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 20);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail : ";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(170, 60);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(185, 23);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(93, 60);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // FrmAjoutVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(979, 653);
            this.Controls.Add(this.pnlAjout);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAjoutVIP";
            this.Text = "Ajout d\'un VIP";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlAjout;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cbxCategVIP;
        private System.Windows.Forms.Label lblCategVIP;
    }
}