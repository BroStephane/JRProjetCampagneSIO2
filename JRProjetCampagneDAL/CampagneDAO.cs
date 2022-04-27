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

        /// <summary>
        /// // le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private CampagneDAO()
        {
        }

        /// <summary>
        /// la méthode AddCampagne fait un INSERT dans la table Campagne de la base de données pour la création d'une campagne avec les données saisies transmis de CampagneManager
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
        /// la méthode GetCampagnes retourne une collection contenant touts les libelles des campagnes existantes dans la table Campagne
        /// </summary>
        /// <returns>Retourne une collection des libelles de campagnes</returns>
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

                libelle = monLecteur["libelle"].ToString();

                lesCampagnes.Add(new Campagne(id, libelle));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            // on retourne la collection
            return lesCampagnes;
        }

        /// <summary>
        /// la méthode GetLesCampagnes retourne une collection contenant toutes les campagnes et leurs caractéristiques existantes dans la table Campagne
        /// </summary>
        /// <returns>Une collection contenant toutes les campagnes et leurs caractéristiques de la base de données de la table Campagne</returns>
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
                leLibelle = reader["libelle"].ToString();
                saDateDebut = DateTime.Parse(reader["dateDebut"].ToString());
                saDateFin = DateTime.Parse(reader["dateFin"].ToString());
                leObjectif = reader["objectif"].ToString();
                sonNom = reader["nom Employé"].ToString();
                sonPrenom = reader["prenom Employe"].ToString();
                sonAgenceEvenementiel = reader["Agences de Evenementielles"].ToString();
                sonAgenceCommunication = reader["Agences de Communications"].ToString();

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

        /// <summary>
        /// la méthode GetUneCampagneId retourne une instance d'une campagne contenant ses caractéristiques existant dans la table Campagne par rapport à l'id passé en paramètre
        /// </summary>
        /// <param name="idChoixCampagne">l'id de la campagne sélectionné dans le combobox par l'utilisateur</param>
        /// <returns></returns>
        public Campagne GetUneCampagneId(int idChoixCampagne)
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
            Campagne uneCampagne = null;

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            maCommand.Parameters.Clear();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesCampagnesId";

            maCommand.Parameters.Add("parIdChoixCampagne", System.Data.SqlDbType.Int);
            maCommand.Parameters["parIdChoixCampagne"].Value = idChoixCampagne;

            SqlDataReader reader = maCommand.ExecuteReader();

            while (reader.Read())
            {
                leLibelle = reader["libelle"].ToString();
                saDateDebut = DateTime.Parse(reader["dateDebut"].ToString());
                saDateFin = DateTime.Parse(reader["dateFin"].ToString());
                leObjectif = reader["objectif"].ToString();
                sonNom = reader["nom Employé"].ToString();
                sonPrenom = reader["prenom Employe"].ToString();
                sonAgenceEvenementiel = reader["Agences de Evenementielles"].ToString();
                sonAgenceCommunication = reader["Agences de Communications"].ToString();

                //on créer un employé
                unEmploye = new Employe(sonNom, sonPrenom);
                //on créer une agence évenementiel
                uneAgenceEvenementielle = new Agence(sonAgenceEvenementiel);
                //on créer une agence de communication
                uneAgenceCommunication = new Agence(sonAgenceCommunication);
                //on crée une Campagne
                uneCampagne = new Campagne(leLibelle, saDateDebut, saDateFin, leObjectif, unEmploye, uneAgenceEvenementielle, uneAgenceCommunication);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return uneCampagne;
        }

        /// <summary>
        /// la méthode UpdateCampagne fait un UPDATE dans la table Campagne de la base de données pour la modification d'une campagne
        /// </summary>
        /// <param name="uneCampagne">l'instance de Campagne contenant tous les attributs à mettre à jour</param>
        /// <returns>Exéute la procédure stockée</returns>
        public int UpdateCampagne(Campagne uneCampagne)
        {
            //on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            maCommand.Parameters.Clear();

            //on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
            maCommand.CommandText = "UpdateCampagne";

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

            maCommand.Parameters.Add("parIdChoixCampagne", System.Data.SqlDbType.Int);
            maCommand.Parameters["parIdChoixCampagne"].Value = uneCampagne.Id;

            return maCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// la méthode DeleteCampagne fait un DELETE dans la table Campagne de la base de données pour la suppression d'une campagne
        /// </summary>
        /// <param name="uneCampagne">l'instance de Campagne contenant l'id de la campagne à supprimer</param>
        /// <returns></returns>
        public int DeleteCampagne(Campagne uneCampagne)
        {
            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            maCommand.Parameters.Clear();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "DeleteCampagne";

            maCommand.Parameters.Add("parIdChoixCampagne", System.Data.SqlDbType.Int);
            maCommand.Parameters["parIdChoixCampagne"].Value = uneCampagne.Id;

            return maCommand.ExecuteNonQuery();
        }
    }
}
