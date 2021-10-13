
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.txtSiteWebArtiste = new System.Windows.Forms.TextBox();
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.lblSiteWebArtiste = new System.Windows.Forms.Label();
            this.lblCourantArtistique = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValiderAjoutArtiste
            // 
            this.btnValiderAjoutArtiste.Location = new System.Drawing.Point(398, 302);
            this.btnValiderAjoutArtiste.Name = "btnValiderAjoutArtiste";
            this.btnValiderAjoutArtiste.Size = new System.Drawing.Size(75, 23);
            this.btnValiderAjoutArtiste.TabIndex = 0;
            this.btnValiderAjoutArtiste.Text = "Valider";
            this.btnValiderAjoutArtiste.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Location = new System.Drawing.Point(156, 40);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(121, 20);
            this.txtNomArtiste.TabIndex = 2;
            // 
            // txtSiteWebArtiste
            // 
            this.txtSiteWebArtiste.Location = new System.Drawing.Point(156, 94);
            this.txtSiteWebArtiste.Name = "txtSiteWebArtiste";
            this.txtSiteWebArtiste.Size = new System.Drawing.Size(121, 20);
            this.txtSiteWebArtiste.TabIndex = 3;
            // 
            // lblNomArtiste
            // 
            this.lblNomArtiste.AutoSize = true;
            this.lblNomArtiste.Location = new System.Drawing.Point(63, 46);
            this.lblNomArtiste.Name = "lblNomArtiste";
            this.lblNomArtiste.Size = new System.Drawing.Size(85, 13);
            this.lblNomArtiste.TabIndex = 4;
            this.lblNomArtiste.Text = "Nom de l\'artiste :";
            // 
            // lblSiteWebArtiste
            // 
            this.lblSiteWebArtiste.AutoSize = true;
            this.lblSiteWebArtiste.Location = new System.Drawing.Point(44, 101);
            this.lblSiteWebArtiste.Name = "lblSiteWebArtiste";
            this.lblSiteWebArtiste.Size = new System.Drawing.Size(104, 13);
            this.lblSiteWebArtiste.TabIndex = 5;
            this.lblSiteWebArtiste.Text = "Site web de l\'artiste :";
            // 
            // lblCourantArtistique
            // 
            this.lblCourantArtistique.AutoSize = true;
            this.lblCourantArtistique.Location = new System.Drawing.Point(25, 152);
            this.lblCourantArtistique.Name = "lblCourantArtistique";
            this.lblCourantArtistique.Size = new System.Drawing.Size(123, 13);
            this.lblCourantArtistique.TabIndex = 6;
            this.lblCourantArtistique.Text = "Choix courant artistique :";
            // 
            // FrmAjoutArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCourantArtistique);
            this.Controls.Add(this.lblSiteWebArtiste);
            this.Controls.Add(this.lblNomArtiste);
            this.Controls.Add(this.txtSiteWebArtiste);
            this.Controls.Add(this.txtNomArtiste);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnValiderAjoutArtiste);
            this.Name = "FrmAjoutArtiste";
            this.Text = "FrmAjoutArtiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderAjoutArtiste;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.TextBox txtSiteWebArtiste;
        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.Label lblSiteWebArtiste;
        private System.Windows.Forms.Label lblCourantArtistique;
    }
}