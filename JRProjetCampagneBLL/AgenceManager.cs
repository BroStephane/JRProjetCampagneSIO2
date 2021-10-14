using JRProjetCampagneDAL;
using JRProjetCampagneBO;
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

        // cette méthode crée un objet de la classe AgenceDAO s'il n'existe pas déjà un
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

        //appel de la couche DAL pour récupérer une collection de agence
        public List<Agence> GetAgences()
        {
            return AgenceDAO.GetInstance().GetAgences();
        }

        //appel de la couche DAL pour créer une nouvelle agence
        public int AddAgence(string sonNom, string saRue, string sonTelephone, string sonEmail, string sonSite, char sontypeAgence, int saVille)
        {
            Ville laVille = new Ville(saVille);
            Agence lAgence;
            lAgence = new Agence(sonNom, saRue, sonTelephone, sonEmail, sonSite, sontypeAgence, laVille);
            return AgenceDAO.GetInstance().AddAgence(lAgence);
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
