using JRProjetCampagneBLL;
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

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string mail = txtMail.Text.Trim();
            string rue = txtRue.Text.Trim();
            if(nom == "")
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

            int numInsee = (int)cbxVille.SelectedValue;

            try
            {

                //int nb = VIPManager.GetInstance().AddVIP(nom, rue,mail, numInsee);
                //if (nb == 0)
                //{
                //    MessageBox.Show("Erreur lors de l'ajout du VIP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    MessageBox.Show("l'ajout du VIP à été effectué", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                //}



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
