using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class EmployeDAO
    {
        private static EmployeDAO uneInstance;

        // cette méthode crée un objet de la classe EmployeDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// cette méthode crée un objet de la classe EmployeDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static EmployeDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EmployeDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private EmployeDAO()
        {
        }

        // la méthode GetEmployes retourne une collection contenant les employes
        // existant dans la table Employe
        /// <summary>
        /// la méthode GetEmployes retourne une collection contenant les employes existant dans la table Employe
        /// </summary>
        /// <returns>Retourne une collection des employes</returns>
        public List<Employe> GetEmploye()
        {
            int num;
            string sonNom;
            string sonPrenom;
            Employe unEmploye;

            // on crée la collection lesEmployes de type List<Employe> qui va contenir les
            // employés enregistrés dans la base de donnes
            List<Employe> lesEmployes = new List<Employe>();

            // on récupère l'objet responsable de la connexion à la base
            SqlCommand maCommand = Command.GetObjCommande();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesEmployesListeDeroulante";
            SqlDataReader reader = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Employe que l'on ajoute dans la collection lesEmployes
            while (reader.Read())
            {
                int.TryParse(reader["id"].ToString(), out num);

                //étant donné que le libelle peut contenir des valeurs null, on doit remplacer la valeur null par la chaîne vide
                if (reader["nom"] == DBNull.Value)
                {
                    sonNom = default(string);
                }
                else
                {
                    sonNom = reader["nom"].ToString();
                }

                if (reader["prenom"] == DBNull.Value)
                {
                    sonPrenom = default(string);
                }
                else
                {
                    sonPrenom = reader["prenom"].ToString();
                }


                //on crée un employe
                unEmploye = new Employe(num, sonNom, sonPrenom);

                //on ajoute à la liste lesEmployes
                lesEmployes.Add(unEmploye);
            }

            // on ferme le DataReader
            reader.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesEmployes;
        }
    }
}
