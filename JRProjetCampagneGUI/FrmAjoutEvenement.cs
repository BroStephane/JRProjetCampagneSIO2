using JRProjetCampagneBO;
using JRProjetEvenementBLL;
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
            dtpDebut.CustomFormat = "yyyy/MM/dd ";
            dtpDebut.MinDate = DateTime.Today;

            //Determine le format de la dateTimePanel
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "yyyy/MM/dd ";
            dtpFin.MinDate = DateTime.Today;



        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            //Instanciation des données saisie par l'utilisateur
            string dateDebut = dtpDebut.Text.Trim();
            string dateFin = dtpFin.Text.Trim();

            //Convertie le format string en DateTime
            DateTime laDateDeb = Convert.ToDateTime(dateDebut);
            DateTime laDateFin = Convert.ToDateTime(dateFin);

            //Récupere les id des cbx
            int idTheme = (int)cbxTheme.SelectedValue;
            int idCampagne = (int)cbxCampagne.SelectedValue;


            try
            {
                int nb = EvenementManager.GetInstance().AddEvenement(laDateDeb, laDateFin, idTheme, idCampagne);
                if (nb == 0)
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'évènement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("l'ajout de l'évènement à été effectué", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
