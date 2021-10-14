using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
     public class CategorieVIPManager
    {
        private static CategorieVIPManager uneInstance;

        public static CategorieVIPManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CategorieVIPManager();
            }
            return uneInstance;
        }

        private CategorieVIPManager()
        {

        }



        public List<CategorieVIP> GetLesCategsVIP()
        {
            List<CategorieVIP> lesCategsVIP = new List<CategorieVIP>();
            return CategorieVIPDAO.GetInstance().GetLesCategsVIP();
        }



    }
}
