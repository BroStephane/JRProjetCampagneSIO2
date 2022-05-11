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
    public partial class FrmSupEvenement : Form
    {
        public FrmSupEvenement()
        {
            InitializeComponent();
                btnSup.Visible = false;
                chargerEvenement();

        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            int idEvenement = (int)cbxEvenement.SelectedValue;

            int nb = EvenementManager.GetInstance().DeleteEvenement(idEvenement);

            if (nb == 0)
            {
                MessageBox.Show("Erreur lors de la suppression de l'évènement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("la suppression de l'évènement à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxEvenement.SelectedItem = null;
                chargerEvenement();
            }

        }

        private void cbxEvenement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSup.Visible = true;
        }

        public void chargerEvenement()
        {
            btnSup.Visible = false;
            try
            {
                cbxEvenement.DisplayMember = "leLib";
                cbxEvenement.ValueMember = "id";
                cbxEvenement.DataSource = EvenementManager.GetInstance().GetLesEvenements();
                cbxEvenement.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
