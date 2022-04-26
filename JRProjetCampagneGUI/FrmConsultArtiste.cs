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
    public partial class FrmConsultArtiste : Form
    {
        public FrmConsultArtiste()
        {
            InitializeComponent();
        }

        private void btnObtenirInfos_Click(object sender, EventArgs e)
        {
            
            dtgInfosArtiste.DataSource = ArtisteManager.GetInstance().GetLesArtistes();
            dtgInfosArtiste.Columns[0].Visible = false;
        }
    }
}
