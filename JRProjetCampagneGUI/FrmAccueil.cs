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
            lAjout.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void ajoutDuneAgenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance dee la classe du formualire appeler
            FrmAjoutAgence leFormAppele = new FrmAjoutAgence();

            //affichage du formulaire
            leFormAppele.Show();
        }
    }
}
