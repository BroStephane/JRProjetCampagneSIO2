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
        // cette méthode crée un objet de la classe artistesDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// Cette méthode crée un objet de la classe artistesDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static ArtisteManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteManager();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private ArtisteManager()
        {

        }

        //appel de la couche DAL pour récupérer une collection de artistes
        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de artistes
        /// </summary>
        /// <returns>Retourne une collection d'artistess</returns>
        public List<Artiste> GetLesArtistes()
        {
            return ArtisteDAO.GetInstance().GetLesArtistes();
        }

        //appel de la couche DAL pour créer une nouvelle artistes
        /// <summary>
        /// Appel de la couche pour créer une nouvelle artistes
        /// </summary>
        /// <param name="sonNom">le nom</param>
        /// <param name="sonSite">le site</param>
        /// <param name="sonIdCourantArtistique">unIdCourantArtistique</param>
        /// <returns>retourne un objet artistes contenant tous ses attributs </returns>

        public int AddArtististe(string nom, string siteWeb, int idCourantArtistique)
        {
            CourantArtistique unCourantArtistique = new CourantArtistique(idCourantArtistique);

            Artiste unArtiste = new Artiste(nom, siteWeb, unCourantArtistique);

            return ArtisteDAO.GetInstance().AddArtiste(unArtiste);

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

        public int DeleteArtiste(int idArtiste)
        {
            Artiste unArtiste = new Artiste(idArtiste);
            return ArtisteDAO.GetInstance().DeleteArtiste(unArtiste);
        }

    }
}
