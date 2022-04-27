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
    public class InvitationVIPDAO
    {

        private static InvitationVIPDAO uneInstance;

        // cette méthode crée un objet de la classe InvitationVIPDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// Cette méthode crée un objet de la classe InvitationVIPDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static InvitationVIPDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new InvitationVIPDAO();
            }
            return uneInstance;
        }

        /// <summary>
        /// Ajoute une Invitation dans la table InvitationVIP de la base de données
        /// </summary>
        /// <param name="unVIP"></param>
        /// <param name="unEvenement"></param>
        /// <returns></returns>
        public int AddInvitationVIP(VIP unVIP, Evenement unEvenement)
        {

            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "AddInvitationVIP";

            laCom.Parameters.Add("id_VIP", SqlDbType.Int);
            laCom.Parameters["id_VIP"].Value = unVIP.Id;
            laCom.Parameters.Add("id_Evenement", SqlDbType.Int);
            laCom.Parameters["id_Evenement"].Value = unEvenement.Id;


            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;




        }



    }
}
