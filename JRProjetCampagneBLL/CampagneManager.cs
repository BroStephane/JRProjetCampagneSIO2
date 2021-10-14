using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetEvenementBLL
{
    public class CampagneManager
    {
        private static CampagneManager uneInstance;

        public static CampagneManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneManager();
            }
            return uneInstance;
        }

        private CampagneManager()
        {

        }

        public List<Campagne> GetCampagnes()
        {
            List<Campagne> lesCampagnes = new List<Campagne>();
            return CampagneDAO.GetInstance().GetCampagnes();

        }
    }
}
