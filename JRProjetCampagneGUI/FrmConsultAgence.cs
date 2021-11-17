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
            dtgInfosAgences.Columns[8].Visible = false;
            dtgInfosAgences.Columns["UneVille"].Visible = false;
            dtgInfosAgences.Columns[9].DisplayIndex = 3;
            dtgInfosAgences.Columns[3].DisplayIndex = 4;
            dtgInfosAgences.Columns[4].DisplayIndex = 5;
            dtgInfosAgences.Columns[5].DisplayIndex = 6;
            dtgInfosAgences.Columns[6].DisplayIndex = 7;
            dtgInfosAgences.Columns[1].HeaderText = "Nom de l'agence";
            dtgInfosAgences.Columns[2].HeaderText = "Rue de l'agence";
            dtgInfosAgences.Columns[4].HeaderText = "Téléphone de l'agence";
            dtgInfosAgences.Columns[5].HeaderText = "Email de l'agence";
            dtgInfosAgences.Columns[6].HeaderText = "Site Web de l'agence";
            dtgInfosAgences.Columns[7].HeaderText = "Type de l'agence";
            dtgInfosAgences.Columns[9].HeaderText = "Ville de l'agence";
        }
    }
}
