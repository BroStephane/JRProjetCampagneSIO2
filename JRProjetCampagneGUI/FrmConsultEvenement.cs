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
    public partial class FrmConsultEvenement : Form
    {
        public FrmConsultEvenement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            dtgEvenement.DataSource = EvenementManager.GetInstance().GetLesEvenementsConsult();
            dtgEvenement.Columns[0].Visible = false;
            dtgEvenement.Columns[3].Visible = false;
            dtgEvenement.Columns[4].Visible = false;
            dtgEvenement.Columns[5].Visible = false;
            dtgEvenement.Columns[6].Visible = false;
            dtgEvenement.Columns[7].Visible = false;

        }
    }
}
