using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class AgenceDAO
    {
        private static AgenceDAO uneInstance;

        // cette méthode crée un objet de la classe AgenceDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static AgenceDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AgenceDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private AgenceDAO()
        {
        }

        // la méthode GetAgenceEvenementiel retourne une collection contenant les agences evenementiels
        // existant dans la table Agence
        public List<Agence> GetAgenceEvenementiel()
        {
            int num;
            string sonNom;
            Agence uneAgenceEvenementiel;

            // on crée la collection lesAgencesEvenementiel de type List<Agence> qui va contenir les
            // agence évènementiel enregistrés dans la base de données
            List<Agence> lesAgencesEvenementiels = new List<Agence>();

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommand();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "dbo.GetLesAgencesEvenementielles";
            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Employe que l'on ajoute dans la collection lesAgencesEvenementielles
            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out num);

                //étant donné que le libelle peut contenir des valeurs null, on doit remplacer la valeur null par la chaîne vide
                if (reader["nom"] == DBNull.Value)
                {
                    sonNom = default(string);
                }
                else
                {
                    sonNom = reader["nom"].ToString();
                }

                //on crée une agence evenementielle
                uneAgenceEvenementiel = new Agence(num, sonNom);

                //on ajoute à la liste lesAgencesEvenementiels
                lesAgencesEvenementiels.Add(uneAgenceEvenementiel);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesAgencesEvenementiels;
        }

        // la méthode GetAgenceCommunciation retourne une collection contenant les agences de commuications
        // existant dans la table Agence
        public List<Agence> GetAgenceCommunication()
        {
            int num;
            string sonNom;
            Agence uneAgenceCommunication;

            // on crée la collection lesAgencesCommunication de type List<Agence> qui va contenir les
            // agence de communication enregistrés dans la base de données
            List<Agence> lesAgencesCommunications = new List<Agence>();

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommand();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "dbo.GetLesAgencesCommunications";
            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Agence que l'on ajoute dans la collection lesAgencesCommunications
            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out num);

                //étant donné que le libelle peut contenir des valeurs null, on doit remplacer la valeur null par la chaîne vide
                if (reader["nom"] == DBNull.Value)
                {
                    sonNom = default(string);
                }
                else
                {
                    sonNom = reader["nom"].ToString();
                }

                //on crée une agence evenementielle
                uneAgenceCommunication = new Agence(num, sonNom);

                //on ajoute à la liste lesAgencesEvenementiels
                lesAgencesCommunications.Add(uneAgenceCommunication);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesAgencesCommunications;
        }
    }
}
