
namespace JRProjetCampagneGUI
{
    partial class FrmConsultVIP
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
            this.dtgVIP = new System.Windows.Forms.DataGridView();
            this.btnConsult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVIP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(370, 90);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(191, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Liste des VIP";
            // 
            // dtgVIP
            // 
            this.dtgVIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgVIP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVIP.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgVIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVIP.Location = new System.Drawing.Point(167, 200);
            this.dtgVIP.Name = "dtgVIP";
            this.dtgVIP.Size = new System.Drawing.Size(608, 228);
            this.dtgVIP.TabIndex = 1;
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(390, 505);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(150, 45);
            this.btnConsult.TabIndex = 2;
            this.btnConsult.Text = "Afficher  les informations";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // FrmConsultVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(969, 647);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.dtgVIP);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmConsultVIP";
            this.Text = "Consultation des VIP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dtgVIP;
        private System.Windows.Forms.Button btnConsult;
    }
}