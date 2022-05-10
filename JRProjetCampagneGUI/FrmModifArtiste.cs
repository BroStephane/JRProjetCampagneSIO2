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
    public partial class FrmModifArtiste : Form
    {
        public FrmModifArtiste()
        {
            InitializeComponent();
            Charger();
            pnlModifArtiste.Visible = false;


        }

        private void cbxArtiste_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int idChoixArtiste = (int)cbxArtiste.SelectedValue;
            Artiste unArtiste = ArtisteManager.GetInstance().GetUnArtisteId(idChoixArtiste);

            txtNomArtiste.Text = unArtiste.Nom;
            txtSiteWebArtiste.Text = unArtiste.SitWeb;
            cbxArtiste.Text = unArtiste.LibelleCourant;

            pnlModifArtiste.Visible = true;
        }

        private void btnValiderModifArtiste_Click(object sender, EventArgs e)
        {
            string nom = txtNomArtiste.Text.Trim();
            string siteWeb = txtSiteWebArtiste.Text.Trim();
            string msgErr = "";
            int idChoixCourant = 0;

            //Test pour voir si une zone de texte est vide ou non, message d'erreur retourné sinon
            if (txtNomArtiste.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un nom");
            }
            if (txtNomArtiste.Text == string.Empty)
            {
                msgErr += "Veuillez saisir un nom pour l'artiste \n";
            }
            if (txtSiteWebArtiste.Text == string.Empty)
            {
                msgErr += "Veuillez saisir un site web pour l'artiste \n";
            }
            if (cbxArtiste.SelectedIndex == -1)
            {
                msgErr += "Veuillez sélectionner un artiste\n";
            }
            else
            {
                idChoixCourant = (int)cbxCourantArtistique.SelectedValue;
            }
            if (msgErr != "")
            {
                MessageBox.Show(msgErr, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int idChoixArtiste = (int)cbxArtiste.SelectedValue;

                    int nb = ArtisteManager.GetInstance().UpdateArtiste(idChoixArtiste, txtNomArtiste.Text, txtSiteWebArtiste.Text, idChoixCourant);

                    if (nb == 0)
                    {
                        MessageBox.Show("Problème grave : la modification de l'artiste n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Modification de l'artiste réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlModifArtiste.Visible = false;
                        Charger();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Charger()
        {
            try
            {
                //combobox de l'artiste
                cbxArtiste.DisplayMember = "Nom";
                cbxArtiste.ValueMember = "id";
                cbxArtiste.DataSource = ArtisteManager.GetInstance().GetLesArtistes();
                cbxArtiste.SelectedItem = null;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            try
            {
                //combobox de l'artiste
                cbxArtiste.DisplayMember = "libelle";
                cbxArtiste.ValueMember = "id";
                cbxArtiste.DataSource = CourantArtistiqueManager.GetInstance().GetCourantArtistiques();
                cbxCourantArtistique.SelectedItem = null;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}
