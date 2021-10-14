using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRProjetCampagneDAL;
using JRProjetCampagneBO;

namespace JRProjetCampagneBLL
{
    public class VilleManager
    {
        private static VilleManager uneInstance;


        // cette méthode crée un objet de la classe VilleDAO s'il n'existe pas déjà un

        // cette méthode crée un objet de la classe ClientDAO s'il n'existe pas déjà un

        // puis retourne la référence à cet objet
        public static VilleManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleManager();
            }
            return uneInstance;
        }

        public List<Ville> GetLaVille()
        {
            return VilleDAO.GetInstance().GetLaVille();
        }
    }
}
