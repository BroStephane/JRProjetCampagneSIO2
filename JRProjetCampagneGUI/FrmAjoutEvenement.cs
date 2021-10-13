using JRProjetCampagneBO;
using JRProjetEvenementBLL;
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
    public partial class FrmAjoutEvenement : Form
    {
        public FrmAjoutEvenement()
        {
            InitializeComponent();

            try
            {
                cbxTheme.DisplayMember = "libelle";
                cbxTheme.ValueMember = "id";
                cbxTheme.DataSource = ThemeManager.GetInstance().GetThemes();
                cbxTheme.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }




        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {

        }
    }
}
