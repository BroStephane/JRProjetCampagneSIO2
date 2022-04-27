
namespace JRProjetCampagneGUI
{
    partial class FrmModifEvenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifEvenement));
            this.pnlAjout = new System.Windows.Forms.Panel();
            this.btnEnvoie = new System.Windows.Forms.Button();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.cbxCampagne = new System.Windows.Forms.ComboBox();
            this.lblCampagne = new System.Windows.Forms.Label();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblModif = new System.Windows.Forms.Label();
            this.cbxEvenement = new System.Windows.Forms.ComboBox();
            this.pnlAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAjout
            // 
            this.pnlAjout.Controls.Add(this.btnEnvoie);
            this.pnlAjout.Controls.Add(this.dtpDebut);
            this.pnlAjout.Controls.Add(this.dtpFin);
            this.pnlAjout.Controls.Add(this.btnEnvoyer);
            this.pnlAjout.Controls.Add(this.lblDateFin);
            this.pnlAjout.Controls.Add(this.lblDateDebut);
            this.pnlAjout.Controls.Add(this.cbxCampagne);
            this.pnlAjout.Controls.Add(this.lblCampagne);
            this.pnlAjout.Controls.Add(this.cbxTheme);
            this.pnlAjout.Controls.Add(this.lblTheme);
            this.pnlAjout.Location = new System.Drawing.Point(152, 321);
            this.pnlAjout.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(830, 342);
            this.pnlAjout.TabIndex = 4;
            // 
            // btnEnvoie
            // 
            this.btnEnvoie.Location = new System.Drawing.Point(574, 283);
            this.btnEnvoie.Name = "btnEnvoie";
            this.btnEnvoie.Size = new System.Drawing.Size(100, 34);
            this.btnEnvoie.TabIndex = 12;
            this.btnEnvoie.Text = "Envoyer";
            this.btnEnvoie.UseVisualStyleBackColor = true;
            this.btnEnvoie.Click += new System.EventHandler(this.btnEnvoie_Click);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebut.Location = new System.Drawing.Point(409, 154);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(265, 23);
            this.dtpDebut.TabIndex = 11;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(409, 227);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(265, 23);
            this.dtpFin.TabIndex = 10;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.Location = new System.Drawing.Point(451, 352);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(100, 41);
            this.btnEnvoyer.TabIndex = 9;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(229, 228);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(99, 20);
            this.lblDateFin.TabIndex = 7;
            this.lblDateFin.Text = "Date de fin : ";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(205, 154);
            this.lblDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(123, 20);
            this.lblDateDebut.TabIndex = 5;
            this.lblDateDebut.Text = "Date de début : ";
            // 
            // cbxCampagne
            // 
            this.cbxCampagne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampagne.FormattingEnabled = true;
            this.cbxCampagne.Location = new System.Drawing.Point(409, 93);
            this.cbxCampagne.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCampagne.Name = "cbxCampagne";
            this.cbxCampagne.Size = new System.Drawing.Size(265, 24);
            this.cbxCampagne.TabIndex = 4;
            // 
            // lblCampagne
            // 
            this.lblCampagne.AutoSize = true;
            this.lblCampagne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampagne.Location = new System.Drawing.Point(229, 94);
            this.lblCampagne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampagne.Name = "lblCampagne";
            this.lblCampagne.Size = new System.Drawing.Size(99, 20);
            this.lblCampagne.TabIndex = 3;
            this.lblCampagne.Text = "Campagne : ";
            // 
            // cbxTheme
            // 
            this.cbxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Location = new System.Drawing.Point(409, 25);
            this.cbxTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(265, 24);
            this.cbxTheme.TabIndex = 2;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(147, 29);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(181, 20);
            this.lblTheme.TabIndex = 1;
            this.lblTheme.Text = "Thème de l\'événement : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(400, 122);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(357, 31);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Modification d\'un événement";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblModif
            // 
            this.lblModif.AutoSize = true;
            this.lblModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModif.Location = new System.Drawing.Point(157, 232);
            this.lblModif.Name = "lblModif";
            this.lblModif.Size = new System.Drawing.Size(344, 20);
            this.lblModif.TabIndex = 5;
            this.lblModif.Text = "Veuillez sélectionner un événement à modifier : ";
            // 
            // cbxEvenement
            // 
            this.cbxEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvenement.FormattingEnabled = true;
            this.cbxEvenement.Location = new System.Drawing.Point(539, 231);
            this.cbxEvenement.Name = "cbxEvenement";
            this.cbxEvenement.Size = new System.Drawing.Size(448, 24);
            this.cbxEvenement.TabIndex = 6;
            this.cbxEvenement.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // FrmModifEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 778);
            this.Controls.Add(this.cbxEvenement);
            this.Controls.Add(this.lblModif);
            this.Controls.Add(this.pnlAjout);
            this.Controls.Add(this.lblTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModifEvenement";
            this.Text = "FrmModifEvenement";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjout;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.ComboBox cbxCampagne;
        private System.Windows.Forms.Label lblCampagne;
        private System.Windows.Forms.ComboBox cbxTheme;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblModif;
        private System.Windows.Forms.ComboBox cbxEvenement;
        private System.Windows.Forms.Button btnEnvoie;
    }
}