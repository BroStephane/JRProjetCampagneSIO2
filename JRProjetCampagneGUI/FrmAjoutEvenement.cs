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
    public partial class FrmAjoutEvenement : Form
    {
        public FrmAjoutEvenement()
        {
            InitializeComponent();

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
            //Determine le format de la dateTimePanel
            dtpDebut.Format = DateTimePickerFormat.Custom;
            dtpDebut.CustomFormat = "dd MMMMM yyyy";
            dtpDebut.MinDate = DateTime.Today;

            //Determine le format de la dateTimePanel
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dd MMMMM yyyy ";
            dtpFin.MinDate = DateTime.Today;



        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
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
                    int nb = EvenementManager.GetInstance().AddEvenement(laDateDeb, laDateFin, idTheme, idCampagne);
                    if (nb == 0)
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'évènement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("l'ajout de l'évènement à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxCampagne.SelectedItem = null;
                        cbxTheme.SelectedItem = null;
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

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpFin.MinDate = dtpDebut.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
