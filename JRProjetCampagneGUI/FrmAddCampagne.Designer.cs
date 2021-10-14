
namespace JRProjetCampagneGUI
{
    partial class FrmAddCampagne
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
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblObjectif = new System.Windows.Forms.Label();
            this.txtObjectif = new System.Windows.Forms.TextBox();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.cbxEmploye = new System.Windows.Forms.ComboBox();
            this.btnAddCampagne = new System.Windows.Forms.Button();
            this.lblAgenceEvenementiel = new System.Windows.Forms.Label();
            this.cbxAgenceEvenementiel = new System.Windows.Forms.ComboBox();
            this.lblAgenceCommunication = new System.Windows.Forms.Label();
            this.cbxAgenceCommunication = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(452, 60);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(226, 27);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'une campagne";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(353, 176);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(90, 13);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Ajouter un libelle :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(457, 173);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(221, 20);
            this.txtLibelle.TabIndex = 2;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(457, 225);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(221, 20);
            this.dtpDateDebut.TabIndex = 3;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(289, 231);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(162, 13);
            this.lblDateDebut.TabIndex = 4;
            this.lblDateDebut.Text = "Sélectionner une date de début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(305, 291);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(146, 13);
            this.lblDateFin.TabIndex = 5;
            this.lblDateFin.Text = "Sélectionner une date de fin :";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(458, 285);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(220, 20);
            this.dtpDateFin.TabIndex = 6;
            // 
            // lblObjectif
            // 
            this.lblObjectif.AutoSize = true;
            this.lblObjectif.Location = new System.Drawing.Point(353, 347);
            this.lblObjectif.Name = "lblObjectif";
            this.lblObjectif.Size = new System.Drawing.Size(98, 13);
            this.lblObjectif.TabIndex = 7;
            this.lblObjectif.Text = "Ajouter un objectif :";
            // 
            // txtObjectif
            // 
            this.txtObjectif.Location = new System.Drawing.Point(458, 347);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(220, 20);
            this.txtObjectif.TabIndex = 8;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(322, 411);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(129, 13);
            this.lblEmploye.TabIndex = 9;
            this.lblEmploye.Text = "Sélectionner un employé :";
            // 
            // cbxEmploye
            // 
            this.cbxEmploye.FormattingEnabled = true;
            this.cbxEmploye.Location = new System.Drawing.Point(458, 408);
            this.cbxEmploye.Name = "cbxEmploye";
            this.cbxEmploye.Size = new System.Drawing.Size(220, 21);
            this.cbxEmploye.TabIndex = 10;
            // 
            // btnAddCampagne
            // 
            this.btnAddCampagne.Location = new System.Drawing.Point(508, 587);
            this.btnAddCampagne.Name = "btnAddCampagne";
            this.btnAddCampagne.Size = new System.Drawing.Size(122, 31);
            this.btnAddCampagne.TabIndex = 11;
            this.btnAddCampagne.Text = "Enregistrer";
            this.btnAddCampagne.UseVisualStyleBackColor = true;
            this.btnAddCampagne.Click += new System.EventHandler(this.btnAddCampagne_Click);
            // 
            // lblAgenceEvenementiel
            // 
            this.lblAgenceEvenementiel.AutoSize = true;
            this.lblAgenceEvenementiel.Location = new System.Drawing.Point(237, 467);
            this.lblAgenceEvenementiel.Name = "lblAgenceEvenementiel";
            this.lblAgenceEvenementiel.Size = new System.Drawing.Size(206, 13);
            this.lblAgenceEvenementiel.TabIndex = 12;
            this.lblAgenceEvenementiel.Text = "Sélectionner une agence événementielle :";
            // 
            // cbxAgenceEvenementiel
            // 
            this.cbxAgenceEvenementiel.FormattingEnabled = true;
            this.cbxAgenceEvenementiel.Location = new System.Drawing.Point(458, 464);
            this.cbxAgenceEvenementiel.Name = "cbxAgenceEvenementiel";
            this.cbxAgenceEvenementiel.Size = new System.Drawing.Size(220, 21);
            this.cbxAgenceEvenementiel.TabIndex = 13;
            // 
            // lblAgenceCommunication
            // 
            this.lblAgenceCommunication.AutoSize = true;
            this.lblAgenceCommunication.Location = new System.Drawing.Point(230, 513);
            this.lblAgenceCommunication.Name = "lblAgenceCommunication";
            this.lblAgenceCommunication.Size = new System.Drawing.Size(221, 13);
            this.lblAgenceCommunication.TabIndex = 14;
            this.lblAgenceCommunication.Text = "Sélectionner une agence de communication :";
            // 
            // cbxAgenceCommunication
            // 
            this.cbxAgenceCommunication.FormattingEnabled = true;
            this.cbxAgenceCommunication.Location = new System.Drawing.Point(458, 510);
            this.cbxAgenceCommunication.Name = "cbxAgenceCommunication";
            this.cbxAgenceCommunication.Size = new System.Drawing.Size(220, 21);
            this.cbxAgenceCommunication.TabIndex = 15;
            // 
            // FrmAddCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 663);
            this.Controls.Add(this.cbxAgenceCommunication);
            this.Controls.Add(this.lblAgenceCommunication);
            this.Controls.Add(this.cbxAgenceEvenementiel);
            this.Controls.Add(this.lblAgenceEvenementiel);
            this.Controls.Add(this.btnAddCampagne);
            this.Controls.Add(this.cbxEmploye);
            this.Controls.Add(this.lblEmploye);
            this.Controls.Add(this.txtObjectif);
            this.Controls.Add(this.lblObjectif);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAddCampagne";
            this.Text = "Ajouter une campagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblObjectif;
        private System.Windows.Forms.TextBox txtObjectif;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.ComboBox cbxEmploye;
        private System.Windows.Forms.Button btnAddCampagne;
        private System.Windows.Forms.Label lblAgenceEvenementiel;
        private System.Windows.Forms.ComboBox cbxAgenceEvenementiel;
        private System.Windows.Forms.Label lblAgenceCommunication;
        private System.Windows.Forms.ComboBox cbxAgenceCommunication;
    }
}