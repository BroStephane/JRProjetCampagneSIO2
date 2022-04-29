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


        /// <summary>
        /// appel de la couche DAL pour récupérer une collection des campagnes
        /// </summary>
        /// <returns>Retourne une collection de toutes les campagnes de la base de données</returns>
        public List<Artiste> GetLesArtistes()
        {
            //Ici, on peut appliquer des règles métier
            return ArtisteDAO.GetInstance().GetLesArtistes();
        }

        public int UpdateArtiste(int idArtiste,string nom, string siteWeb, int idCourantArtistique)
        {


            CourantArtistique unCourantArtistique = new CourantArtistique(idCourantArtistique);

            Artiste unArtiste = new Artiste(idArtiste,nom, siteWeb, unCourantArtistique);

            return ArtisteDAO.GetInstance().UpdateArtiste(unArtiste);
        }

        public Artiste GetUnArtisteId(int idArtiste)
        {
            return ArtisteDAO.GetInstance().GetUnArtisteId(idArtiste);
        }

    }
}
