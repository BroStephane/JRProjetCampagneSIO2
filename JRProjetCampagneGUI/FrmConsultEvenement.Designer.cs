
namespace JRProjetCampagneGUI
{
    partial class FrmConsultEvenement
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
            this.dtgEvenement = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(393, 71);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(301, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Liste des événements";
            // 
            // dtgEvenement
            // 
            this.dtgEvenement.AllowUserToAddRows = false;
            this.dtgEvenement.AllowUserToDeleteRows = false;
            this.dtgEvenement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgEvenement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvenement.Location = new System.Drawing.Point(315, 151);
            this.dtgEvenement.Name = "dtgEvenement";
            this.dtgEvenement.ReadOnly = true;
            this.dtgEvenement.Size = new System.Drawing.Size(440, 390);
            this.dtgEvenement.TabIndex = 1;
            this.dtgEvenement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(441, 619);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(160, 29);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Obtenir les événements";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // FrmConsultEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1161, 739);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.dtgEvenement);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmConsultEvenement";
            this.Text = "Consultation des événements";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvenement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dtgEvenement;
        private System.Windows.Forms.Button btnGet;
    }
}