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

            }catch(Exception exception)
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
            if (nom == "")
            {
                MessageBox.Show("Veuillez saisir un nom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(mail == "")
            {
                MessageBox.Show("Veuillez saisir un mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (rue == "")
            {
                MessageBox.Show("Veuillez saisir une rue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (cbxVille.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez saisir une ville", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 numInsee = (int)cbxVille.SelectedValue;
            }
            if (cbxCategVIP.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez saisir une catégorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 categVIP = (int)cbxCategVIP.SelectedValue;
            }

            

            try
            {
                if(rue != "" && mail != "" && nom != "" && numInsee != 0 && categVIP != 0)
                {
                    

                    int nb = VIPManager.GetInstance().AddVIP(nom, rue, mail, numInsee, categVIP);
                    if (nb == 0)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du VIP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("l'ajout du VIP à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
