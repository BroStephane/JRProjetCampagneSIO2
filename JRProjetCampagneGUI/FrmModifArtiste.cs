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
                cbxArtiste.DisplayMember = "nom";
                cbxArtiste.ValueMember = "id";
                cbxArtiste.DataSource = ArtisteManager.GetInstance().GetLesArtistes();
                cbxArtiste.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxArtiste_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlArtiste.Visible = true;
        }
    }
}
