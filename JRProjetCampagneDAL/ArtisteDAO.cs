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
    public class ArtisteDAO
    {
        private static ArtisteDAO uneInstance;

        // cette méthode crée un objet de la classe ArtisteDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// cette méthode crée un objet de la classe ArtisteDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static ArtisteDAO GetInstance()
          {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteDAO();
            }
            return uneInstance;
          }
        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>

        /// <summary>
        /// la méthode GetAgences retourne une collection contenant les agences existant dans la table Agence
        /// </summary>
        /// <returns>Retourne une collection d'agence</returns>
        private ArtisteDAO()
        {
        }

        public List<Artiste> GetLesArtistes()
        {
            //Déclaration des variable de travail

            int id, idCourantArtistique;
            string leNom, leSite, leLibelleCourant;
            Artiste unArtiste;
            CourantArtistique leCourantArtistique;

            List<Artiste> lesArtistes = new List<Artiste>();
            SqlCommand command = Command.GetObjCommande();

            //On clear le cache
            command.Parameters.Clear();

            // on indique que l'on va appeler une procédure stockée
            command.CommandType = CommandType.StoredProcedure;

            // on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
            command.CommandText = "GetLesArtistes";

            SqlDataReader reader = command.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Artiste que l'on ajoute dans la collection lesArtistes

            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out id);
                int.TryParse(reader["id_CourantArtistique"].ToString(), out idCourantArtistique);

                //Etant donné que le nom peut contenir des valeurs null, on doit remplacer la valeur null par la chaîne vide
                if (reader["Nom de l'artiste"] == DBNull.Value)
                {
                    leNom = default(string);
                }
                else
                {
                    leNom = reader["Nom de l'artiste"].ToString();
                }
                //---------------------------------------------------\\
                if (reader["Le site web"] == DBNull.Value)
                {
                    leSite = default(string);
                }
                else
                {
                    leSite = reader["Le site web"].ToString();
                }
                //---------------------------------------------------\\
                if (reader["Le courant artistique"] == DBNull.Value)
                {
                    leLibelleCourant = default(string);
                }
                else
                {
                    leLibelleCourant = reader["Le courant artistique"].ToString();
                }
                //---------------------------------------------------\\
                
                leCourantArtistique = new CourantArtistique(idCourantArtistique, leLibelleCourant);
                //On crée un artiste
                unArtiste = new Artiste(id,leNom, leSite, leCourantArtistique);
                //On ajoute l'artiste dans la liste
                lesArtistes.Add(unArtiste);
            }
            //On ferme le DataReader
            reader.Close();
            //On ferme la connexion
            command.Connection.Close();
            // On retourne la collection
            return lesArtistes;
        }

        public int AddArtiste(Artiste unArtiste)
        {
            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "AddArtiste";

            laCom.Parameters.Add("Nom", SqlDbType.VarChar);
            laCom.Parameters["Nom"].Value = unArtiste.Nom;
            laCom.Parameters.Add("SiteWeb", SqlDbType.VarChar);
            laCom.Parameters["SiteWeb"].Value = unArtiste.SitWeb;
            laCom.Parameters.Add("IdCourantArtistique", SqlDbType.VarChar);
            laCom.Parameters["IdCourantArtistique"].Value = unArtiste.UnCourantArtistique.Id;

            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;

        }

        public List<Artiste> GetLesArtistes()
        {
            int id, idCourantArtistique;
            string nom, sitWeb, libelleCourant;
            CourantArtistique leCourantArtistique;
            Artiste unArtiste;

            List<Artiste> lesArtistes = new List<Artiste>();

            SqlCommand command = Command.GetObjCommande();

            //Nettoie le cache
            command.Parameters.Clear();

            command.CommandText = "GetLesArtistes";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out id);
                int.TryParse(reader["id_CourantArtistique"].ToString(), out idCourantArtistique);

                if (reader["Nom de l'artiste"]== DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = reader["Nom de l'artiste"].ToString();
                }

                if(reader ["Le site web"] ==DBNull.Value)
                {
                    sitWeb = default(string);
                }
                else
                {
                    sitWeb = reader["Le site web"].ToString();
                }

                if(reader["Le courant artistique"]==DBNull.Value)
                {
                    libelleCourant = default(string);
                }
                else
                {
                    libelleCourant = reader["Le courant artistique"].ToString();
                }
                leCourantArtistique = new CourantArtistique(idCourantArtistique, libelleCourant);
                unArtiste = new Artiste(id, nom, sitWeb, leCourantArtistique);
                lesArtistes.Add(unArtiste);
            }

            //Fermeture du lecteur
            reader.Close();

            //Fermerture de la connexion
            command.Connection.Close();
            return lesArtistes;
        }

        public int UpdateArtiste(Artiste unArtiste)
        {
            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "UpdateArtiste";
            laCom.Parameters.Add("Id", SqlDbType.VarChar);
            laCom.Parameters["Id"].Value = unArtiste.Id;
            laCom.Parameters.Add("Nom", SqlDbType.VarChar);
            laCom.Parameters["Nom"].Value = unArtiste.Nom;
            laCom.Parameters.Add("SiteWeb", SqlDbType.VarChar);
            laCom.Parameters["SiteWeb"].Value = unArtiste.SitWeb;
            laCom.Parameters.Add("IdCourantArtistique", SqlDbType.VarChar);
            laCom.Parameters["IdCourantArtistique"].Value = unArtiste.UnCourantArtistique.Id;

            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;

        }

        public Artiste GetUnArtisteId(int idArtiste)
        {
            string nom;
            string siteWeb;
            string sonCourant;
            CourantArtistique unCourantArtisitque;
            Artiste unArtiste = null;

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand command = Command.GetObjCommande();

            command.Parameters.Clear();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            command.CommandText = "GetLesArtistesId";

            command.Parameters.Add("IdArtiste", System.Data.SqlDbType.Int);
            command.Parameters["IdArtiste"].Value = idArtiste;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nom = reader["nom"].ToString();
                siteWeb = reader["siteWeb"].ToString();
                sonCourant = reader["courant artistique"].ToString();

                //On créer un courant artistique
                unCourantArtisitque = new CourantArtistique(sonCourant);
                //On crée un artiste
                unArtiste = new Artiste(nom, siteWeb, unCourantArtisitque);
            }

            //On ferme le DataReader
            reader.Close();
            //On ferme la connexion
            command.Connection.Close();
            //On retourne la collection
            return unArtiste;
        }


    }
}
