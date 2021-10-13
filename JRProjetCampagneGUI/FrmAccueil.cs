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
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void ajoutDunÉvénementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutEvenement lAjout = new FrmAjoutEvenement();
            lAjout.ShowDialog();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void ajoutDunVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutVIP vip = new FrmAjoutVIP();
            vip.ShowDialog();
        }
    }
}
