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
        //créer un objet, une instance dee la classe du formulaire appeler
            FrmAjoutEvenement lAjout = new FrmAjoutEvenement();
            //affichage du formulaire
            lAjout.ShowDialog();
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
        private void ajoutDunArtisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutArtiste lAjout = new FrmAjoutArtiste();
            lAjout.Show();

        private void ajoutDuneAgenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance dee la classe du formulaire appeler
            FrmAjoutAgence leFormAppele = new FrmAjoutAgence();

            //affichage du formulaire
            leFormAppele.ShowDialog();
         }

        private void ajoutDunVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //créer un objet, une instance dee la classe du formulaire appeler
            FrmAjoutVIP vip = new FrmAjoutVIP();
            //affichage du formulaire
            vip.ShowDialog();
        }
    }
}
