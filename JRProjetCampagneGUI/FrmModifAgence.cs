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
    public partial class FrmModifAgence : Form
    {
        char sonType;
        /// <summary>
        /// Modifie l'agence en utilisant la méthode ModifAgence, après avoir vérifier que tout les champs de saisies et la combobox sont bien remplies.
        /// </summary>
        public FrmModifAgence()
        {
            //Affichage dans le combobox Agence
            InitializeComponent();
            cbxAgenceMod.DataSource = AgenceManager.GetInstance().GetAgences();
            cbxAgenceMod.DisplayMember = "Identite";
            cbxAgenceMod.ValueMember = "id";
            cbxVilleMod.DataSource = VilleManager.GetInstance().GetLaVille();
            cbxVilleMod.DisplayMember = "nom";
            cbxVilleMod.ValueMember = "numero_insee";
        }

        private void cbxAgenceMod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxAgenceMod.Visible = false;
            lblAgenceMod.Visible = false;
            pnlAgenceMod.Visible = true;
            int idAgence = (int)cbxAgenceMod.SelectedValue;
            Agence uneAgence = AgenceManager.GetInstance().GetUneAgenceId(idAgence);
            txtNomMod.Text = uneAgence.Nom;
            txtRueMod.Text = uneAgence.Rue;
            txtSiteMod.Text = uneAgence.SiteWeb;
            txtTelephoneMod.Text = uneAgence.Telephone;
            cbxVilleMod.Text = uneAgence.leNomVille;
            txtEmailMod.Text = uneAgence.EmailContact;
            if (uneAgence.TypeAgence == 'E')
            {
                rdbEMod.Checked = true;
            }
            else
            {
                rdbCMod.Checked = true;
            }
        }

        private void btnEnregMod_Click(object sender, EventArgs e)
        {
            int nb = 0;
            txtNomMod.Text = txtNomMod.Text.Trim();
            txtRueMod.Text = txtRueMod.Text.Trim();
            txtSiteMod.Text = txtSiteMod.Text.Trim();
            txtTelephoneMod.Text = txtTelephoneMod.Text.Trim();
            cbxVilleMod.Text = cbxVilleMod.Text.Trim();
            txtEmailMod.Text = txtEmailMod.Text.Trim();
            string msgErr = "";
            //Test pour voir si une zone de texte est vide ou non, message d'erreur retourné sinon
            if (txtNomMod.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un nom");
            }
            if (txtNomMod.Text == string.Empty)
            {
                msgErr += "Veuillez saisir un nom pour l'agence\n";
            }
            if (txtRueMod.Text == string.Empty)
            {
                msgErr += "Veuillez saisir une rue pour l'agence\n";
            }
            if (txtTelephoneMod.Text == string.Empty)
            {
                msgErr += "Veuillez saisir un téléphone pour l'agence\n";
            }
            if (txtEmailMod.Text == string.Empty)
            {
                msgErr += "Veuillez saisir une adresse mail pour l'agence\n";
            }
            if (txtSiteMod.Text == string.Empty)
            {
                msgErr += "Veuillez saisir un site pour l'agence\n";
            }
            if (rdbEMod.Checked == false && rdbCMod.Checked == false)
            {
                msgErr += "Veuillez sélectionner un type pour l'agence\n";
            }
            if (cbxVilleMod.SelectedItem == null)
            {
                msgErr += "Veuillez sélectionner une ville pour l'agence\n";
            }
            if (msgErr != "")
            {
                MessageBox.Show(msgErr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (rdbEMod.Checked == true)
                    {
                        sonType = 'E';
                    }
                    else
                    {
                        sonType = 'C';
                    }
                    //La valeur récupérer dans le combobox sera retournée par idAgence
                    int idAgence = (int)cbxAgenceMod.SelectedValue;
                    //La valeur récupérer dans le combobox sera retournée par le numero_insee
                    int numero_insee = (int)cbxVilleMod.SelectedValue;
                    nb = AgenceManager.GetInstance().UpdateAgence(idAgence, txtNomMod.Text, txtRueMod.Text, numero_insee, txtTelephoneMod.Text, txtEmailMod.Text, txtSiteMod.Text, sonType);
                    //Si la modification est réalisé nb = 1 et donc un messageBox s'affiche disant que la modification a été réalisé, sinon il dira qu'il n'a pas été réalisé
                    if (nb != 0)
                    {
                        MessageBox.Show("Modification de l'agence réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problème grave : la modification de l'agence n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
