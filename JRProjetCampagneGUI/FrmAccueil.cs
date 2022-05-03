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
            FrmAjoutEvenement leFormAppele = new FrmAjoutEvenement();

            //affichage du formulaire
            leFormAppele.ShowDialog();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

   

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
            FrmAjoutVIP leFormAppele = new FrmAjoutVIP();

            //affichage du formulaire
            leFormAppele.ShowDialog();

        }

        private void ajoutDunArtisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutArtiste leFormAppele = new FrmAjoutArtiste();
            leFormAppele.ShowDialog();
        }

        /// <summary>
        /// Affiche le formulaire AjoutCampagne en créant un objet, ainsi qu'une instance de la classe du formulaire pour l'appeler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutDuneCampagneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance dee la classe du formulaire appeler
            FrmAjoutCampagne leFormAppele = new FrmAjoutCampagne();

            //affichage du formulaire
            leFormAppele.ShowDialog();
        }
        private void consultationDesAgencesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //créer un objet, une instance dee la classe du formualire appeler
            FrmConsultAgence leFormAppele = new FrmConsultAgence();

            //affichage du formulaire
            leFormAppele.ShowDialog();
        }

        private void invitationVIPÀUnÉvénementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance dee la classe du formualire appeler
            FrmInvitationVIP leFormAppele = new FrmInvitationVIP();

            //affichage du formulaire
            leFormAppele.ShowDialog();
        }

        private void consultationDesÉvénementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultEvenement cons = new FrmConsultEvenement();
            cons.ShowDialog();
        }

        /// <summary>
        /// Affiche le formulaire ConsultCampagne en créant un objet, ainsi qu'une instance de la classe du formulaire pour l'appeler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultationDesCampagnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance de la classe du formulaire appeler
            FrmConsultCampagne leFormAppele = new FrmConsultCampagne();

            //affichage du formulaire
            leFormAppele.ShowDialog();
        }

        private void consultationDesArtistesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance de la classe du formulaire appeler
            FrmConsultArtiste leFormAppele = new FrmConsultArtiste();
            //Affuche le formulaire
            leFormAppele.ShowDialog();
        }

        private void suppressionDunÉvénementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance de la classe du formulaire appeler
            FrmSupEvenement frmsup = new FrmSupEvenement();
            //affichage du formulaire
            frmsup.ShowDialog();
        }

        private void suppressionDunVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance de la classe du formulaire appeler
            FrmSupVIP frmsup = new FrmSupVIP();
            //affichage du formulaire
            frmsup.ShowDialog();
        }

        private void modifierUnArtisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //créer un objet, une instance de la classe du formulaire appeler
            FrmModifArtiste frmModifArtiste = new FrmModifArtiste();
            //affichage du formulaire
            frmModifArtiste.ShowDialog();
        }

    }
}
