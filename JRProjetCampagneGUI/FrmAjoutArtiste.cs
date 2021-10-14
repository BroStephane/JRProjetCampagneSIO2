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
    }
}
