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

          public static ArtisteDAO GetInstance()
          {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteDAO();
            }
            return uneInstance;
          }

        private ArtisteDAO()
        {

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

            laCom.Parameters.Add("nom", SqlDbType.VarChar);
            laCom.Parameters["nom"].Value = unArtiste.Nom;
            laCom.Parameters.Add("sitWeb", SqlDbType.VarChar);
            laCom.Parameters["siteWeb"].Value = unArtiste.SitWeb;
            laCom.Parameters.Add("id_CourantArtistique", SqlDbType.VarChar);
            laCom.Parameters["id_CourantArtistique"].Value = unArtiste.UnCourantArtistique.Id;

            // Exécuter la requête + Return
            int nb = laCom.ExecuteNonQuery();

            // Fermeture de la connexion
            laCom.Connection.Close();
            return nb;

        }


    }
}
