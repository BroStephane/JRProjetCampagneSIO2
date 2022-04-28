using JRProjetCampagneBO;
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
    public partial class FrmAjoutArtiste : Form
    {
        public FrmAjoutArtiste()
        {
            InitializeComponent();

            try
            {
                //Remplie la comboBox des valeurs de la table Courant Artistique
                cbxCourantArtistique.DisplayMember = "libelle";
                cbxCourantArtistique.ValueMember = "id";
                cbxCourantArtistique.DataSource = CourantArtistiqueManager.GetInstance().GetCourantArtistiques();
                cbxCourantArtistique.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnValiderAjoutArtiste_Click(object sender, EventArgs e)
        {
            string err = "";
            if (string.IsNullOrWhiteSpace(txtNomArtiste.Text))
            {
                err += "Le champ \"Nom\" n'est pas rempli\n";
            }
            if (string.IsNullOrWhiteSpace(txtSiteWebArtiste.Text))
            {
                err += "Le champ \"Site web artiste\" n'est pas rempli\n";
            }
            if (string.IsNullOrWhiteSpace(cbxCourantArtistique.Text))
            {
                err += "Le champ \"Courant artistique\" n'est pas selectionné\n";
            }
            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                ArtisteManager.GetInstance().AddArtististe(txtNomArtiste.Text, txtSiteWebArtiste.Text, (int)cbxCourantArtistique.SelectedValue);
                MessageBox.Show("Le client a bien étré enregidstré");
            }
            txtNomArtiste.Clear();
            txtSiteWebArtiste.Clear();
            cbxCourantArtistique.SelectedItem = null;

        }
        
    }
}
