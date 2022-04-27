
namespace JRProjetCampagneGUI
{
    partial class FrmModifArtiste
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
            this.cbxArtiste = new System.Windows.Forms.ComboBox();
            this.lblCourantArtistique = new System.Windows.Forms.Label();
            this.pnlArtiste = new System.Windows.Forms.Panel();
            this.btnValiderAjoutArtiste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiteWebArtiste = new System.Windows.Forms.TextBox();
            this.lblSiteWebArtiste = new System.Windows.Forms.Label();
            this.cbxCourantArtistique = new System.Windows.Forms.ComboBox();
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.pnlArtiste.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitre.Location = new System.Drawing.Point(516, 97);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(305, 31);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Modification d\'un artiste ";
            // 
            // cbxArtiste
            // 
            this.cbxArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxArtiste.FormattingEnabled = true;
            this.cbxArtiste.Location = new System.Drawing.Point(655, 201);
            this.cbxArtiste.Name = "cbxArtiste";
            this.cbxArtiste.Size = new System.Drawing.Size(196, 24);
            this.cbxArtiste.TabIndex = 9;
            this.cbxArtiste.SelectionChangeCommitted += new System.EventHandler(this.cbxArtiste_SelectionChangeCommitted);
            // 
            // lblCourantArtistique
            // 
            this.lblCourantArtistique.AutoSize = true;
            this.lblCourantArtistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCourantArtistique.Location = new System.Drawing.Point(437, 201);
            this.lblCourantArtistique.Name = "lblCourantArtistique";
            this.lblCourantArtistique.Size = new System.Drawing.Size(212, 20);
            this.lblCourantArtistique.TabIndex = 10;
            this.lblCourantArtistique.Text = "Choisisez l\'artiste à modifier :";
            // 
            // pnlArtiste
            // 
            this.pnlArtiste.Controls.Add(this.btnValiderAjoutArtiste);
            this.pnlArtiste.Controls.Add(this.label1);
            this.pnlArtiste.Controls.Add(this.txtSiteWebArtiste);
            this.pnlArtiste.Controls.Add(this.lblSiteWebArtiste);
            this.pnlArtiste.Controls.Add(this.cbxCourantArtistique);
            this.pnlArtiste.Controls.Add(this.lblNomArtiste);
            this.pnlArtiste.Controls.Add(this.txtNomArtiste);
            this.pnlArtiste.Location = new System.Drawing.Point(408, 261);
            this.pnlArtiste.Name = "pnlArtiste";
            this.pnlArtiste.Size = new System.Drawing.Size(498, 388);
            this.pnlArtiste.TabIndex = 11;
            // 
            // btnValiderAjoutArtiste
            // 
            this.btnValiderAjoutArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValiderAjoutArtiste.Location = new System.Drawing.Point(199, 317);
            this.btnValiderAjoutArtiste.Name = "btnValiderAjoutArtiste";
            this.btnValiderAjoutArtiste.Size = new System.Drawing.Size(89, 40);
            this.btnValiderAjoutArtiste.TabIndex = 18;
            this.btnValiderAjoutArtiste.Text = "Valider";
            this.btnValiderAjoutArtiste.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choix courant artistique :";
            // 
            // txtSiteWebArtiste
            // 
            this.txtSiteWebArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSiteWebArtiste.Location = new System.Drawing.Point(247, 136);
            this.txtSiteWebArtiste.Name = "txtSiteWebArtiste";
            this.txtSiteWebArtiste.Size = new System.Drawing.Size(196, 23);
            this.txtSiteWebArtiste.TabIndex = 14;
            // 
            // lblSiteWebArtiste
            // 
            this.lblSiteWebArtiste.AutoSize = true;
            this.lblSiteWebArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSiteWebArtiste.Location = new System.Drawing.Point(64, 136);
            this.lblSiteWebArtiste.Name = "lblSiteWebArtiste";
            this.lblSiteWebArtiste.Size = new System.Drawing.Size(154, 20);
            this.lblSiteWebArtiste.TabIndex = 16;
            this.lblSiteWebArtiste.Text = "Site web de l\'artiste :";
            // 
            // cbxCourantArtistique
            // 
            this.cbxCourantArtistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxCourantArtistique.FormattingEnabled = true;
            this.cbxCourantArtistique.Location = new System.Drawing.Point(247, 207);
            this.cbxCourantArtistique.Name = "cbxCourantArtistique";
            this.cbxCourantArtistique.Size = new System.Drawing.Size(196, 24);
            this.cbxCourantArtistique.TabIndex = 12;
            // 
            // lblNomArtiste
            // 
            this.lblNomArtiste.AutoSize = true;
            this.lblNomArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomArtiste.Location = new System.Drawing.Point(92, 66);
            this.lblNomArtiste.Name = "lblNomArtiste";
            this.lblNomArtiste.Size = new System.Drawing.Size(126, 20);
            this.lblNomArtiste.TabIndex = 15;
            this.lblNomArtiste.Text = "Nom de l\'artiste :";
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomArtiste.Location = new System.Drawing.Point(247, 66);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(196, 23);
            this.txtNomArtiste.TabIndex = 13;
            // 
            // FrmModifArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1476, 661);
            this.Controls.Add(this.pnlArtiste);
            this.Controls.Add(this.lblCourantArtistique);
            this.Controls.Add(this.cbxArtiste);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmModifArtiste";
            this.Text = "Modification un artiste";
            this.pnlArtiste.ResumeLayout(false);
            this.pnlArtiste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbxArtiste;
        private System.Windows.Forms.Label lblCourantArtistique;
        private System.Windows.Forms.Panel pnlArtiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiteWebArtiste;
        private System.Windows.Forms.Label lblSiteWebArtiste;
        private System.Windows.Forms.ComboBox cbxCourantArtistique;
        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.Button btnValiderAjoutArtiste;
    }
}