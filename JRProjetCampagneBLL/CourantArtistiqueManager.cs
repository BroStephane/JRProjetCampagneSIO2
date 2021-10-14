using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRProjetCampagneDAL;

namespace JRProjetCampagneBLL
{
    public class CourantArtistiqueManager
    {
        private static CourantArtistiqueManager uneInstance;

        public static CourantArtistiqueManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CourantArtistiqueManager();
            }
            return uneInstance;
        }

        private CourantArtistiqueManager()
        {

        }

        public List<CourantArtistique> GetCourantArtistiques()
        {
            List<CourantArtistique> lesCourantArtistiques = new List<CourantArtistique>();
            return CourantArtistiqueDAO.GetInstance().GetCourantArtistiques();

        }

    }
}
