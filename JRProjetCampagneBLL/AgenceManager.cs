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
        /// <summary>
        /// Cette méthode crée un objet de la classe AgenceDAO s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// le constructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
        /// </summary>
        private AgenceManager()
        {

        }

        //appel de la couche DAL pour récupérer une collection de agence
        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de agence
        /// </summary>
        /// <returns>Retourne une collection d'agences</returns>
        public List<Agence> GetAgences()
        {
            return AgenceDAO.GetInstance().GetAgences();
        }
        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de agence
        /// </summary>
        /// <returns>Retourne une collection d'agences</returns>
        public Agence GetUneAgenceId(int idAgence)
        {
            return AgenceDAO.GetInstance().GetUneAgenceId(idAgence);
        }

        //appel de la couche DAL pour créer une nouvelle agence
        /// <summary>
        /// Appel de la couche pour créer une nouvelle agence
        /// </summary>
        /// <param name="sonNom">le nom</param>
        /// <param name="saRue">la rue</param>
        /// <param name="sonTelephone">le numéro de téléphone</param>
        /// <param name="sonEmail">l'email</param>
        /// <param name="sonSite">le site</param>
        /// <param name="sontypeAgence">le type d'agence E ou C</param>
        /// <param name="saVille">la ville</param>
        /// <returns>retourne un objet Agence contenant tous ses attributs </returns>
        public int AddAgence(string sonNom, string saRue, int saVille, string sonTelephone, string sonEmail, string sonSite, char sontypeAgence)

        {
            Ville laVille = new Ville(saVille);
            Agence lAgence;
            lAgence = new Agence(sonNom, saRue, laVille, sonTelephone, sonEmail, sonSite, sontypeAgence);
            return AgenceDAO.GetInstance().AddAgence(lAgence);
        }

        //appel de la couche DAL pour récupérer une collection de catégories des agences événementiels
        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de catégories des agences événementiels
        /// </summary>
        /// <returns>retourne une collection d'agences événementiels</returns>
        public List<Agence> GetLesAgencesEvenementiels()
        {
            //Ici, on peut appliquer des règles métier
            return AgenceDAO.GetInstance().GetAgenceEvenementiel();
        }

        //appel de la couche DAL pour récupérer une collection de catégories des agences de communications
        /// <summary>
        /// Appel de la couche DAL pour récupérer une collection de catégories des agences de communications
        /// </summary>
        /// <returns>Retourne une collection d'agences de communications</returns>
        public List<Agence> GetLesAgencesCommunications()
        {
            //Ici, on peut appliquer des règles métier
            return AgenceDAO.GetInstance().GetAgenceCommunication();
        }
        /// <summary>
        /// Appel de la couche DAL pour modifier une agence
        /// </summary>
        /// <param name="sonNom">le nom</param>
        /// <param name="saRue">la rue</param>
        /// <param name="sonTelephone">le numéro de téléphone</param>
        /// <param name="sonEmail">l'email</param>
        /// <param name="sonSite">le site</param>
        /// <param name="sontypeAgence">le type d'agence E ou C</param>
        /// <param name="saVille">la ville</param>
        /// <returns>retourne un objet Agence contenant tous ses attributs </returns>
        public int UpdateAgence(int idAgence, string sonNom, string saRue, int saVille, string sonTelephone, string sonEmail, string sonSite, char sontypeAgence)

        {
            Ville laVille = new Ville(saVille);
            Agence uneAgence = new Agence(idAgence, sonNom, saRue, laVille, sonTelephone, sonEmail, sonSite, sontypeAgence);
            return AgenceDAO.GetInstance().UpdateAgence(uneAgence);
        }

        /// <summary>
        /// Appel de la couche DAL pour supprimer une agence
        /// </summary>
        /// <param name="idAgence">id</param>
        /// <returns>retourne un objet Agence contenant l'attribut id </returns>
        public int DeleteAgence(int idAgence)
        {
            Agence uneAgence = new Agence(idAgence);
            return AgenceDAO.GetInstance().DeleteAgence(uneAgence);
        }
    }
}
