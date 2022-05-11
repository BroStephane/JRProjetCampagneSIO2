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
    public partial class FrmSupArtiste : Form
    {
        public FrmSupArtiste()
        {
            InitializeComponent();
            btnSup.Visible = false;
            charger();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            int idArtiste = (int)cbxArtiste.SelectedValue;

            int nb = ArtisteManager.GetInstance().DeleteArtiste(idArtiste);

            if (nb == 0)
            {
                MessageBox.Show("Erreur lors de la suppression de l'artiste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("la suppression de l'évènement à été artiste", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxArtiste.SelectedItem = null;
                charger();
            }
        }


            private void cbxArtiste_SelectionChangeCommitted(object sender, EventArgs e)
            {
                btnSup.Visible = true;
            }

            public void charger()
            {
                btnSup.Visible = false;
                try
                {
                    cbxArtiste.DisplayMember = "Nom";
                    cbxArtiste.ValueMember = "Id";
                    cbxArtiste.DataSource = ArtisteManager.GetInstance().GetLesArtistes();
                    cbxArtiste.SelectedItem = null;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
