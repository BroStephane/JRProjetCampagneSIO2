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

        // cette méthode crée un objet de la classe CampagneDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// cette méthode crée un objet de la classe CampagneDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static CampagneDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        /// <summary>
        /// // le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private CampagneDAO()
        {
        }

        /// <summary>
        /// la méthode AddCampagne fait un INSERT dans la table Campagne de la base de données
        /// </summary>
        /// <param name="uneCampagne">l'instance de Campagne contenant tous les attributs</param>
        /// <returns>Execute la requête</returns>
        //création de la campagne
        public int AddCampagne(Campagne uneCampagne)
        {
            //on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            maCommand.Parameters.Clear();

            //on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
            maCommand.CommandText = "AddCampagne";

            //on renseigne le paramètre
            maCommand.Parameters.Add("parLibelle", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["parLibelle"].Value = uneCampagne.Libelle;

            maCommand.Parameters.Add("parDateDebut", System.Data.SqlDbType.DateTime);
            maCommand.Parameters["parDateDebut"].Value = uneCampagne.DateDebut;

            maCommand.Parameters.Add("parDateFin", System.Data.SqlDbType.DateTime);
            maCommand.Parameters["parDateFin"].Value = uneCampagne.DateFin;

            maCommand.Parameters.Add("parObjectif", System.Data.SqlDbType.VarChar);
            maCommand.Parameters["parObjectif"].Value = uneCampagne.Objectif;

            maCommand.Parameters.Add("parIdChoixEmploye", System.Data.SqlDbType.Int);
            maCommand.Parameters["parIdChoixEmploye"].Value = uneCampagne.UnEmploye.Id;

            maCommand.Parameters.Add("parIdChoixAgenceEvenementiel", System.Data.SqlDbType.Int);
            maCommand.Parameters["parIdChoixAgenceEvenementiel"].Value = uneCampagne.UneAgenceEvenementiel.Id;

            maCommand.Parameters.Add("parIdChoixAgenceCommunication", System.Data.SqlDbType.Int);
            maCommand.Parameters["parIdChoixAgenceCommunication"].Value = uneCampagne.UneAgenceCommunication.Id;

            return maCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// la méthode GetCampagnes retourne une collection contenant les campagnes existant dans la table Campagne
        /// </summary>
        /// <returns>Retourne une collection de campagnes</returns>
        public List<Campagne> GetCampagnes()
        {
            int id;
            string libelle;

            List<Campagne> lesCampagnes = new List<Campagne>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetCampagnesListeDeroulante";
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

        // la méthode GetClients retourne une collection contenant les clients
        // existant dans la table Client
        /// <summary>
        /// la méthode GetLesCampagnes retourne une collection contenant les campagnes existant dans la table Campagne
        /// </summary>
        /// <returns>Une collection contenant les campagnes de la base de données de la table Campagne</returns>
        public List<Campagne> GetLesCampagnes()
        {

            string leLibelle;
            string leObjectif;
            DateTime saDateDebut;
            DateTime saDateFin;
            string sonNom;
            string sonPrenom;
            string sonAgenceEvenementiel;
            string sonAgenceCommunication;
            Employe unEmploye;
            Agence uneAgenceEvenementielle;
            Agence uneAgenceCommunication;
            Campagne uneCampagne;

            // on crée la collection lesCampagnes de type List<Campagne> qui va contenir les
            // caractéristiques des campagnes enregistrés dans la base de donnes
            List<Campagne> lesCampagnes = new List<Campagne>();

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesCampagnes";
            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Campagne que l'on ajoute dans la collection lesCampagnes
            while (reader.Read())
            {

                //étant donné que le nom peut contenir des valeurs null, on doit remplacer la valeur null par la chaîne vide
                if (reader["libelle"] == DBNull.Value)
                {
                    leLibelle = default(string);
                }
                else
                {
                    leLibelle = reader["libelle"].ToString();
                }

                if (reader["dateDebut"] == DBNull.Value)
                {
                    saDateDebut = DateTime.Parse(default(string));
                }
                else
                {
                    saDateDebut = DateTime.Parse(reader["dateDebut"].ToString());
                }

                if (reader["dateFin"] == DBNull.Value)
                {
                    saDateFin = DateTime.Parse(default(string));
                }
                else
                {
                    saDateFin = DateTime.Parse(reader["dateFin"].ToString());
                }

                if (reader["objectif"] == DBNull.Value)
                {
                    leObjectif = default(string);
                }
                else
                {
                    leObjectif = reader["objectif"].ToString();
                }

                if (reader["nom Employé"] == DBNull.Value)
                {
                    sonNom = default(string);
                }
                else
                {
                    sonNom = reader["nom Employé"].ToString();
                }

                if (reader["prenom Employe"] == DBNull.Value)
                {
                    sonPrenom = default(string);
                }
                else
                {
                    sonPrenom = reader["prenom Employe"].ToString();
                }

                if (reader["Agences de Evenementielles"] == DBNull.Value)
                {
                    sonAgenceEvenementiel = default(string);
                }
                else
                {
                    sonAgenceEvenementiel = reader["Agences de Evenementielles"].ToString();
                }

                if (reader["Agences de Communications"] == DBNull.Value)
                {
                    sonAgenceCommunication = default(string);
                }
                else
                {
                    sonAgenceCommunication = reader["Agences de Communications"].ToString();
                }

                //on créer un employé
                unEmploye = new Employe(sonNom,sonPrenom);
                //on créer une agence évenementiel
                uneAgenceEvenementielle = new Agence(sonAgenceEvenementiel);
                //on créer une agence de communication
                uneAgenceCommunication = new Agence(sonAgenceCommunication);

                //on crée une Campagne
                uneCampagne = new Campagne(leLibelle,saDateDebut,saDateFin,leObjectif,unEmploye,uneAgenceEvenementielle,uneAgenceCommunication);

                //on ajoute à la liste lesCampagnes
                lesCampagnes.Add(uneCampagne);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesCampagnes;
        }

    }
}
