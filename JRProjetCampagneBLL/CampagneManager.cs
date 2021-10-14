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
        private CampagneManager()
        {
        }

        //appel de la couche DAL pour créer une nouvelle campagne
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

        public List<Campagne> GetCampagnes()
        {
            List<Campagne> lesCampagnes = new List<Campagne>();
            return CampagneDAO.GetInstance().GetCampagnes();

        }
    }
}
