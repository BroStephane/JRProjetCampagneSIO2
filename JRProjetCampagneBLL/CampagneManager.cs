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

        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private CampagneManager()
        {
        }

        /// <summary>
        /// Appel de la couche DAL pour créer une nouvelle campagne en passant une instance de la classe Campagne avec tous ses attributs
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
        /// Appel de la couche DAL pour récupérer une collection des libelles des campagnes
        /// </summary>
        /// <returns>retourne une collection de campagnes</returns>
        public List<Campagne> GetCampagnes()
        {
            List<Campagne> lesCampagnes = new List<Campagne>();
            return CampagneDAO.GetInstance().GetCampagnes();
        }

        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection des campagnes et leurs caractéristiques
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
        /// Appel de la couche DAL pour mettre à jour une campagne en passant une instance de la campagne avec les attributs à mettre à jour
        /// </summary>
        /// <param name="idChoixCampagne">l'id de la campagne</param>
        /// <param name="sonLibelle">le libelle de la campagne</param>
        /// <param name="saDateDebut">la date de début de la campagne</param>
        /// <param name="saDateFin">la date de fin de la campagne</param>
        /// <param name="sonObjectif">l'objectif de la campagne</param>
        /// <param name="idChoixEmploye">l'employé de la campagne</param>
        /// <param name="idChoixAgenceEvenementiel">l'agence événementielle de la campagne</param>
        /// <param name="idChoixAgenceCommunication">l'agence de communication de la campagne</param>
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

        /// <summary>
        /// Appel de la couche DAL pour supprimer une campagne en passant une instance de la campagne contenant l'id de la campagne à supprimer
        /// </summary>
        /// <param name="idChoixCampagne">l'id de la campagne</param>
        /// <returns></returns>
        public int DeleteCampagne(int idChoixCampagne)
        {
            Campagne laCampagne = new Campagne(idChoixCampagne);
            return CampagneDAO.GetInstance().DeleteCampagne(laCampagne);
        }

    }
}
