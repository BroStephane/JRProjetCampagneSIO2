
namespace JRProjetCampagneGUI
{
    partial class FrmAjoutMessage
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
            this.lblContenu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEvenement = new System.Windows.Forms.Label();
            this.lblCategVIP = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cbxEvenement = new System.Windows.Forms.ComboBox();
            this.cbxCategVIP = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtContenu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTitre.Location = new System.Drawing.Point(315, 23);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(276, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'un message";
            // 
            // lblContenu
            // 
            this.lblContenu.AutoSize = true;
            this.lblContenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenu.Location = new System.Drawing.Point(165, 140);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.Size = new System.Drawing.Size(173, 20);
            this.lblContenu.TabIndex = 1;
            this.lblContenu.Text = "Contenu du message : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(282, 331);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date : ";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenement.Location = new System.Drawing.Point(236, 378);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(102, 20);
            this.lblEvenement.TabIndex = 3;
            this.lblEvenement.Text = "Événement : ";
            // 
            // lblCategVIP
            // 
            this.lblCategVIP.AutoSize = true;
            this.lblCategVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategVIP.Location = new System.Drawing.Point(218, 433);
            this.lblCategVIP.Name = "lblCategVIP";
            this.lblCategVIP.Size = new System.Drawing.Size(120, 20);
            this.lblCategVIP.TabIndex = 4;
            this.lblCategVIP.Text = "Catégorie VIP : ";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(478, 483);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 44);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cbxEvenement
            // 
            this.cbxEvenement.FormattingEnabled = true;
            this.cbxEvenement.Location = new System.Drawing.Point(392, 377);
            this.cbxEvenement.Name = "cbxEvenement";
            this.cbxEvenement.Size = new System.Drawing.Size(199, 21);
            this.cbxEvenement.TabIndex = 6;
            // 
            // cbxCategVIP
            // 
            this.cbxCategVIP.FormattingEnabled = true;
            this.cbxCategVIP.Location = new System.Drawing.Point(470, 432);
            this.cbxCategVIP.Name = "cbxCategVIP";
            this.cbxCategVIP.Size = new System.Drawing.Size(121, 21);
            this.cbxCategVIP.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(422, 330);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(169, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // txtContenu
            // 
            this.txtContenu.Location = new System.Drawing.Point(387, 140);
            this.txtContenu.Multiline = true;
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(385, 155);
            this.txtContenu.TabIndex = 9;
            // 
            // FrmAjoutMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 625);
            this.Controls.Add(this.txtContenu);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbxCategVIP);
            this.Controls.Add(this.cbxEvenement);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblCategVIP);
            this.Controls.Add(this.lblEvenement);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblContenu);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAjoutMessage";
            this.Text = "Ajout d\'un message";
            this.Load += new System.EventHandler(this.FrmAjoutMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblContenu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEvenement;
        private System.Windows.Forms.Label lblCategVIP;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cbxEvenement;
        private System.Windows.Forms.ComboBox cbxCategVIP;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtContenu;
    }
}