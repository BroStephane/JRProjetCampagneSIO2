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
    public partial class FrmModifCampagne : Form
    {
        /// <summary>
        /// Affiche dans les combobox les différents données issues de la base de données
        /// </summary>
        public FrmModifCampagne()
        {
            InitializeComponent();
            try
            {
                //combobox de la campagne
                cbxCampagne.DisplayMember = "Libelle";
                cbxCampagne.ValueMember = "id";
                cbxCampagne.DataSource = CampagneManager.GetInstance().GetCampagnes();
                cbxCampagne.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            try
            {   
                //combobox de l'employé
                cbxEmploye.DisplayMember = "Identite";
                cbxEmploye.ValueMember = "id";
                cbxEmploye.DataSource = EmployeManager.GetInstance().GetLesEmployes();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            try
            {
                //combobox de l'agence évènementiel
                cbxAgenceEvenementiel.DisplayMember = "nom";
                cbxAgenceEvenementiel.ValueMember = "id";
                cbxAgenceEvenementiel.DataSource = AgenceManager.GetInstance().GetLesAgencesEvenementiels();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            try
            {
                //combobox de l'agence de communication
                cbxAgenceCommunication.DisplayMember = "nom";
                cbxAgenceCommunication.ValueMember = "id";
                cbxAgenceCommunication.DataSource = AgenceManager.GetInstance().GetLesAgencesCommunications();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Met dans les champs et combobox les caractéristiques de la campagne choisie lors de sa sélection dans le combobox campagne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCampagne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxCampagne.Visible = false;
            lblCampagne.Visible = false;

            int idChoixCampagne = (int)cbxCampagne.SelectedValue;
            Campagne uneCampagne = CampagneManager.GetInstance().GetUneCampagneId(idChoixCampagne);

            txtLibelle.Text = uneCampagne.Libelle;
            dtpDateDebut.Value = uneCampagne.DateDebut;
            dtpDateFin.Value = uneCampagne.DateFin;
            txtObjectif.Text = uneCampagne.Objectif;
            cbxEmploye.Text = uneCampagne.unEmployeIdentite;
            cbxAgenceEvenementiel.Text = uneCampagne.uneAgenceEvenementielNom;
            cbxAgenceCommunication.Text = uneCampagne.uneAgenceCommunicationNom;

            pnlCampagne.Visible = true;
        }

        /// <summary>
        /// Envoie les valeurs saisie par l'utilisateur dans le CampagneBLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnreg_Click(object sender, EventArgs e)
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
                    int idChoixCampagne = (int)cbxCampagne.SelectedValue;
                    int nb = CampagneManager.GetInstance().UpdateCampagne(idChoixCampagne,txtLibelle.Text, dtpDateDeDebut, dtpDateDeFin, txtObjectif.Text, idChoixEmploye, idChoixAgenceEvenementiel, idChoixAgenceCommunication);

                    if (nb == 0)
                    {
                        MessageBox.Show("Problème grave : la modification du client n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Modification du client réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        pnlCampagne.Visible = false;
                        cbxCampagne.Visible = true;
                        lblCampagne.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Lorsque le bouton Annuler est cliqué, le panel disparait et le combobox de la campagne avec son label réapparait 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnul_Click(object sender, EventArgs e)
        {
            pnlCampagne.Visible = false;
            cbxCampagne.Visible = true;
            lblCampagne.Visible = true;
        }
    }
}
