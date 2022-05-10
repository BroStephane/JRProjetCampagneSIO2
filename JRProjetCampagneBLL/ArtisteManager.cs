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

        /// <summary>
        /// Appel de la couche DAL pour récupérer l'instance d'un artiste grâce à l'id passé en paramètre 
        /// </summary>
        /// <param name="idChoixArtiste"></param>
        /// <returns></returns>
        public Artiste GetUnArtisteId(int idChoixArtiste)
        {
            return ArtisteDAO.GetInstance().GetUnArtisteId(idChoixArtiste);
        }

        /// <summary>
        /// Appel de la couche DAL pour mettre à jour un artiste en passant une instance de l'artiste avec les attributs à mettre à jour
        /// </summary>
        /// <param name="idChoixArtiste">id de l'artiste</param>
        /// <param name="nomChoixArtiste">nom de l'artiste</param>
        /// <param name="siteChoixArtiste">site de l'artiste</param>
        /// <param name="idChoixCourant">id du courant artistique</param>
        /// <returns></returns>
        public int UpdateArtiste(int idChoixArtiste, string sonLibelle, string sonSite, int idChoixCourant)
        {
            CourantArtistique unCourant;
            unCourant = new CourantArtistique(idChoixCourant);
            Artiste unArtiste;
            unArtiste = new Artiste(idChoixArtiste, sonLibelle, sonSite, unCourant);
            return ArtisteDAO.GetInstance().UpdateArtiste(unArtiste);
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



    }
}
