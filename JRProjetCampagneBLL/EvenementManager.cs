using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public class EvenementManager
    {
        private static EvenementManager uneInstance;

        public static EvenementManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementManager();
            }
            return uneInstance;
        }

        private EvenementManager()
        {

        }
        /// <summary>
        /// Créer un objet Theme, un objet Campagne et un objet Evenement avec les données reçu. Puis fait appel à EvenementDAO
        /// </summary>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="idTheme"></param>
        /// <param name="idCampagne"></param>
        /// <returns></returns>
        public int AddEvenement(DateTime dateDebut, DateTime dateFin, int idTheme, int idCampagne)
        {
            Theme unTheme = new Theme(idTheme);
            Campagne uneCampagne = new Campagne(idCampagne);

            Evenement unEvenement = new Evenement(dateDebut, dateFin, unTheme, uneCampagne);

            return EvenementDAO.GetInstance().AddEvenement(unEvenement);

        }


    }
}
