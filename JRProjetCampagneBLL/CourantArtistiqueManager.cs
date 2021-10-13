using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    class CourantArtistiqueManager
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


    }
}
