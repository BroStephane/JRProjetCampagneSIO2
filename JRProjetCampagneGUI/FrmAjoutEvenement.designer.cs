
namespace JRProjetCampagneGUI
{
    partial class FrmAjoutEvenement
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.pnlAjout = new System.Windows.Forms.Panel();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.cbxCampagne = new System.Windows.Forms.ComboBox();
            this.lblCampagne = new System.Windows.Forms.Label();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            this.pnlAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(685, 116);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(274, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'un événement";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(114, 69);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(181, 20);
            this.lblTheme.TabIndex = 1;
            this.lblTheme.Text = "Thème de l\'événement : ";
            // 
            // pnlAjout
            // 
            this.pnlAjout.Controls.Add(this.dtpDebut);
            this.pnlAjout.Controls.Add(this.dtpFin);
            this.pnlAjout.Controls.Add(this.btnEnvoyer);
            this.pnlAjout.Controls.Add(this.lblDateFin);
            this.pnlAjout.Controls.Add(this.lblDateDebut);
            this.pnlAjout.Controls.Add(this.cbxCampagne);
            this.pnlAjout.Controls.Add(this.lblCampagne);
            this.pnlAjout.Controls.Add(this.cbxTheme);
            this.pnlAjout.Controls.Add(this.lblTheme);
            this.pnlAjout.Location = new System.Drawing.Point(408, 192);
            this.pnlAjout.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(989, 729);
            this.pnlAjout.TabIndex = 2;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebut.Location = new System.Drawing.Point(376, 198);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(265, 23);
            this.dtpDebut.TabIndex = 11;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(376, 271);
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
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(196, 273);
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
            this.lblDateDebut.Location = new System.Drawing.Point(172, 200);
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
            this.cbxCampagne.Location = new System.Drawing.Point(376, 137);
            this.cbxCampagne.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCampagne.Name = "cbxCampagne";
            this.cbxCampagne.Size = new System.Drawing.Size(265, 24);
            this.cbxCampagne.TabIndex = 4;
            // 
            // lblCampagne
            // 
            this.lblCampagne.AutoSize = true;
            this.lblCampagne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampagne.Location = new System.Drawing.Point(196, 138);
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
            this.cbxTheme.Location = new System.Drawing.Point(376, 69);
            this.cbxTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(265, 24);
            this.cbxTheme.TabIndex = 2;
            // 
            // FrmAjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1776, 1004);
            this.Controls.Add(this.pnlAjout);
            this.Controls.Add(this.lblTitre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutEvenement";
            this.Text = "Ajout d\'un événement";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Panel pnlAjout;
        private System.Windows.Forms.ComboBox cbxCampagne;
        private System.Windows.Forms.Label lblCampagne;
        private System.Windows.Forms.ComboBox cbxTheme;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}