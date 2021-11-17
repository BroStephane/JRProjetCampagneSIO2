using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public class CampagneManager
    {
        private static CampagneManager uneInstance;

        // cette méthode crée un objet de la classe CampagneManager s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        /// <summary>
        /// cette méthode crée un objet de la classe CampagneManager s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static CampagneManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneManager();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private CampagneManager()
        {
        }

        //appel de la couche DAL pour créer une nouvelle campagne
        /// <summary>
        /// Appel de la couche DAL pour créer une nouvelle campagne
        /// </summary>
        /// <param name="sonLibelle">le libelle</param>
        /// <param name="saDateDebut">la date de début</param>
        /// <param name="saDateFin">la date de fin</param>
        /// <param name="sonObjectif">l'objectif</param>
        /// <param name="idChoixEmploye">le choix id de l'employe</param>
        /// <param name="idChoixAgenceEvenementiel">le choix id de l'agence évènementiel</param>
        /// <param name="idChoixAgenceCommunication">le choix id de l'agence de communication</param>
        /// <returns>Retourne un objet Campagne contenant tous les paramètres</returns>
        public int CreateCampagne(string sonLibelle, DateTime saDateDebut, DateTime saDateFin, string sonObjectif, int idChoixEmploye, int idChoixAgenceEvenementiel, int idChoixAgenceCommunication)
        {
            Employe unEmploye;
            unEmploye = new Employe(idChoixEmploye);
            Agence uneAgenceEvenementiel;
            uneAgenceEvenementiel = new Agence(idChoixAgenceEvenementiel);
            Agence uneAgenceCommunication;
            uneAgenceCommunication = new Agence(idChoixAgenceCommunication);
            Campagne laCampagne;
            laCampagne = new Campagne(sonLibelle, saDateDebut, saDateFin, sonObjectif, unEmploye, uneAgenceEvenementiel, uneAgenceCommunication);
            return CampagneDAO.GetInstance().AddCampagne(laCampagne);
        }

        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de campagnes
        /// </summary>
        /// <returns>retourne une collection de campagnes</returns>
        public List<Campagne> GetCampagnes()
        {
            List<Campagne> lesCampagnes = new List<Campagne>();
            return CampagneDAO.GetInstance().GetCampagnes();
        }

        /// <summary>
        /// appel de la couche DAL pour récupérer une collection des campagnes
        /// </summary>
        /// <returns>Retourne une collection de toutes les campagnes de la base de données</returns>
        public List<Campagne> GetLesCampagnes()
        {
            //Ici, on peut appliquer des règles métier
            return CampagneDAO.GetInstance().GetLesCampagnes();
        }

        /// <summary>
        /// Appel de la couche DAL pour récupérer l'instance d'une campagne grâce à l'id passé en paramètre 
        /// </summary>
        /// <param name="idChoixCampagne"></param>
        /// <returns></returns>
        public Campagne GetUneCampagneId(int idChoixCampagne)
        {
            return CampagneDAO.GetInstance().GetUneCampagneId(idChoixCampagne);
        }

        /// <summary>
        /// Appel de la couche DAL pour mettre à jour une campagne
        /// </summary>
        /// <param name="idChoixCampagne"></param>
        /// <param name="sonLibelle"></param>
        /// <param name="saDateDebut"></param>
        /// <param name="saDateFin"></param>
        /// <param name="sonObjectif"></param>
        /// <param name="idChoixEmploye"></param>
        /// <param name="idChoixAgenceEvenementiel"></param>
        /// <param name="idChoixAgenceCommunication"></param>
        /// <returns></returns>
        public int UpdateCampagne(int idChoixCampagne, string sonLibelle, DateTime saDateDebut, DateTime saDateFin, string sonObjectif, int idChoixEmploye, int idChoixAgenceEvenementiel, int idChoixAgenceCommunication)
        {
            Employe unEmploye;
            unEmploye = new Employe(idChoixEmploye);
            Agence uneAgenceEvenementiel;
            uneAgenceEvenementiel = new Agence(idChoixAgenceEvenementiel);
            Agence uneAgenceCommunication;
            uneAgenceCommunication = new Agence(idChoixAgenceCommunication);
            Campagne laCampagne;
            laCampagne = new Campagne(idChoixCampagne, sonLibelle, saDateDebut, saDateFin, sonObjectif, unEmploye, uneAgenceEvenementiel, uneAgenceCommunication);
            return CampagneDAO.GetInstance().UpdateCampagne(laCampagne);
        }
    }
}
