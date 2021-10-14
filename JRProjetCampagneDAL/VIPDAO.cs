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




    }
}
