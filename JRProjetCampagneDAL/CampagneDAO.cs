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

        // cette méthode crée un objet de la classe CampagneDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static CampagneDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private CampagneDAO()
        {
        }

        //création de la campagne
        public int AddCampagne(Campagne uneCampagne)
        {
            //on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommand();

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

        public List<Campagne> GetCampagnes()
        {
            int id;
            string libelle;

            List<Campagne> lesCampagnes = new List<Campagne>();

            //Recupère l'objet commande et ouvre la connexion à la BDD
            SqlCommand command = Command.GetObjCommande();

            // Nettoie le 'cache'
            command.Parameters.Clear();

            command.CommandText = "exec GetCampagnesListeDeroulante";
            SqlDataReader monLecteur = command.ExecuteReader();

            while (monLecteur.Read())
            {


                int.TryParse(monLecteur["id"].ToString(), out id);

                if (monLecteur["libelle"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["libelle"].ToString();
                }

                lesCampagnes.Add(new Campagne(id, libelle));
            }
            // Fermeture du lecteur
            monLecteur.Close();

            // Fermeture de la connexion
            command.Connection.Close();

            return lesCampagnes;
        }
    }
}
