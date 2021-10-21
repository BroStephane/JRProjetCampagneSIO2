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
    public partial class FrmSupVIP : Form
    {
        public FrmSupVIP()
        {
            InitializeComponent();
            btnSup.Visible = false;
            chargerVIP();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            int idVIP = (int)cbxVIP.SelectedValue;

            int nb = VIPManager.GetInstance().DeleteVIP(idVIP);

            if (nb == 0)
            {
                MessageBox.Show("Erreur lors de la suppression du VIP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("la suppression du VIP à été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxVIP.SelectedItem = null;
                
            }
        }
        

        public void chargerVIP()
        {
            btnSup.Visible = false;
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
        }

        private void cbxVIP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSup.Visible = true;
        }
    }
}
