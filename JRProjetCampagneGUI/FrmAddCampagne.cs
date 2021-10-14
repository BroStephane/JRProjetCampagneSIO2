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
    public partial class FrmAddCampagne : Form
    {
        public FrmAddCampagne()
        {
            InitializeComponent();
            
            //combobox d'employé
            cbxEmploye.DisplayMember = "Identite";
            cbxEmploye.ValueMember = "id";
            cbxEmploye.DataSource = EmployeManager.GetInstance().GetLesEmployes();

            //combobox des agences evenementiel
            cbxAgenceEvenementiel.DisplayMember = "nom";
            cbxAgenceEvenementiel.ValueMember = "id";
            cbxAgenceEvenementiel.DataSource = AgenceManager.GetInstance().GetLesAgencesEvenementiels();

            cbxAgenceCommunication.DisplayMember = "nom";
            cbxAgenceCommunication.ValueMember = "id";
            cbxAgenceCommunication.DataSource = AgenceManager.GetInstance().GetLesAgencesCommunications();

        
            //créer un nouveau contrôleur DateTimePicker et l'initialiser
            DateTimePicker dtpDateDebut = new DateTimePicker();
            DateTimePicker dtpDateFin = new DateTimePicker();

            //configurer le format
            dtpDateDebut.CustomFormat = "yyyy/MM/dd";
            dtpDateDebut.Format = DateTimePickerFormat.Custom;
            dtpDateFin.CustomFormat = "yyyy/MM/dd";
            dtpDateFin.Format = DateTimePickerFormat.Custom;

            //configurer la date minimun 
            dtpDateDebut.MinDate = DateTime.Today;
            dtpDateFin.MinDate = DateTime.Today;

        }

        private void btnAddCampagne_Click(object sender, EventArgs e)
        {
            string dtpDebut = dtpDateDebut.Text;
            string dtpFin = dtpDateFin.Text;

            DateTime dtpDateDeDebut = Convert.ToDateTime(dtpDebut);
            DateTime dtpDateDeFin = Convert.ToDateTime(dtpFin);

            txtLibelle.Text = txtLibelle.Text.Trim();
            txtObjectif.Text = txtObjectif.Text.Trim();
            int idChoixEmploye = (int)cbxEmploye.SelectedValue;
            int idChoixAgenceEvenementiel = (int)cbxAgenceEvenementiel.SelectedValue;
            int idChoixAgenceCommunication = (int)cbxAgenceCommunication.SelectedValue;

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
                //int nb = CampagneManager.GetInstance().CreerCampagne(txtLibelle.Text, dtpDateDebut.Text, dtpDateFin.Text, txtObjectif.Text, idChoixCateg);
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
    }
}
