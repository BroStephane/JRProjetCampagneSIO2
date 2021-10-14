using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public class VIPManager
    {
        private static VIPManager uneInstance;

        // cette méthode crée un objet de la classe ClientDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static VIPManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VIPManager();
            }
            return uneInstance;
        }

        public int AddVIP(string nom, string rue, string mail, int numInsee, int categVIP)
        {
            Ville uneVille = new Ville(numInsee);
            CategorieVIP laCategVIP = new CategorieVIP(categVIP);

            VIP unVIP = new VIP(nom, rue, mail, uneVille, laCategVIP);

            return VIPDAO.GetInstance().AddVIP(unVIP);
        }
    }
}
