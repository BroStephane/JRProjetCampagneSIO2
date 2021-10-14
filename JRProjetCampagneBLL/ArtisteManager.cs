using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public  class ArtisteManager
    {
        private static ArtisteManager uneInstance;
        public static ArtisteManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteManager();
            }
            return uneInstance;
        }

        private ArtisteManager()
        {

        }

        public int AddArtististe(string nom, string siteWeb, int idCourantArtistique)
        {
            CourantArtistique unCourantArtistique = new CourantArtistique(idCourantArtistique);

            Artiste unArtiste = new Artiste(nom, siteWeb, unCourantArtistique);

            return ArtisteDAO.GetInstance().AddArtiste(unArtiste);

        }

    }
}
