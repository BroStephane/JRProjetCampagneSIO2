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
            pnlArtiste.Visible = false;
            chargerArtiste();

        }

        public void chargerArtiste()
        {
            pnlArtiste.Visible = false;
            try
            {
                cbxArtiste.DisplayMember = "Nom";
                cbxArtiste.ValueMember = "Id";
                cbxArtiste.DataSource = ArtisteManager.GetInstance().GetLesArtistes();
                cbxArtiste.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                cbxCourantArtistique.DisplayMember = "Libelle";
                cbxCourantArtistique.ValueMember = "Id";
                cbxCourantArtistique.DataSource = CourantArtistiqueManager.GetInstance().GetCourantArtistiques();
                cbxCourantArtistique.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void cbxArtiste_SelectionChangeCommitted_1(object sender, EventArgs e)
        {


            //int idArtiste = (int)cbxArtiste.SelectedValue;

            int idArtiste = (int)cbxArtiste.SelectedValue;
            Artiste unArtiste = ArtisteManager.GetInstance().GetUnArtisteId(idArtiste);

            txtNomArtiste.Text = unArtiste.Nom;
            txtSiteWebArtiste.Text = unArtiste.SiteWeb;
            cbxCourantArtistique.Text = " ";
            cbxCourantArtistique.Text = unArtiste.LibelleCourant;

            pnlArtiste.Visible = true;
        }
        private void btnValiderModificationArtiste_Click(object sender, EventArgs e)
        {
            txtNomArtiste.Text = txtNomArtiste.Text.Trim();
            txtSiteWebArtiste.Text = txtSiteWebArtiste.Text.Trim();
            cbxCourantArtistique.Text = cbxCourantArtistique.Text.Trim();
            int idCourant = 0;
            string msgErr = "";
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
                idCourant = (int)cbxCourantArtistique.SelectedValue;
            }
            if(msgErr != "")
            {
                MessageBox.Show(msgErr, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int idChoixArtiste = (int)cbxArtiste.SelectedValue;

                    int nb = ArtisteManager.GetInstance().UpdateArtiste(idChoixArtiste, txtNomArtiste.Text, txtSiteWebArtiste.Text, idCourant);

                    if (nb ==0)
                    {
                        MessageBox.Show("Problème grave : la modification de l'artiste n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Modification de l'artiste réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlArtiste.Visible = false;
                        chargerArtiste();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

    }
}
