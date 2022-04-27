using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRProjetCampagneBLL;
using JRProjetCampagneBO;

namespace JRProjetCampagneGUI
{
    public partial class FrmModifEvenement : Form
    {
        public FrmModifEvenement()
        {
            InitializeComponent();

            pnlAjout.Visible = false;

            Charger();
            


        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlAjout.Visible = true;
            int id = (int)cbxEvenement.SelectedValue;

            Evenement unEv = EvenementManager.GetInstance().GetUnEvenement(id);

            cbxCampagne.SelectedValue = unEv.UneCampagne.Id;
            cbxTheme.SelectedValue = unEv.UnTheme.Id;
            dtpDebut.Value = unEv.DateDebut;
            dtpFin.Value = unEv.DateFin;


        }

        private void btnEnvoie_Click(object sender, EventArgs e)
        {
            //Instanciation des données saisie par l'utilisateur
            string dateDebut = dtpDebut.Text.Trim();
            string dateFin = dtpFin.Text.Trim();
            string msgErr = "";

            if (dateDebut == "")
            {
                msgErr += "\nVeuillez sélectionner une date de début";

            }
            if (dateFin == "")
            {
                msgErr += "\nVeuillez sélectionner une date de fin";

            }

            //Convertie le format string en DateTime
            DateTime laDateDeb = Convert.ToDateTime(dateDebut);
            DateTime laDateFin = Convert.ToDateTime(dateFin);

            //Récupere les id des cbx
            int id = (int)cbxEvenement.SelectedValue;
            int idCampagne = 0;
            int idTheme = 0;

            if (cbxTheme.SelectedIndex == -1)
            {
                msgErr += "\nVeuillez sélectionner un Thême";

            }
            else
            {
                idTheme = (int)cbxTheme.SelectedValue;
            }
            if (cbxCampagne.SelectedIndex == -1)
            {
                msgErr += "\nVeuillez sélectionner une Campagne";

            }
            else
            {
                idCampagne = (int)cbxCampagne.SelectedValue;

            }

            try
            {
                if (dtpFin.Value > dtpDebut.Value.AddDays(3))
                {
                    msgErr += "Veuillez saisir une date de fin inférieur à 3 jours suivant la date de début";
                }

                if (msgErr == "")
                {
                    int nb = EvenementManager.GetInstance().UpdateEvenement(id, laDateDeb, laDateFin, idTheme, idCampagne);
                    if (nb == 0)
                    {
                        MessageBox.Show("Erreur lors de la modification de l'évènement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La modification de l'évènement à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxCampagne.SelectedItem = null;
                        cbxTheme.SelectedItem = null;
                        pnlAjout.Visible = false;                        
                        Charger();

                    }
                }
                else
                {
                    MessageBox.Show(msgErr, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Charger()
        {
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
                throw;
            }
            try
            {
                cbxTheme.DisplayMember = "libelle";
                cbxTheme.ValueMember = "id";
                cbxTheme.DataSource = ThemeManager.GetInstance().GetThemes();
                cbxTheme.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            try
            {
                //Remplie la comboBox des valeurs de la table Theme
                cbxCampagne.DisplayMember = "libelle";
                cbxCampagne.ValueMember = "id";
                cbxCampagne.DataSource = CampagneManager.GetInstance().GetCampagnes();
                cbxCampagne.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }


    }
}
