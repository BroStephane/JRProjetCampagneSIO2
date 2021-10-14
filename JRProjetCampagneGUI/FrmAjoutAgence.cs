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
    public partial class FrmAjoutAgence : Form
    {
        char sonType;

        public FrmAjoutAgence()
        {
            InitializeComponent();

            try
            {
                //Affichage dans le combobox Ville
                cbxVilleAgence.DisplayMember = "nom";
                cbxVilleAgence.ValueMember = "numero_insee";
                cbxVilleAgence.DataSource = VilleManager.GetInstance().GetLaVille();
                cbxVilleAgence.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnregAgence_Click_1(object sender, EventArgs e)
        {
            int nb = 0;
            string nomAgence = txtNomAgence.Text.Trim();
            string rueAgence = txtRueAgence.Text.Trim();
            string telphoneAgence = txtTelephoneAgence.Text.Trim();
            string emailAgence = txtEmailAgence.Text.Trim();
            string siteAgence = txtSiteAgence.Text.Trim();
            //Test pour voir si une zone de texte est vide ou non
            if (txtNomAgence.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un nom pour l'agence");
            }
            else if (txtRueAgence.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir une rue pour l'agence");
            }
            else if (txtTelephoneAgence.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un téléphone pour l'agence");
            }
            else if (txtEmailAgence.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir une adresse mail pour l'agence");
            }
            else if (txtSiteAgence.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un site pour l'agence");
            }
            else if (rdbTypeAgenceE.Checked == false && rdbTypeAgenceC.Checked == false)
            {
                MessageBox.Show("Veuillez sélectionner un type pour l'agence");
            }
            else if (cbxVilleAgence.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une ville pour l'agence");
            }
            else
            {
                if (rdbTypeAgenceE.Checked == true)
                {
                    sonType = 'E';
                }
                else if (rdbTypeAgenceC.Checked == true)
                {
                    sonType = 'C';
                }
                //La valeur récupérer dans le combobox sera retournée par le numero_insee
                int numero_insee = (int)cbxVilleAgence.SelectedValue;
                //nb sera égal à 1 grâce à l'ajout d'une agence
                nb = AgenceManager.GetInstance().AddAgence(txtNomAgence.Text, txtRueAgence.Text, txtTelephoneAgence.Text, txtEmailAgence.Text, txtSiteAgence.Text, sonType, numero_insee);
                //Si l'ajout est réalisé nb = 1 et donc un messageBox s'affiche disant que l'ajout a été réalisé, sinon il dira qu'il n'a pas été réalisé
                if (nb == 0)
                {
                    MessageBox.Show("Problème grave : l'ajout n'a pas été réalisé");
                }
                else
                {
                    MessageBox.Show("L'ajout de l'agence a été réalisé");
                }
            }
        }
    }
}
