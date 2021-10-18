
namespace JRProjetCampagneGUI
{
    partial class FrmAjoutAgence
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
            this.pnlAjoutAgence = new System.Windows.Forms.Panel();
            this.btnEnregAgence = new System.Windows.Forms.Button();
            this.rdbTypeAgenceC = new System.Windows.Forms.RadioButton();
            this.rdbTypeAgenceE = new System.Windows.Forms.RadioButton();
            this.cbxVilleAgence = new System.Windows.Forms.ComboBox();
            this.txtEmailAgence = new System.Windows.Forms.TextBox();
            this.txtSiteAgence = new System.Windows.Forms.TextBox();
            this.txtTelephoneAgence = new System.Windows.Forms.TextBox();
            this.txtRueAgence = new System.Windows.Forms.TextBox();
            this.txtNomAgence = new System.Windows.Forms.TextBox();
            this.lblVilleAgence = new System.Windows.Forms.Label();
            this.lblTypeAgence = new System.Windows.Forms.Label();
            this.lblSiteAgence = new System.Windows.Forms.Label();
            this.lblEmailAgence = new System.Windows.Forms.Label();
            this.lblTelephoneAgence = new System.Windows.Forms.Label();
            this.lblRueAgence = new System.Windows.Forms.Label();
            this.lblNomAgence = new System.Windows.Forms.Label();
            this.pnlAjoutAgence.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(532, 62);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(244, 31);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Ajout d\'une agence";
            // 
            // pnlAjoutAgence
            // 
            this.pnlAjoutAgence.Controls.Add(this.btnEnregAgence);
            this.pnlAjoutAgence.Controls.Add(this.rdbTypeAgenceC);
            this.pnlAjoutAgence.Controls.Add(this.rdbTypeAgenceE);
            this.pnlAjoutAgence.Controls.Add(this.cbxVilleAgence);
            this.pnlAjoutAgence.Controls.Add(this.txtEmailAgence);
            this.pnlAjoutAgence.Controls.Add(this.txtSiteAgence);
            this.pnlAjoutAgence.Controls.Add(this.txtTelephoneAgence);
            this.pnlAjoutAgence.Controls.Add(this.txtRueAgence);
            this.pnlAjoutAgence.Controls.Add(this.txtNomAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblVilleAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblTypeAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblSiteAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblEmailAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblTelephoneAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblRueAgence);
            this.pnlAjoutAgence.Controls.Add(this.lblNomAgence);
            this.pnlAjoutAgence.Location = new System.Drawing.Point(325, 145);
            this.pnlAjoutAgence.Name = "pnlAjoutAgence";
            this.pnlAjoutAgence.Size = new System.Drawing.Size(664, 375);
            this.pnlAjoutAgence.TabIndex = 2;
            // 
            // btnEnregAgence
            // 
            this.btnEnregAgence.BackColor = System.Drawing.Color.White;
            this.btnEnregAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregAgence.Location = new System.Drawing.Point(249, 327);
            this.btnEnregAgence.Name = "btnEnregAgence";
            this.btnEnregAgence.Size = new System.Drawing.Size(167, 33);
            this.btnEnregAgence.TabIndex = 16;
            this.btnEnregAgence.Text = "Enregistrer";
            this.btnEnregAgence.UseVisualStyleBackColor = false;
            this.btnEnregAgence.Click += new System.EventHandler(this.btnEnregAgence_Click_1);
            // 
            // rdbTypeAgenceC
            // 
            this.rdbTypeAgenceC.AutoSize = true;
            this.rdbTypeAgenceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbTypeAgenceC.Location = new System.Drawing.Point(502, 285);
            this.rdbTypeAgenceC.Name = "rdbTypeAgenceC";
            this.rdbTypeAgenceC.Size = new System.Drawing.Size(122, 21);
            this.rdbTypeAgenceC.TabIndex = 15;
            this.rdbTypeAgenceC.TabStop = true;
            this.rdbTypeAgenceC.Text = "Communication";
            this.rdbTypeAgenceC.UseMnemonic = false;
            this.rdbTypeAgenceC.UseVisualStyleBackColor = true;
            // 
            // rdbTypeAgenceE
            // 
            this.rdbTypeAgenceE.AutoSize = true;
            this.rdbTypeAgenceE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbTypeAgenceE.Location = new System.Drawing.Point(371, 285);
            this.rdbTypeAgenceE.Name = "rdbTypeAgenceE";
            this.rdbTypeAgenceE.Size = new System.Drawing.Size(122, 21);
            this.rdbTypeAgenceE.TabIndex = 14;
            this.rdbTypeAgenceE.TabStop = true;
            this.rdbTypeAgenceE.Text = "Evénementielle";
            this.rdbTypeAgenceE.UseVisualStyleBackColor = true;
            // 
            // cbxVilleAgence
            // 
            this.cbxVilleAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVilleAgence.FormattingEnabled = true;
            this.cbxVilleAgence.Location = new System.Drawing.Point(374, 104);
            this.cbxVilleAgence.Name = "cbxVilleAgence";
            this.cbxVilleAgence.Size = new System.Drawing.Size(250, 24);
            this.cbxVilleAgence.TabIndex = 13;
            // 
            // txtEmailAgence
            // 
            this.txtEmailAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAgence.Location = new System.Drawing.Point(374, 193);
            this.txtEmailAgence.Name = "txtEmailAgence";
            this.txtEmailAgence.Size = new System.Drawing.Size(250, 23);
            this.txtEmailAgence.TabIndex = 11;
            // 
            // txtSiteAgence
            // 
            this.txtSiteAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteAgence.Location = new System.Drawing.Point(29, 282);
            this.txtSiteAgence.Name = "txtSiteAgence";
            this.txtSiteAgence.Size = new System.Drawing.Size(250, 23);
            this.txtSiteAgence.TabIndex = 10;
            // 
            // txtTelephoneAgence
            // 
            this.txtTelephoneAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneAgence.Location = new System.Drawing.Point(29, 193);
            this.txtTelephoneAgence.Name = "txtTelephoneAgence";
            this.txtTelephoneAgence.Size = new System.Drawing.Size(250, 23);
            this.txtTelephoneAgence.TabIndex = 9;
            // 
            // txtRueAgence
            // 
            this.txtRueAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRueAgence.Location = new System.Drawing.Point(29, 104);
            this.txtRueAgence.Name = "txtRueAgence";
            this.txtRueAgence.Size = new System.Drawing.Size(250, 23);
            this.txtRueAgence.TabIndex = 8;
            // 
            // txtNomAgence
            // 
            this.txtNomAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAgence.Location = new System.Drawing.Point(321, 26);
            this.txtNomAgence.Name = "txtNomAgence";
            this.txtNomAgence.Size = new System.Drawing.Size(187, 23);
            this.txtNomAgence.TabIndex = 7;
            // 
            // lblVilleAgence
            // 
            this.lblVilleAgence.AutoSize = true;
            this.lblVilleAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVilleAgence.Location = new System.Drawing.Point(370, 78);
            this.lblVilleAgence.Name = "lblVilleAgence";
            this.lblVilleAgence.Size = new System.Drawing.Size(236, 20);
            this.lblVilleAgence.TabIndex = 6;
            this.lblVilleAgence.Text = "Sélectionner la ville de l\'agence :";
            // 
            // lblTypeAgence
            // 
            this.lblTypeAgence.AutoSize = true;
            this.lblTypeAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTypeAgence.Location = new System.Drawing.Point(370, 259);
            this.lblTypeAgence.Name = "lblTypeAgence";
            this.lblTypeAgence.Size = new System.Drawing.Size(241, 20);
            this.lblTypeAgence.TabIndex = 5;
            this.lblTypeAgence.Text = "Sélectionner le type de l\'agence :";
            // 
            // lblSiteAgence
            // 
            this.lblSiteAgence.AutoSize = true;
            this.lblSiteAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSiteAgence.Location = new System.Drawing.Point(25, 259);
            this.lblSiteAgence.Name = "lblSiteAgence";
            this.lblSiteAgence.Size = new System.Drawing.Size(219, 20);
            this.lblSiteAgence.TabIndex = 4;
            this.lblSiteAgence.Text = "Saisir le site web de l\'agence :";
            // 
            // lblEmailAgence
            // 
            this.lblEmailAgence.AutoSize = true;
            this.lblEmailAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmailAgence.Location = new System.Drawing.Point(370, 170);
            this.lblEmailAgence.Name = "lblEmailAgence";
            this.lblEmailAgence.Size = new System.Drawing.Size(188, 20);
            this.lblEmailAgence.TabIndex = 3;
            this.lblEmailAgence.Text = "Saisir l\'email de l\'agence :";
            // 
            // lblTelephoneAgence
            // 
            this.lblTelephoneAgence.AutoSize = true;
            this.lblTelephoneAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelephoneAgence.Location = new System.Drawing.Point(25, 170);
            this.lblTelephoneAgence.Name = "lblTelephoneAgence";
            this.lblTelephoneAgence.Size = new System.Drawing.Size(232, 20);
            this.lblTelephoneAgence.TabIndex = 2;
            this.lblTelephoneAgence.Text = "Saisir le téléphone de l\'agence :";
            // 
            // lblRueAgence
            // 
            this.lblRueAgence.AutoSize = true;
            this.lblRueAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRueAgence.Location = new System.Drawing.Point(25, 78);
            this.lblRueAgence.Name = "lblRueAgence";
            this.lblRueAgence.Size = new System.Drawing.Size(184, 20);
            this.lblRueAgence.TabIndex = 1;
            this.lblRueAgence.Text = "Saisir la rue de l\'agence :";
            // 
            // lblNomAgence
            // 
            this.lblNomAgence.AutoSize = true;
            this.lblNomAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomAgence.Location = new System.Drawing.Point(123, 26);
            this.lblNomAgence.Name = "lblNomAgence";
            this.lblNomAgence.Size = new System.Drawing.Size(192, 20);
            this.lblNomAgence.TabIndex = 0;
            this.lblNomAgence.Text = "Saisir le nom de l\'agence :";
            // 
            // FrmAjoutAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1311, 623);
            this.Controls.Add(this.pnlAjoutAgence);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAjoutAgence";
            this.Text = "FrmAjoutAgence";
            this.pnlAjoutAgence.ResumeLayout(false);
            this.pnlAjoutAgence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlAjoutAgence;
        private System.Windows.Forms.Button btnEnregAgence;
        private System.Windows.Forms.RadioButton rdbTypeAgenceC;
        private System.Windows.Forms.RadioButton rdbTypeAgenceE;
        private System.Windows.Forms.ComboBox cbxVilleAgence;
        private System.Windows.Forms.TextBox txtEmailAgence;
        private System.Windows.Forms.TextBox txtSiteAgence;
        private System.Windows.Forms.TextBox txtTelephoneAgence;
        private System.Windows.Forms.TextBox txtRueAgence;
        private System.Windows.Forms.TextBox txtNomAgence;
        private System.Windows.Forms.Label lblVilleAgence;
        private System.Windows.Forms.Label lblTypeAgence;
        private System.Windows.Forms.Label lblSiteAgence;
        private System.Windows.Forms.Label lblEmailAgence;
        private System.Windows.Forms.Label lblTelephoneAgence;
        private System.Windows.Forms.Label lblRueAgence;
        private System.Windows.Forms.Label lblNomAgence;
    }
}