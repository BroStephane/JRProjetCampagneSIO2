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
            if (string.IsNullOrWhiteSpace(txtNomArtiste.Text) || string.IsNullOrWhiteSpace(txtSiteWebArtiste.Text))
            {
                MessageBox.Show("Les champs saisi sont vides veuillez ressayer");
            }
            else
            {
                ArtisteManager.GetInstance().AddArtististe(txtNomArtiste.Text, txtSiteWebArtiste.Text, (int)cbxCourantArtistique.SelectedValue);
                MessageBox.Show("L'artiste à bien étré enregistré");
            }
        }

        private void FrmAjoutArtiste_Load(object sender, EventArgs e)
        {

        }
    }
}
