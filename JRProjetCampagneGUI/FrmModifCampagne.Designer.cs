
namespace JRProjetCampagneGUI
{
    partial class FrmModifCampagne
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
            this.pnlCampagne = new System.Windows.Forms.Panel();
            this.cbxAgenceCommunication = new System.Windows.Forms.ComboBox();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.lblAgenceCommunication = new System.Windows.Forms.Label();
            this.cbxAgenceEvenementiel = new System.Windows.Forms.ComboBox();
            this.lblAgenceEvenementiel = new System.Windows.Forms.Label();
            this.cbxEmploye = new System.Windows.Forms.ComboBox();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.txtObjectif = new System.Windows.Forms.TextBox();
            this.lblObjectif = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.pnlCampagne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(465, 50);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(364, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Modification d\'une campagne";
            // 
            // lblCampagne
            // 
            this.lblCampagne.AutoSize = true;
            this.lblCampagne.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCampagne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCampagne.Location = new System.Drawing.Point(208, 147);
            this.lblCampagne.Name = "lblCampagne";
            this.lblCampagne.Size = new System.Drawing.Size(289, 20);
            this.lblCampagne.TabIndex = 1;
            this.lblCampagne.Text = "Sélectionner une campagne à modifier :";
            // 
            // cbxCampagne
            // 
            this.cbxCampagne.FormattingEnabled = true;
            this.cbxCampagne.Location = new System.Drawing.Point(515, 149);
            this.cbxCampagne.Name = "cbxCampagne";
            this.cbxCampagne.Size = new System.Drawing.Size(254, 21);
            this.cbxCampagne.TabIndex = 2;
            this.cbxCampagne.SelectionChangeCommitted += new System.EventHandler(this.cbxCampagne_SelectionChangeCommitted);
            // 
            // pnlCampagne
            // 
            this.pnlCampagne.Controls.Add(this.cbxAgenceCommunication);
            this.pnlCampagne.Controls.Add(this.btnAnnul);
            this.pnlCampagne.Controls.Add(this.btnEnreg);
            this.pnlCampagne.Controls.Add(this.lblAgenceCommunication);
            this.pnlCampagne.Controls.Add(this.cbxAgenceEvenementiel);
            this.pnlCampagne.Controls.Add(this.lblAgenceEvenementiel);
            this.pnlCampagne.Controls.Add(this.cbxEmploye);
            this.pnlCampagne.Controls.Add(this.lblEmploye);
            this.pnlCampagne.Controls.Add(this.txtObjectif);
            this.pnlCampagne.Controls.Add(this.lblObjectif);
            this.pnlCampagne.Controls.Add(this.dtpDateFin);
            this.pnlCampagne.Controls.Add(this.lblDateFin);
            this.pnlCampagne.Controls.Add(this.dtpDateDebut);
            this.pnlCampagne.Controls.Add(this.lblDateDebut);
            this.pnlCampagne.Controls.Add(this.txtLibelle);
            this.pnlCampagne.Controls.Add(this.lblLibelle);
            this.pnlCampagne.Location = new System.Drawing.Point(146, 176);
            this.pnlCampagne.Name = "pnlCampagne";
            this.pnlCampagne.Size = new System.Drawing.Size(908, 462);
            this.pnlCampagne.TabIndex = 3;
            this.pnlCampagne.Visible = false;
            // 
            // cbxAgenceCommunication
            // 
            this.cbxAgenceCommunication.FormattingEnabled = true;
            this.cbxAgenceCommunication.Location = new System.Drawing.Point(369, 348);
            this.cbxAgenceCommunication.Name = "cbxAgenceCommunication";
            this.cbxAgenceCommunication.Size = new System.Drawing.Size(254, 21);
            this.cbxAgenceCommunication.TabIndex = 16;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(278, 400);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(105, 36);
            this.btnAnnul.TabIndex = 15;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnEnreg
            // 
            this.btnEnreg.Location = new System.Drawing.Point(546, 400);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(103, 36);
            this.btnEnreg.TabIndex = 14;
            this.btnEnreg.Text = "Enregistrer";
            this.btnEnreg.UseVisualStyleBackColor = true;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // lblAgenceCommunication
            // 
            this.lblAgenceCommunication.AutoSize = true;
            this.lblAgenceCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAgenceCommunication.Location = new System.Drawing.Point(24, 350);
            this.lblAgenceCommunication.Name = "lblAgenceCommunication";
            this.lblAgenceCommunication.Size = new System.Drawing.Size(327, 20);
            this.lblAgenceCommunication.TabIndex = 12;
            this.lblAgenceCommunication.Text = "Sélectionner une agence de communication :";
            // 
            // cbxAgenceEvenementiel
            // 
            this.cbxAgenceEvenementiel.FormattingEnabled = true;
            this.cbxAgenceEvenementiel.Location = new System.Drawing.Point(369, 301);
            this.cbxAgenceEvenementiel.Name = "cbxAgenceEvenementiel";
            this.cbxAgenceEvenementiel.Size = new System.Drawing.Size(254, 21);
            this.cbxAgenceEvenementiel.TabIndex = 11;
            // 
            // lblAgenceEvenementiel
            // 
            this.lblAgenceEvenementiel.AutoSize = true;
            this.lblAgenceEvenementiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAgenceEvenementiel.Location = new System.Drawing.Point(47, 303);
            this.lblAgenceEvenementiel.Name = "lblAgenceEvenementiel";
            this.lblAgenceEvenementiel.Size = new System.Drawing.Size(304, 20);
            this.lblAgenceEvenementiel.TabIndex = 10;
            this.lblAgenceEvenementiel.Text = "Sélectionner une agence événementielle :";
            // 
            // cbxEmploye
            // 
            this.cbxEmploye.FormattingEnabled = true;
            this.cbxEmploye.Location = new System.Drawing.Point(369, 252);
            this.cbxEmploye.Name = "cbxEmploye";
            this.cbxEmploye.Size = new System.Drawing.Size(254, 21);
            this.cbxEmploye.TabIndex = 9;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmploye.Location = new System.Drawing.Point(160, 253);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(191, 20);
            this.lblEmploye.TabIndex = 8;
            this.lblEmploye.Text = "Sélectionner un employé :";
            // 
            // txtObjectif
            // 
            this.txtObjectif.Location = new System.Drawing.Point(369, 205);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(254, 20);
            this.txtObjectif.TabIndex = 7;
            // 
            // lblObjectif
            // 
            this.lblObjectif.AutoSize = true;
            this.lblObjectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblObjectif.Location = new System.Drawing.Point(218, 203);
            this.lblObjectif.Name = "lblObjectif";
            this.lblObjectif.Size = new System.Drawing.Size(133, 20);
            this.lblObjectif.TabIndex = 6;
            this.lblObjectif.Text = "Saisir un objectif :";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDateFin.Location = new System.Drawing.Point(369, 149);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(254, 26);
            this.dtpDateFin.TabIndex = 5;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateFin.Location = new System.Drawing.Point(135, 154);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(216, 20);
            this.lblDateFin.TabIndex = 4;
            this.lblDateFin.Text = "Sélectionner une date de fin :";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDateDebut.Location = new System.Drawing.Point(369, 94);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(254, 26);
            this.dtpDateDebut.TabIndex = 3;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateDebut.Location = new System.Drawing.Point(111, 99);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(240, 20);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Sélectionner une date de début :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(369, 45);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(254, 20);
            this.txtLibelle.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLibelle.Location = new System.Drawing.Point(230, 45);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(121, 20);
            this.lblLibelle.TabIndex = 0;
            this.lblLibelle.Text = "Saisir un libelle :";
            // 
            // FrmModifCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1331, 650);
            this.Controls.Add(this.pnlCampagne);
            this.Controls.Add(this.cbxCampagne);
            this.Controls.Add(this.lblCampagne);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmModifCampagne";
            this.Text = "Modification d\'une campagne";
            this.pnlCampagne.ResumeLayout(false);
            this.pnlCampagne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblCampagne;
        private System.Windows.Forms.ComboBox cbxCampagne;
        private System.Windows.Forms.Panel pnlCampagne;
        private System.Windows.Forms.Label lblObjectif;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblAgenceEvenementiel;
        private System.Windows.Forms.ComboBox cbxEmploye;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.TextBox txtObjectif;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Label lblAgenceCommunication;
        private System.Windows.Forms.ComboBox cbxAgenceEvenementiel;
        private System.Windows.Forms.ComboBox cbxAgenceCommunication;
    }
}