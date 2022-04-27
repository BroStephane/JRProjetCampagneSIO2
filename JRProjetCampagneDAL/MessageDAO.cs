using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JRProjetCampagneBO;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class MessageDAO
    {

        private static MessageDAO uneInstance;


        /// <summary>
        /// Cette méthode crée un objet de la classe MessageDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static MessageDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new MessageDAO();
            }
            return uneInstance;
        }

        /// <summary>
        /// Ajoute une Invitation dans la table Message de la base de données
        /// </summary>
        /// <param name="unMessage"></param>
        /// <returns></returns>
        public int AddMessage(Message unMessage)
        {

            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "AddMessage";


            laCom.Parameters.Add("contenu", SqlDbType.VarChar);
            laCom.Parameters["contenu"].Value = unMessage.Contenu;
            laCom.Parameters.Add("date", SqlDbType.DateTime);
            laCom.Parameters["date"].Value = unMessage.Date;
            laCom.Parameters.Add("id_CategVIP", SqlDbType.Int);
            laCom.Parameters["id_CategVIP"].Value = unMessage.UneCategorieVIP.Id;
            laCom.Parameters.Add("id_Evenement", SqlDbType.Int);
            laCom.Parameters["id_Evenement"].Value = unMessage.UnEvenement.Id;
            
            


            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;




        }

    }
}
