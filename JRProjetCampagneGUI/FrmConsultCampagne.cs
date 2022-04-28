using JRProjetCampagneBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRProjetCampagneGUI
{
    public partial class FrmConsultCampagne : Form
    {
        public FrmConsultCampagne()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            dtgCampagne.DataSource = CampagneManager.GetInstance().GetLesCampagnes();
            dtgCampagne.Columns[0].Visible = false;
            dtgCampagne.Columns[7].Visible = false;
            dtgCampagne.Columns[6].Visible = false;
            dtgCampagne.Columns[5].Visible = false;
            dtgCampagne.Columns[2].HeaderText = "Date de début";
            dtgCampagne.Columns[3].HeaderText = "Date de fin";
            dtgCampagne.Columns[8].HeaderText = "Employé";
            dtgCampagne.Columns[9].HeaderText = "Agence Evenementielle";
            dtgCampagne.Columns[10].HeaderText = "Agence de Communication";

        }
    }
}
