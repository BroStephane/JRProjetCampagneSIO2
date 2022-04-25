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
    public partial class FrmConsultAgence : Form
    {
        /// <summary>
        /// Consultation des Agences contenu dans GetAgences
        /// </summary>
        public FrmConsultAgence()
        {
            InitializeComponent();
        }

        private void btnObtenirInfos_Click_1(object sender, EventArgs e)
        {
            dtgInfosAgences.DataSource = AgenceManager.GetInstance().GetAgences();
            dtgInfosAgences.Columns[0].Visible = false;
            dtgInfosAgences.Columns[7].Visible = false;
        }
    }
}
