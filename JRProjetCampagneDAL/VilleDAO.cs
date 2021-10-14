using System;
using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class VilleDAO
    {
        private static VilleDAO uneInstance;
        // cette méthode crée un objet de la classe VilleDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static VilleDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleDAO();
            }
            return uneInstance;
        }
        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private VilleDAO()
        {
        }
        // la méthode GetLaVilleAgence retourne une collection contenant les Villes
        // existant dans la table Ville
        public List<Ville> GetLaVilleAgence()
        {
            // déclaration des variables de travail
            int numero_insee;
            string leNom;
            Ville uneVilleAgence;

            List<Ville> lesVilles = new List<Ville>();

            SqlCommand maCommand = Command.GetObjCommande();
            // on indique que l'on va appeler une procédure stockée
            maCommand.CommandType = CommandType.StoredProcedure;

            //Select numero_insee, nom FROM Ville
            // on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
            maCommand.CommandText = "GetVille";

            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Client que l'on ajoute dans la collection lesVilles
            while (reader.Read())
            {
                int.TryParse(reader["numero_insee"].ToString(), out numero_insee);
                //Etant donné que le nom peut contenir des valeurs null, on doit remplacer la valeur null par la chaîne vide
                if (reader["nom"] == DBNull.Value)
                {
                    leNom = default(string);
                }
                else
                {
                    leNom = reader["nom"].ToString();
                }
                //On crée une Ville
                uneVilleAgence = new Ville(numero_insee, leNom);
                //On ajoute la ville dans une liste
                lesVilles.Add(uneVilleAgence);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesVilles;
        }
    }
}
