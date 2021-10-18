using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public class EmployeManager
    {
        private static EmployeManager uneInstance;

        // cette méthode crée un objet de la classe EmployeManager s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// cette méthode crée un objet de la classe EmployeManager s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static EmployeManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EmployeManager();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private EmployeManager()
        {
        }

        //appel de la couche DAL pour récupérer une collection de catégories des clients
        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de catégories des clients
        /// </summary>
        /// <returns>Retourne une collection d'employé (nom + prénom)</returns>
        public List<Employe> GetLesEmployes()
        {
            //Ici, on peut appliquer des règles métier
            return EmployeDAO.GetInstance().GetEmploye();
        }
    }
}
