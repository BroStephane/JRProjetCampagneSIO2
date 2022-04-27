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

namespace JRProjetCampagneGUI
{
    public partial class FrmAjoutMessage : Form
    {
        public FrmAjoutMessage()
        {
            InitializeComponent();

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

                cbxCategVIP.DisplayMember = "libelle";
                cbxCategVIP.ValueMember = "id";
                cbxCategVIP.DataSource = CategorieVIPManager.GetInstance().GetLesCategsVIP();
                cbxCategVIP.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            //Determine le format de la dateTimePanel
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd MMMMM yyyy";
            dtpDate.MinDate = DateTime.Today;

           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void FrmAjoutMessage_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Instanciation des données saisie par l'utilisateur
            string date = dtpDate.Text.Trim();
            string message = txtContenu.Text.Trim();
            string msgErr = "";

            if (date == "")
            {
                msgErr += "\nVeuillez sélectionner une date de début";

            }

            if (message == "")
            {
                msgErr += "\nVeuillez saisir le contenu du message";
            }


            //Convertie le format string en DateTime
            DateTime laDate = Convert.ToDateTime(date);


            //Récupere les id des cbx

            int idEvenement = 0;
            int idCategorieVIP = 0;


            if (cbxEvenement.SelectedIndex == -1)
            {
                msgErr += "\nVeuillez sélectionner un événement";

            }
            else
            {
                idEvenement = (int)cbxEvenement.SelectedValue;
            }
            if (cbxCategVIP.SelectedIndex == -1)
            {
                msgErr += "\nVeuillez sélectionner une catégorie de VIP";

            }
            else
            {
                idCategorieVIP = (int)cbxCategVIP.SelectedValue;

            }

            try
            {

                if (msgErr == "")
                {
                    int nb = MessageManager.GetInstance().AddMessage(message, laDate, idCategorieVIP, idEvenement);

                    if (nb == 0)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du message", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("l'ajout du message à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxCategVIP.SelectedItem = null;
                        cbxEvenement.SelectedItem = null;
                        txtContenu.Clear();
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
    }
}
