using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRProjetCampagneDAL;

namespace JRProjetEvenementBLL
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


        public List<Theme> GetThemes()
        {
            List<Theme> lesThemes = new List<Theme>();
            return ThemeDAO.GetInstance().GetThemes();

        }
     }
}
