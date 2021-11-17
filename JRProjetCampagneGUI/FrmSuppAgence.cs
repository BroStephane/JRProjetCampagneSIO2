using JRProjetCampagneBLL;
using JRProjetCampagneBO;
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
    public partial class FrmSuppAgence : Form
    {
        public FrmSuppAgence()
        {
            InitializeComponent();
            pnlAgenceSupp.Visible = false;
            chargerEvenement();
        }

        private void cbxAgenceMod_SelectionChangeCommitted(object sender, EventArgs e)
        {
           pnlAgenceSupp.Visible = true;
        }

        private void btnSuppSupp_Click(object sender, EventArgs e)
        {
            int idAgence = (int)cbxAgenceSupp.SelectedValue;
            int nb = AgenceManager.GetInstance().DeleteAgence(idAgence);
            try
            {
                //Si l'ajout est réalisé nb = 1 et donc un messageBox s'affiche disant que l'ajout a été réalisé, sinon il dira qu'il n'a pas été réalisé
                if (nb == 0)
                {
                    MessageBox.Show("Problème grave : la Suppression de l'agence n'a pas été réalisé");
                }
            }
            catch
            {
                MessageBox.Show("Suppression de l'agence réalisé");
                cbxAgenceSupp.SelectedItem = null;
                chargerEvenement();
            }
        }
        public void chargerEvenement()
        {
            pnlAgenceSupp.Visible = false;
            try
            {
                cbxAgenceSupp.DisplayMember = "Identite";
                cbxAgenceSupp.ValueMember = "id";
                cbxAgenceSupp.DataSource = AgenceManager.GetInstance().GetAgences();
                cbxAgenceSupp.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
