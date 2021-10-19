namespace JRProjetCampagneGUI
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesAgencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunÉvénementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunArtisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneCampagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneAgenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunVIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitre = new System.Windows.Forms.Label();
            this.consultationDesCampagnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.suppressionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationDesAgencesToolStripMenuItem,
            this.consultationDesCampagnesToolStripMenuItem});
            this.consultationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // consultationDesAgencesToolStripMenuItem
            // 
            this.consultationDesAgencesToolStripMenuItem.Name = "consultationDesAgencesToolStripMenuItem";
            this.consultationDesAgencesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.consultationDesAgencesToolStripMenuItem.Text = "Consultation des agences";
            this.consultationDesAgencesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesAgencesToolStripMenuItem_Click_1);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ajoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunÉvénementToolStripMenuItem,
            this.ajoutDunArtisteToolStripMenuItem,
            this.ajoutDuneCampagneToolStripMenuItem,
            this.ajoutDuneAgenceToolStripMenuItem,
            this.ajoutDunVIPToolStripMenuItem});
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            // 
            // ajoutDunÉvénementToolStripMenuItem
            // 
            this.ajoutDunÉvénementToolStripMenuItem.Name = "ajoutDunÉvénementToolStripMenuItem";
            this.ajoutDunÉvénementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajoutDunÉvénementToolStripMenuItem.Text = "Ajout d\'un événement";
            this.ajoutDunÉvénementToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunÉvénementToolStripMenuItem_Click);
            // 
            // ajoutDunArtisteToolStripMenuItem
            // 
            this.ajoutDunArtisteToolStripMenuItem.Name = "ajoutDunArtisteToolStripMenuItem";
            this.ajoutDunArtisteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajoutDunArtisteToolStripMenuItem.Text = "Ajout d\'un artiste";
            this.ajoutDunArtisteToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunArtisteToolStripMenuItem_Click);
            // 
            // ajoutDuneCampagneToolStripMenuItem
            // 
            this.ajoutDuneCampagneToolStripMenuItem.Name = "ajoutDuneCampagneToolStripMenuItem";
            this.ajoutDuneCampagneToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajoutDuneCampagneToolStripMenuItem.Text = "Ajout d\'une campagne";
            this.ajoutDuneCampagneToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneCampagneToolStripMenuItem_Click);
            // 
            // ajoutDuneAgenceToolStripMenuItem
            // 
            this.ajoutDuneAgenceToolStripMenuItem.Name = "ajoutDuneAgenceToolStripMenuItem";
            this.ajoutDuneAgenceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajoutDuneAgenceToolStripMenuItem.Text = "Ajout d\'une agence";
            this.ajoutDuneAgenceToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneAgenceToolStripMenuItem_Click);
            // 
            // ajoutDunVIPToolStripMenuItem
            // 
            this.ajoutDunVIPToolStripMenuItem.Name = "ajoutDunVIPToolStripMenuItem";
            this.ajoutDunVIPToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajoutDunVIPToolStripMenuItem.Text = "Ajout d\'un VIP";
            this.ajoutDunVIPToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunVIPToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.modificationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.suppressionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(372, 66);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(527, 33);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Bienvenue sur le menu des campagnes";
            // 
            // consultationDesCampagnesToolStripMenuItem
            // 
            this.consultationDesCampagnesToolStripMenuItem.Name = "consultationDesCampagnesToolStripMenuItem";
            this.consultationDesCampagnesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.consultationDesCampagnesToolStripMenuItem.Text = "Consultation des campagnes";
            this.consultationDesCampagnesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesCampagnesToolStripMenuItem_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 603);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunÉvénementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunArtisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneAgenceToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem ajoutDunVIPToolStripMenuItem;
       
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneCampagneToolStripMenuItem;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ToolStripMenuItem consultationDesAgencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesCampagnesToolStripMenuItem;
    }
}

