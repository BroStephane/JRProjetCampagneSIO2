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
    /// <summary>
    /// La classe VIPDAO accède à la table VIP dans la base de données
    /// </summary>
    public class VIPDAO
    {
        private static VIPDAO uneInstance;

        // cette méthode crée un objet de la classe ClientDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static VIPDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VIPDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private VIPDAO()
        {

        }



        /// <summary>
        /// Retourne une liste d'objets vip 
        /// </summary>
        /// <returns></returns>
        public List<VIP> GetLesVIP()
        {

            int id;
            string nom;

            List<VIP> lesVIP = new List<VIP>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetVIPListeDeroulante";
            SqlDataReader monLecteur = command.ExecuteReader();

            while (monLecteur.Read())
            {


                int.TryParse(monLecteur["id"].ToString(), out id);

                if (monLecteur["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monLecteur["nom"].ToString();
                }

                lesVIP.Add(new VIP(id, nom));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesVIP;

        }

        public List<VIP> GetLesVIPConsult()
        {

            int id, numero_insee, idCategVIP;
            string nom;
            string libelle, nomVille;
            string rue = "";
            string mail = "";


            List<VIP> lesVIP = new List<VIP>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetLesVIP";
            SqlDataReader monLecteur = command.ExecuteReader();

            while (monLecteur.Read())
            {
               
                int.TryParse(monLecteur["id"].ToString(), out id);
                int.TryParse(monLecteur["id_CategorieVIP"].ToString(), out idCategVIP);
                int.TryParse(monLecteur["numero_insee"].ToString(), out numero_insee);

                if (monLecteur["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monLecteur["nom"].ToString();
                }
                
                if (monLecteur["email"] == DBNull.Value)
                {
                    mail = default(string);
                }
                else
                {
                    mail = monLecteur["email"].ToString();
                }
                if (monLecteur["rue"] == DBNull.Value)
                {
                    rue = default(string);
                }
                else
                {
                    rue = monLecteur["rue"].ToString();
                }
                if (monLecteur["libelle"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["libelle"].ToString();
                }
                if (monLecteur["nomVille"] == DBNull.Value)
                {
                    nomVille = default(string);
                }
                else
                {
                    nomVille = monLecteur["nomVille"].ToString();
                }

                Ville uneVille = new Ville(numero_insee, nomVille);
                CategorieVIP uneCategVIP = new CategorieVIP(id, libelle);

                lesVIP.Add(new VIP(id, nom, rue, mail, uneVille, uneCategVIP));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesVIP;

        }

        public VIP GetUnVIP(VIP unVIP)
        {
            int id, idCategorieVIP, num_insee;
            string nom, rue, email ;
            CategorieVIP uneCategVIP;
            Ville uneVille;

            

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetUnVIP";

            command.Parameters.Add("id", SqlDbType.Int);
            command.Parameters["id"].Value = unVIP.Id;

            SqlDataReader monLecteur = command.ExecuteReader();

            while (monLecteur.Read())
            {


                int.TryParse(monLecteur["id"].ToString(), out id);
                int.TryParse(monLecteur["id_CategorieVIP"].ToString(), out idCategorieVIP);
                int.TryParse(monLecteur["numero_insee"].ToString(), out num_insee);

                if (monLecteur["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monLecteur["nom"].ToString();
                }
                if (monLecteur["rue"] == DBNull.Value)
                {
                    rue = default(string);
                }
                else
                {
                    rue = monLecteur["rue"].ToString();
                }
                if (monLecteur["email"] == DBNull.Value)
                {
                    email = default(string);
                }
                else
                {
                    email = monLecteur["email"].ToString();
                }

                uneCategVIP = new CategorieVIP(idCategorieVIP);
                uneVille = new Ville(num_insee);

                unVIP = new VIP(id, nom, rue, email, uneVille, uneCategVIP);
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return unVIP;
        }

        /// <summary>
        /// Ajoute un vip dans la base de données
        /// </summary>
        /// <param name="unVIP"></param>
        /// <returns></returns>
        public int AddVIP(VIP unVIP)
        {

            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "AddVIP";

            laCom.Parameters.Add("nom", SqlDbType.VarChar);
            laCom.Parameters["nom"].Value = unVIP.Nom;
            laCom.Parameters.Add("email", SqlDbType.VarChar);
            laCom.Parameters["email"].Value = unVIP.Mail;
            laCom.Parameters.Add("rue", SqlDbType.VarChar);
            laCom.Parameters["rue"].Value = unVIP.Rue;
            laCom.Parameters.Add("numero_insee", SqlDbType.Int);
            laCom.Parameters["numero_insee"].Value = unVIP.UneVille.Numero_insee;
            laCom.Parameters.Add("id_CategorieVIP", SqlDbType.Int);
            laCom.Parameters["id_CategorieVIP"].Value = unVIP.UneCategorieVIP.Id;


            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;


        }

        public int UpdateVIP(VIP unVIP)
        {
            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête Update
            laCom.CommandText = "UpdateVIP";

            laCom.Parameters.Add("id", SqlDbType.Int);
            laCom.Parameters["id"].Value = unVIP.Id;
            laCom.Parameters.Add("nom", SqlDbType.VarChar);
            laCom.Parameters["nom"].Value = unVIP.Nom;
            laCom.Parameters.Add("email", SqlDbType.VarChar);
            laCom.Parameters["email"].Value = unVIP.Mail;
            laCom.Parameters.Add("rue", SqlDbType.VarChar);
            laCom.Parameters["rue"].Value = unVIP.Rue;
            laCom.Parameters.Add("numero_insee", SqlDbType.Int);
            laCom.Parameters["numero_insee"].Value = unVIP.UneVille.Numero_insee;
            laCom.Parameters.Add("id_CategorieVIP", SqlDbType.Int);
            laCom.Parameters["id_CategorieVIP"].Value = unVIP.UneCategorieVIP.Id;


            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;
        }


        /// <summary>
        /// Supprime un vip de la base de données
        /// </summary>
        /// <param name="unVIP"></param>
        /// <returns></returns>
        public int DeleteVIP(VIP unVIP)
        {
            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "DeleteVIP";


            laCom.Parameters.Add("id", SqlDbType.Int);
            laCom.Parameters["id"].Value = unVIP.Id;


            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;
        }

    }
}

   
