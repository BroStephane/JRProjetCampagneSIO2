using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class CourantArtistiqueDAO
    {
        private static CourantArtistiqueDAO uneInstance;

        public static CourantArtistiqueDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CourantArtistiqueDAO();
            }
            return uneInstance;
        }
        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private CourantArtistiqueDAO()
        {

        }

        public List<CourantArtistique> GetCourantArtistiques()
        {
            int id;
            string libelle;

            List<CourantArtistique> lesCourantArtistiques = new List<CourantArtistique>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetCourantArtistique";
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

                lesCourantArtistiques.Add(new CourantArtistique(id, libelle));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesCourantArtistiques;


        }
    }
}
