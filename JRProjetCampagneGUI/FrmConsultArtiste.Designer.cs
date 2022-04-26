
namespace JRProjetCampagneGUI
{
    partial class FrmConsultArtiste
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
            this.dtgInfosArtiste = new System.Windows.Forms.DataGridView();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnObtenirInfos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfosArtiste
            // 
            this.dtgInfosArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfosArtiste.Location = new System.Drawing.Point(243, 193);
            this.dtgInfosArtiste.Name = "dtgInfosArtiste";
            this.dtgInfosArtiste.Size = new System.Drawing.Size(743, 245);
            this.dtgInfosArtiste.TabIndex = 5;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(470, 78);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(299, 31);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Consultation des artiste";
            // 
            // btnObtenirInfos
            // 
            this.btnObtenirInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnObtenirInfos.Location = new System.Drawing.Point(536, 524);
            this.btnObtenirInfos.Name = "btnObtenirInfos";
            this.btnObtenirInfos.Size = new System.Drawing.Size(162, 23);
            this.btnObtenirInfos.TabIndex = 7;
            this.btnObtenirInfos.Text = "Obtenir les informations";
            this.btnObtenirInfos.UseVisualStyleBackColor = false;
            this.btnObtenirInfos.Click += new System.EventHandler(this.btnObtenirInfos_Click);
            // 
            // FrmConsultArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1229, 630);
            this.Controls.Add(this.btnObtenirInfos);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dtgInfosArtiste);
            this.Name = "FrmConsultArtiste";
            this.Text = "FrmConsultArtiste";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosArtiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInfosArtiste;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnObtenirInfos;
    }
}