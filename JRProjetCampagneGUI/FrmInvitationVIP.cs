using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRProjetCampagneBO;
using JRProjetCampagneBLL;

namespace JRProjetCampagneGUI
{
    public partial class FrmInvitationVIP : Form
    {
        public FrmInvitationVIP()
        {
            InitializeComponent();

            try
            {
                cbxVIP.DisplayMember = "nom";
                cbxVIP.ValueMember = "id";
                cbxVIP.DataSource = VIPManager.GetInstance().GetLesVIP();
                cbxVIP.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                cbxEvenement.DisplayMember = "leLib";
                cbxEvenement.ValueMember = "id";
                cbxEvenement.DataSource = EvenementManager.GetInstance().GetLesEvenements();
                cbxEvenement.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            int idEvenement = 0;
            int idVIP = 0;
            string msgErr = "";

            if (cbxVIP.SelectedIndex == -1)
            {
                msgErr += "\nVeuillez sélectionner un VIP";

            }
            else
            {
                idVIP = (int)cbxVIP.SelectedValue;
            }
            if (cbxEvenement.SelectedIndex == -1)
            {
                msgErr += "\nVeuillez sélectionner un événement";

            }
            else
            {
                idEvenement = (int)cbxEvenement.SelectedValue;
            }


            if (msgErr == "")
            {

                int nb = InvitationVIPManager.GetInstance().AddInvitationVIP(idVIP, idEvenement);

                if(nb == 0)
                {
                    MessageBox.Show("Erreur : l'ajout de l'invitation n'a pas été effectué", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("L'invitation a bien été ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxVIP.SelectedItem = null;
                    cbxEvenement.SelectedItem = null;
                }
            }
            
            else
            {
                MessageBox.Show(msgErr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
