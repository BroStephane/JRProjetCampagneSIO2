
namespace JRProjetCampagneGUI
{
    partial class FrmConsultAgence
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
            this.dtgInfosAgences = new System.Windows.Forms.DataGridView();
            this.btnObtenirInfos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosAgences)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(510, 97);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(233, 31);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Liste des agences";
            // 
            // dtgInfosAgences
            // 
            this.dtgInfosAgences.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgInfosAgences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfosAgences.Location = new System.Drawing.Point(243, 193);
            this.dtgInfosAgences.Name = "dtgInfosAgences";
            this.dtgInfosAgences.Size = new System.Drawing.Size(743, 245);
            this.dtgInfosAgences.TabIndex = 4;
            // 
            // btnObtenirInfos
            // 
            this.btnObtenirInfos.Location = new System.Drawing.Point(536, 524);
            this.btnObtenirInfos.Name = "btnObtenirInfos";
            this.btnObtenirInfos.Size = new System.Drawing.Size(162, 33);
            this.btnObtenirInfos.TabIndex = 5;
            this.btnObtenirInfos.Text = "Afficher les informations";
            this.btnObtenirInfos.UseVisualStyleBackColor = true;
            this.btnObtenirInfos.Click += new System.EventHandler(this.btnObtenirInfos_Click_1);
            // 
            // FrmConsultAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1229, 630);
            this.Controls.Add(this.btnObtenirInfos);
            this.Controls.Add(this.dtgInfosAgences);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmConsultAgence";
            this.Text = "Consultation des agences";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosAgences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dtgInfosAgences;
        private System.Windows.Forms.Button btnObtenirInfos;
    }
}