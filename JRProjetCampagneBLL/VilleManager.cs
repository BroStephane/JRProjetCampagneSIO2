using System;
using JRProjetCampagneDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRProjetCampagneBO;

namespace JRProjetCampagneBLL
{
    public class VilleManager
    {
        private static VilleManager uneInstance;

        // cette méthode crée un objet de la classe VilleDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static VilleManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleManager();
            }
            return uneInstance;
        }
        //cette méthode retourne les villes
        public List<Ville> GetLaVilleAgence()
        {
            return VilleDAO.GetInstance().GetLaVilleAgence();
        }
    }
}
