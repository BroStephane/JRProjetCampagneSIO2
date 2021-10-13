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
        private EvenementDAO() { }



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
