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

        private void ajoutDuneCampagneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, instance de la classe du formulaire à appeler
            FrmAddCampagne leFormAppele = new FrmAddCampagne();

            //afficher le formulaire
            leFormAppele.ShowDialog();
        }
    }
}
