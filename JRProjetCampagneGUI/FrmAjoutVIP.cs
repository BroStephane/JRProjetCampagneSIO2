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
    public partial class FrmAjoutVIP : Form
    {
        public FrmAjoutVIP()
        {
            InitializeComponent();

            try
            {
                cbxVille.DisplayMember = "nom";
                cbxVille.ValueMember = "numero_insee";
                cbxVille.DataSource = VilleManager.GetInstance().GetLaVille();
                cbxVille.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string mail = txtMail.Text.Trim();
            string rue = txtRue.Text.Trim();
            int numInsee = 0;
            int categVIP = 0;
            string msgErr = "";
            if (nom == "")
            {
                msgErr += "\n Veuillez saisir un nom";

            }
            if (mail == "")
            {
                msgErr += "\n Veuillez saisir un mail";


            }
            if (rue == "")
            {
                msgErr += "\n Veuillez saisir une rue";


            }

            if (cbxVille.SelectedIndex == -1)
            {
                msgErr += "\n Veuillez saisir une Ville";

            }
            else
            {
                numInsee = (int)cbxVille.SelectedValue;
            }
            if (cbxCategVIP.SelectedIndex == -1)
            {
                msgErr += "\n Veuillez saisir une Catégorie";

            }
            else
            {
                categVIP = (int)cbxCategVIP.SelectedValue;
            }



            try
            {
                if (rue != "" && mail != "" && nom != "" && numInsee != 0 && categVIP != 0)
                {


                    int nb = VIPManager.GetInstance().AddVIP(nom, rue, mail, numInsee, categVIP);
                    if (nb == 0)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du VIP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("l'ajout du VIP à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxVille.SelectedItem = null;
                        cbxCategVIP.SelectedItem = null;
                        txtMail.Clear();
                        txtNom.Clear();
                        txtRue.Clear();

                    }
                }
                else
                {
                    MessageBox.Show(msgErr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
