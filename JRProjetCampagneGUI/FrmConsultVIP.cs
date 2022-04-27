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
    public partial class FrmConsultVIP : Form
    {
        public FrmConsultVIP()
        {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            
            dtgVIP.DataSource = VIPManager.GetInstance().GetLesVIPConsult();
            dtgVIP.Columns[0].Visible = false;
            dtgVIP.Columns[4].Visible = false;
            dtgVIP.Columns[5].Visible = false;
        }
    }
}
