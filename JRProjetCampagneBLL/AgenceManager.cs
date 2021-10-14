using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public class AgenceManager
    {
        private static AgenceManager uneInstance;

        // cette méthode crée un objet de la classe AgenceManager s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static AgenceManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AgenceManager();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private AgenceManager()
        {
        }

        //appel de la couche DAL pour récupérer une collection de catégories des agences événementiels
        public List<Agence> GetLesAgencesEvenementiels()
        {
            //Ici, on peut appliquer des règles métier
            return AgenceDAO.GetInstance().GetAgenceEvenementiel();
        }

        //appel de la couche DAL pour récupérer une collection de catégories des agences de communications
        public List<Agence> GetLesAgencesCommunications()
        {
            //Ici, on peut appliquer des règles métier
            return AgenceDAO.GetInstance().GetAgenceCommunication();
        }
    }
}
