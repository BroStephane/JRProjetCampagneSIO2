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
    public class EvenementDAO
    {
        private static EvenementDAO uneInstance;

        public static EvenementDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementDAO();
            }
            return uneInstance;
        }
        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private EvenementDAO() { }

        /// <summary>
        /// Retourne une liste d'événements 
        /// </summary>
        /// <returns></returns>
        public List<Evenement> GetLesEvenements()
        {
            int id, idTheme, idCampagne;
            DateTime dateDeb;
            DateTime dateFin;
            string libelleTheme, libelleCampagne;
            Theme leTheme;
            Campagne laCampagne;
            Evenement unEv;

            List<Evenement> lesEvenements = new List<Evenement>();

            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "GetLesEvenements";
            
            SqlDataReader monLecteur = command.ExecuteReader();

            while (monLecteur.Read())
            {


                int.TryParse(monLecteur["id"].ToString(), out id);
                int.TryParse(monLecteur["id_Theme"].ToString(), out idTheme);
                int.TryParse(monLecteur["id_Campagne"].ToString(), out idCampagne);

                DateTime.TryParse(monLecteur["dateDebut"].ToString(), out dateDeb);
                DateTime.TryParse(monLecteur["dateFin"].ToString(), out dateFin);


                if (monLecteur["libelleTheme"] == DBNull.Value)
                {
                    libelleTheme = default(string);
                }
                else
                {
                    libelleTheme = monLecteur["libelleTheme"].ToString();
                }
                if (monLecteur["libelleCampagne"] == DBNull.Value)
                {
                    libelleCampagne = default(string);
                }
                else
                {
                    libelleCampagne = monLecteur["libelleCampagne"].ToString();
                }

                leTheme = new Theme(idTheme, libelleTheme);

                laCampagne = new Campagne(idCampagne, libelleCampagne);

                unEv = new Evenement(id, dateDeb, dateFin, leTheme, laCampagne);

                lesEvenements.Add(unEv);
                
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesEvenements;

        }

        /// <summary>
        /// Ajoute un événement dans la table Evenement de la base de données
        /// </summary>
        /// <param name="unEvenement"></param>
        /// <returns></returns>
        public int AddEvenement(Evenement unEvenement)
        {
            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "AddEvenement";

            laCom.Parameters.Add("dateDebut", SqlDbType.DateTime);
            laCom.Parameters["dateDebut"].Value = unEvenement.DateDebut;
            laCom.Parameters.Add("dateFin", SqlDbType.DateTime);
            laCom.Parameters["dateFin"].Value = unEvenement.DateFin;
            laCom.Parameters.Add("id_Theme", SqlDbType.Int);
            laCom.Parameters["id_Theme"].Value = unEvenement.UnTheme.Id;
            laCom.Parameters.Add("id_Campagne", SqlDbType.Int);
            laCom.Parameters["id_Campagne"].Value = unEvenement.UneCampagne.Id;


            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;

        }

    }
}
