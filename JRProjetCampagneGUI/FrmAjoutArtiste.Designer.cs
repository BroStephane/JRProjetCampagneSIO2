
namespace JRProjetCampagneGUI
{
    partial class FrmAjoutArtiste
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
            this.btnValiderAjoutArtiste = new System.Windows.Forms.Button();
            this.cbxCourantArtistique = new System.Windows.Forms.ComboBox();
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.txtSiteWebArtiste = new System.Windows.Forms.TextBox();
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.lblSiteWebArtiste = new System.Windows.Forms.Label();
            this.lblCourantArtistique = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValiderAjoutArtiste
            // 
            this.btnValiderAjoutArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValiderAjoutArtiste.Location = new System.Drawing.Point(704, 473);
            this.btnValiderAjoutArtiste.Name = "btnValiderAjoutArtiste";
            this.btnValiderAjoutArtiste.Size = new System.Drawing.Size(89, 40);
            this.btnValiderAjoutArtiste.TabIndex = 0;
            this.btnValiderAjoutArtiste.Text = "Valider";
            this.btnValiderAjoutArtiste.UseVisualStyleBackColor = true;
            this.btnValiderAjoutArtiste.Click += new System.EventHandler(this.btnValiderAjoutArtiste_Click);
            // 
            // cbxCourantArtistique
            // 
            this.cbxCourantArtistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxCourantArtistique.FormattingEnabled = true;
            this.cbxCourantArtistique.Location = new System.Drawing.Point(672, 331);
            this.cbxCourantArtistique.Name = "cbxCourantArtistique";
            this.cbxCourantArtistique.Size = new System.Drawing.Size(196, 24);
            this.cbxCourantArtistique.TabIndex = 1;
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomArtiste.Location = new System.Drawing.Point(672, 190);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(196, 23);
            this.txtNomArtiste.TabIndex = 2;
            // 
            // txtSiteWebArtiste
            // 
            this.txtSiteWebArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSiteWebArtiste.Location = new System.Drawing.Point(672, 260);
            this.txtSiteWebArtiste.Name = "txtSiteWebArtiste";
            this.txtSiteWebArtiste.Size = new System.Drawing.Size(196, 23);
            this.txtSiteWebArtiste.TabIndex = 3;
            // 
            // lblNomArtiste
            // 
            this.lblNomArtiste.AutoSize = true;
            this.lblNomArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomArtiste.Location = new System.Drawing.Point(517, 190);
            this.lblNomArtiste.Name = "lblNomArtiste";
            this.lblNomArtiste.Size = new System.Drawing.Size(126, 20);
            this.lblNomArtiste.TabIndex = 4;
            this.lblNomArtiste.Text = "Nom de l\'artiste :";
            // 
            // lblSiteWebArtiste
            // 
            this.lblSiteWebArtiste.AutoSize = true;
            this.lblSiteWebArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSiteWebArtiste.Location = new System.Drawing.Point(489, 260);
            this.lblSiteWebArtiste.Name = "lblSiteWebArtiste";
            this.lblSiteWebArtiste.Size = new System.Drawing.Size(154, 20);
            this.lblSiteWebArtiste.TabIndex = 5;
            this.lblSiteWebArtiste.Text = "Site web de l\'artiste :";
            // 
            // lblCourantArtistique
            // 
            this.lblCourantArtistique.AutoSize = true;
            this.lblCourantArtistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCourantArtistique.Location = new System.Drawing.Point(470, 331);
            this.lblCourantArtistique.Name = "lblCourantArtistique";
            this.lblCourantArtistique.Size = new System.Drawing.Size(183, 20);
            this.lblCourantArtistique.TabIndex = 6;
            this.lblCourantArtistique.Text = "Choix courant artistique :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(570, 65);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(226, 31);
            this.lblTitre.TabIndex = 7;
            this.lblTitre.Text = "Ajouter un artiste ";
            // 
            // FrmAjoutArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1476, 661);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblCourantArtistique);
            this.Controls.Add(this.lblSiteWebArtiste);
            this.Controls.Add(this.lblNomArtiste);
            this.Controls.Add(this.txtSiteWebArtiste);
            this.Controls.Add(this.txtNomArtiste);
            this.Controls.Add(this.cbxCourantArtistique);
            this.Controls.Add(this.btnValiderAjoutArtiste);
            this.Name = "FrmAjoutArtiste";
            this.Text = "Ajouter un artiste";
            this.Load += new System.EventHandler(this.FrmAjoutArtiste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderAjoutArtiste;
        private System.Windows.Forms.ComboBox cbxCourantArtistique;
        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.TextBox txtSiteWebArtiste;
        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.Label lblSiteWebArtiste;
        private System.Windows.Forms.Label lblCourantArtistique;
        private System.Windows.Forms.Label lblTitre;
    }
}