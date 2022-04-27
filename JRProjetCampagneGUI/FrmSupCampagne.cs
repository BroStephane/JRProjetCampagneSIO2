using JRProjetCampagneBLL;
using JRProjetCampagneBO;
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
    public partial class FrmSupCampagne : Form
    {
        /// <summary>
        /// Charge dans la combobox les différentes campagnes avec la méthode Charger()
        /// </summary>
        public FrmSupCampagne()
        {
            InitializeComponent();
            Charger();
        }

        /// <summary>
        /// Envoie l'id de la campagne sélectionner par l'utilisateur dans CampagneManager avec la méthode DeleteCampagne()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppr_Click(object sender, EventArgs e)                             
        {
            int idChoixCampagne = (int)cbxCampagne.SelectedValue;
            int nb = CampagneManager.GetInstance().DeleteCampagne(idChoixCampagne);

            if (nb == 0)
            {
                MessageBox.Show("Problème grave : la suppression de la campagne n'a pas été réalisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Suppression de la campagne réalisé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxCampagne.SelectedItem = null;
                Charger();
            }
        }

        /// <summary>
        /// Cette méthode permet de charger le libelle des campagnes dans la combobox et retourne un message d'erreur si cela ne s'effectue pas
        /// </summary>
        public void Charger()
        {
            try
            {
                //combobox de la campagne
                cbxCampagne.DisplayMember = "Libelle";
                cbxCampagne.ValueMember = "id";
                cbxCampagne.DataSource = CampagneManager.GetInstance().GetCampagnes();
                cbxCampagne.SelectedItem = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
