
namespace JRProjetCampagneGUI
{
    partial class FrmConsultCampagne
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
            this.dtgCampagne = new System.Windows.Forms.DataGridView();
            this.btnAfficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCampagne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(476, 43);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(320, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Consulter les campagnes";
            // 
            // dtgCampagne
            // 
            this.dtgCampagne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCampagne.Location = new System.Drawing.Point(204, 116);
            this.dtgCampagne.Name = "dtgCampagne";
            this.dtgCampagne.Size = new System.Drawing.Size(888, 370);
            this.dtgCampagne.TabIndex = 1;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(531, 531);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(212, 42);
            this.btnAfficher.TabIndex = 2;
            this.btnAfficher.Text = "Afficher les informations";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // FrmConsultCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1349, 633);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtgCampagne);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmConsultCampagne";
            this.Text = "Consultation des campagnes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCampagne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dtgCampagne;
        private System.Windows.Forms.Button btnAfficher;
    }
}