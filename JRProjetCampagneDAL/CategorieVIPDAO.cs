using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class CategorieVIPDAO
    {
        private static CategorieVIPDAO uneInstance;

        public static CategorieVIPDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CategorieVIPDAO();
            }
            return uneInstance;
        }

        private CategorieVIPDAO()
        {

        }


        public List<CategorieVIP> GetLesCategsVIP()
        {
            int id;
            string libelle;

            List<CategorieVIP> lesCategsVIP = new List<CategorieVIP>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "exec GetLesCategsVIP";
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

                lesCategsVIP.Add(new CategorieVIP(id, libelle));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesCategsVIP;


        }

    }
}
