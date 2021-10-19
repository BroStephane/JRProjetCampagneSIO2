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
        /// Affiche dans les combobox les différents données issues de la base de données
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
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            //configurer le format
            dtpDateDebut.Format = DateTimePickerFormat.Custom;
            dtpDateDebut.CustomFormat = "dd/MM/yyyy";
            dtpDateDebut.MinDate = DateTime.Today;
            dtpDateFin.Format = DateTimePickerFormat.Custom;
            dtpDateFin.CustomFormat = "dd/MM/yyyy";
            dtpDateFin.MinDate = DateTime.Today;

            //configurer la date minimun 
            

        }

        /// <summary>
        /// Envoie les valeurs saisie par l'utilisateurs dans le CampagneBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCampagne_Click(object sender, EventArgs e)
        {
            string dtpDebut = dtpDateDebut.Text.Trim();
            string dtpFin = dtpDateFin.Text.Trim();
            txtLibelle.Text = txtLibelle.Text.Trim();
            txtObjectif.Text = txtObjectif.Text.Trim();
            string msgErr = "";
            int idChoixEmploye = 0;
            int idChoixAgenceEvenementiel = 0;
            int idChoixAgenceCommunication = 0;

            if (txtLibelle.Text == string.Empty)
            {
                msgErr += "Veuillez saisir un libelle\n";
            }
            if (dtpDebut == "")
            {
                msgErr += "Veuillez sélectionner une date de début\n";
            }
            if (dtpFin == "")
            {
                msgErr += "Veuillez sélectionner une date de fin\n";
            }
            if (dtpDateDebut.Value > dtpDateFin.Value)
            {
                msgErr += "La date de début ne doit pas être supérieur à la date de fin\n";
            }
            if (txtObjectif.Text == string.Empty)
            {
                msgErr += "Veuiller saisir un objectif\n";
            }
            if (cbxEmploye.SelectedIndex == -1)
            {
                msgErr += "Veuillez sélectionner un employé\n";
            }
            else
            {
                idChoixEmploye = (int)cbxEmploye.SelectedValue;
            }
            if (cbxAgenceEvenementiel.SelectedIndex == -1)
            {
                msgErr += "Veuillez sélectionner une agence évènementielle\n";
            }
            else
            {
                idChoixAgenceEvenementiel = (int)cbxAgenceEvenementiel.SelectedValue;
            }
            if (cbxAgenceCommunication.SelectedIndex == -1)
            {
                msgErr += "Veuillez sélectionner une agence de communication\n";
            }
            else
            {
                idChoixAgenceCommunication = (int)cbxAgenceCommunication.SelectedValue;
            }
            if (msgErr != "")
            {
                MessageBox.Show(msgErr, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime dtpDateDeDebut = Convert.ToDateTime(dtpDebut);
                    DateTime dtpDateDeFin = Convert.ToDateTime(dtpFin);
                    int nb = CampagneManager.GetInstance().CreateCampagne(txtLibelle.Text, dtpDateDeDebut, dtpDateDeFin, txtObjectif.Text, idChoixEmploye, idChoixAgenceEvenementiel, idChoixAgenceCommunication);

                    if (nb == 0)
                    {
                        MessageBox.Show("Problème grave : l'ajout de la campagne n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }
                    else
                    {
                        MessageBox.Show("Ajout de la campagne réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLibelle.Text = "";
                        dtpDateDebut.Value = DateTime.Today;
                        dtpDateFin.Value = DateTime.Today;
                        txtObjectif.Text = "";
                        cbxEmploye.SelectedItem = null;
                        cbxAgenceEvenementiel.SelectedItem = null;
                        cbxAgenceCommunication.SelectedItem = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.MinDate = dtpDateDebut.Value;
        }
    }
}
