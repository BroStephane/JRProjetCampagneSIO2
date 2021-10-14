using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class CampagneDAO
    {
        private static CampagneDAO uneInstance;

        public static CampagneDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneDAO();
            }
            return uneInstance;
        }
        private CampagneDAO() { }

        public List<Campagne> GetCampagnes()
        {
            int id;
            string libelle;

            List<Campagne> lesCampagnes = new List<Campagne>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "exec GetCampagnesListeDeroulante";
            SqlDataReader monLecteur = command.ExecuteReader();

            while (monLecteur.Read())
            {


                int.TryParse(monLecteur["id"].ToString(), out id);

                if (monLecteur["libelle"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["libelle"].ToString();
                }

                lesCampagnes.Add(new Campagne(id, libelle));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesCampagnes;
        }
    }
}
