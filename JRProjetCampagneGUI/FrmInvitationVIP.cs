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
                cbxEvenement.DisplayMember = "nom";
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

        }
    }
}
