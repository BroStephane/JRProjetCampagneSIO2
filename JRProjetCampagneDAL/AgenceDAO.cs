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
    public class AgenceDAO
    {
        private static AgenceDAO uneInstance;

        // cette méthode crée un objet de la classe AgenceDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// cette méthode crée un objet de la classe AgenceDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private AgenceDAO()
        {
        }

        /// <summary>
        /// la méthode GetAgences retourne une collection contenant les agences existant dans la table Agence
        /// </summary>
        /// <returns>Retourne une collection d'agence</returns>
        public List<Agence> GetAgences()
        {
            // déclaration des variables de travail
            int numero_insee;
            string leNom;
            string laRue;
            string leTelephone;
            string lEmail;
            string leSite;
            char leType;
            string leNomVille;
            Agence uneAgence;
            Ville laVille;

            List<Agence> lesAgences = new List<Agence>();
            SqlCommand maCommand = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            maCommand.CommandType = CommandType.StoredProcedure;

            //Select id, nom, rue, telephone, emailContact, siteWeb, typeAgence, Ville.nom FROM Agence Join Ville on numero_insee = Ville.numero_insee
            // on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
            maCommand.CommandText = "GetLesAgences";

            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Agence que l'on ajoute dans la collection lesAgences
            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out numero_insee);
                leNom = reader["Nom de l'agence"].ToString();
                laRue = reader["Rue"].ToString();
                leTelephone = reader["Téléphone"].ToString();
                lEmail = reader["Email de contact"].ToString();
                leSite = reader["Site Web"].ToString();
                leType = Char.Parse(reader["Type de l'agence"].ToString());
                leNomVille = reader["Nom de la ville"].ToString();

                laVille = new Ville(numero_insee, leNomVille);
                //On crée une agence
                uneAgence = new Agence(leNom, laRue, laVille, leTelephone, lEmail, leSite, leType);
                //On ajoute l'agence dans une liste
                lesAgences.Add(uneAgence);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesAgences;
        }

        /// <summary>
        /// la méthode AddAgences fait un INSERT dans la table Agence de la base de données
        /// </summary>
        /// <param name="uneAgence">l'instance de Agence contenant tous les attributs</param>
        /// <returns>Execute la requête</returns>
        public int AddAgence(Agence uneAgence)
        {
            //On récupère l'objet responsable de la connexion de base
            SqlCommand maCommand = Command.GetObjCommande();

            maCommand.Parameters.Clear();

            // on indique que l'on va appeler une procédure stockée
            maCommand.CommandType = CommandType.StoredProcedure;

            //Insert Into Agence(nom, rue, telephone, emailContact, siteWeb, typeAgence, numero_insee) values (@parNom, @parRue, @parTelephone, @parEmail, @parSite, @parType, @parVille)
            // on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
            maCommand.CommandText = "AddAgence";

            //On renseigne les paramètres
            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["nom"].Value = uneAgence.Nom;

            maCommand.Parameters.Add("rue", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["rue"].Value = uneAgence.Rue;

            maCommand.Parameters.Add("telephone", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["telephone"].Value = uneAgence.Telephone;

            maCommand.Parameters.Add("emailContact", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["emailContact"].Value = uneAgence.EmailContact;

            maCommand.Parameters.Add("siteWeb", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["siteWeb"].Value = uneAgence.SiteWeb;

            maCommand.Parameters.Add("typeAgence", System.Data.SqlDbType.Char);
            maCommand.Parameters["typeAgence"].Value = uneAgence.TypeAgence;

            maCommand.Parameters.Add("numero_insee", System.Data.SqlDbType.Int);
            maCommand.Parameters["numero_insee"].Value = uneAgence.UneVille.Numero_insee;

            // on exécute la requête
            return maCommand.ExecuteNonQuery();

        }

        // la méthode GetAgenceEvenementiel retourne une collection contenant les agences evenementiels
        // existant dans la table Agence
        /// <summary>
        /// la méthode GetAgenceEvenementiel retourne une collection contenant les agences evenementiels existant dans la table Agence
        /// </summary>
        /// <returns>Retroune une collection des agences evenementiels</returns>
        public List<Agence> GetAgenceEvenementiel()
        {
            int num;
            string sonNom;
            Agence uneAgenceEvenementiel;

            // on crée la collection lesAgencesEvenementiel de type List<Agence> qui va contenir les
            // agence évènementiel enregistrés dans la base de données
            List<Agence> lesAgencesEvenementiels = new List<Agence>();

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "dbo.GetLesAgencesEvenementiellesListeDeroulante";
            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Employe que l'on ajoute dans la collection lesAgencesEvenementielles
            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out num);

                sonNom = reader["nom"].ToString();

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
        /// <summary>
        /// la méthode GetAgenceEvenementiel retourne une collection contenant les agences de communications existant dans la table Agence
        /// </summary>
        /// <returns>Retroune une collection des agences de communications</returns>
        public List<Agence> GetAgenceCommunication()
        {
            int num;
            string sonNom;
            Agence uneAgenceCommunication;

            // on crée la collection lesAgencesCommunication de type List<Agence> qui va contenir les
            // agence de communication enregistrés dans la base de données
            List<Agence> lesAgencesCommunications = new List<Agence>();

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "dbo.GetLesAgencesCommunicationsListeDeroulante";
            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Agence que l'on ajoute dans la collection lesAgencesCommunications
            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out num);

                sonNom = reader["nom"].ToString();

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
