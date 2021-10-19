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
    public partial class FrmAjoutCampagne : Form
    {
        /// <summary>
        /// Affiche daans les combobox les différents données issues de la base de données
        /// </summary>
        public FrmAjoutCampagne()
        {
            InitializeComponent();

            try
            {
                //combobox d'employé
                cbxEmploye.DisplayMember = "Identite";
                cbxEmploye.ValueMember = "id";
                cbxEmploye.DataSource = EmployeManager.GetInstance().GetLesEmployes();
                cbxEmploye.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            try
            {
                //combobox des agences evenementielles
                cbxAgenceEvenementiel.DisplayMember = "nom";
                cbxAgenceEvenementiel.ValueMember = "id";
                cbxAgenceEvenementiel.DataSource = AgenceManager.GetInstance().GetLesAgencesEvenementiels();
                cbxAgenceEvenementiel.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            try
            {
                //combobox des agences de communications
                cbxAgenceCommunication.DisplayMember = "nom";
                cbxAgenceCommunication.ValueMember = "id";
                cbxAgenceCommunication.DataSource = AgenceManager.GetInstance().GetLesAgencesCommunications();
                cbxAgenceCommunication.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

           

            //configurer le format
            dtpDateDebut.Format = DateTimePickerFormat.Custom;
            dtpDateDebut.CustomFormat = "dd MMMMM yyyy";
            dtpDateDebut.MinDate = DateTime.Today;

            dtpDateFin.Format = DateTimePickerFormat.Custom;
            dtpDateFin.CustomFormat = "dd MMMMM yyyy";
            dtpDateFin.MinDate = DateTime.Today;

            //configurer la date minimun 



        }

        /// <summary>
        /// Envoie les valeurs saisie par l'utilsiateurs dans le CampagneBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCampagne_Click(object sender, EventArgs e)
        {
            string dtpDebut = dtpDateDebut.Text.Trim();
            string dtpFin = dtpDateFin.Text.Trim();
            int idChoixEmploye = 0;
            int idChoixAgenceEvenementiel = 0;
            int idChoixAgenceCommunication = 0;

            if (dtpDebut == "")
            {
                MessageBox.Show("Veuillez sélectionner une date de début", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtpFin == "")
            {
                MessageBox.Show("Veuillez sélectionner une date de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DateTime dtpDateDeDebut = Convert.ToDateTime(dtpDebut);
            DateTime dtpDateDeFin = Convert.ToDateTime(dtpFin);

            txtLibelle.Text = txtLibelle.Text.Trim();
            txtObjectif.Text = txtObjectif.Text.Trim();

            if (txtLibelle.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un libelle", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtObjectif.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un objectif", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpDateDebut.Text == string.Empty)
            {
                MessageBox.Show("Veuillez sélectionner une date de début", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpDateFin.Text == string.Empty)
            {
                MessageBox.Show("Veuillez sélectionner une date de fin", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbxEmploye.SelectedIndex == -1)
                {

                    MessageBox.Show("Veuillez sélectionner un employé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    idChoixEmploye = (int)cbxEmploye.SelectedValue;
                }

                if (cbxAgenceEvenementiel.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez sélectionner une agence évènementielle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    idChoixAgenceEvenementiel = (int)cbxAgenceEvenementiel.SelectedValue;
                }

                if (cbxAgenceCommunication.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez sélectionner une agence de communication", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    idChoixAgenceCommunication = (int)cbxAgenceCommunication.SelectedValue;
                }

                int nb = CampagneManager.GetInstance().CreateCampagne(txtLibelle.Text, dtpDateDeDebut, dtpDateDeFin, txtObjectif.Text, idChoixEmploye, idChoixAgenceEvenementiel, idChoixAgenceCommunication);

                if (nb == 0)
                {
                    MessageBox.Show("Problème grave : l'ajout de la campagne n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ajout du la campagne réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDateFin.MinDate = dtpDateDebut.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
