﻿using JRProjetCampagneBO;
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
        //Fonction d'ajout d'un Artiste
        //Elle va récuperer l'objet responsable de la connexion à la bd, en suite elle est responsable de la création de l'obet qui contient la requet
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

        public string GetArtiste(Artiste unArtiste)
        {
            // Récupérer l'objet responsable de la connexion à la db
            SqlCommand laCom = Command.GetObjCommande();
            SqlDataReader leLecteur;

            // on indique que l'on va appeler une procédure stockée
            laCom.CommandType = CommandType.StoredProcedure;

            // Nettoie le 'cache'
            laCom.Parameters.Clear();

            // Créer l'objet qui contient la requête INSERT
            laCom.CommandText = "GetArtiste";
            //
            leLecteur = laCom.ExecuteReader();
            //
            DataTable lesArtistes = new DataTable();
            
        }


    }
}
