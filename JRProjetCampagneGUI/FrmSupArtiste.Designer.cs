
namespace JRProjetCampagneGUI
{
    partial class FrmSupArtiste
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
            this.btnSup = new System.Windows.Forms.Button();
            this.cbxArtiste = new System.Windows.Forms.ComboBox();
            this.lblArtiste = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(642, 460);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(99, 39);
            this.btnSup.TabIndex = 7;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // cbxArtiste
            // 
            this.cbxArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArtiste.FormattingEnabled = true;
            this.cbxArtiste.Location = new System.Drawing.Point(500, 315);
            this.cbxArtiste.Name = "cbxArtiste";
            this.cbxArtiste.Size = new System.Drawing.Size(440, 24);
            this.cbxArtiste.TabIndex = 6;
            this.cbxArtiste.SelectionChangeCommitted += new System.EventHandler(this.cbxArtiste_SelectionChangeCommitted);
            // 
            // lblArtiste
            // 
            this.lblArtiste.AutoSize = true;
            this.lblArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtiste.Location = new System.Drawing.Point(202, 319);
            this.lblArtiste.Name = "lblArtiste";
            this.lblArtiste.Size = new System.Drawing.Size(236, 20);
            this.lblArtiste.TabIndex = 5;
            this.lblArtiste.Text = "Veuillez sélectionner un artiste : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(405, 78);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(336, 36);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Suppression d\'un artiste";
            // 
            // FrmSupArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1141, 646);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.cbxArtiste);
            this.Controls.Add(this.lblArtiste);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmSupArtiste";
            this.Text = "Suppression d\'un artiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.ComboBox cbxArtiste;
        private System.Windows.Forms.Label lblArtiste;
        private System.Windows.Forms.Label lblTitre;
    }
}