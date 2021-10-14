using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class ThemeDAO
    {
        private static ThemeDAO uneInstance;

        public static ThemeDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ThemeDAO();
            }
            return uneInstance;
        }

        private ThemeDAO()
        {

        }


        public List<Theme> GetThemes()
        {
            int id;
            string libelle;

            List<Theme> lesThemes = new List<Theme>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommand();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetTheme";
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

                lesThemes.Add(new Theme(id, libelle));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesThemes;


        }


    }
}
