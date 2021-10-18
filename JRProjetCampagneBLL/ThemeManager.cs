using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRProjetCampagneDAL;

namespace JRProjetCampagneBLL
{
    public class ThemeManager
    {
        private static ThemeManager uneInstance;

        public static ThemeManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ThemeManager();
            }
            return uneInstance;
        }

        private ThemeManager()
        {

        }

        /// <summary>
        /// Fait appel à ThemeDAO et retourne une list de thème
        /// </summary>
        /// <returns></returns>
        public List<Theme> GetThemes()
        {
            List<Theme> lesThemes = new List<Theme>();
            return ThemeDAO.GetInstance().GetThemes();

        }
     }
}
