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

        public List<Evenement> GetLesEvenements()
        {
            return EvenementDAO.GetInstance().GetLesEvenements();
        }


        public Evenement GetUnEvenement(int id)
        {
            Evenement unEvenement = new Evenement(id);
            return EvenementDAO.GetInstance().GetUnEvenement(unEvenement);
        }

        public int DeleteEvenement(int idEvenement)
        {
            Evenement unEvenement = new Evenement(idEvenement);

            return EvenementDAO.GetInstance().DeleteEvenement(unEvenement);

        }


        public int AddEvenement(DateTime dateDebut, DateTime dateFin, int idTheme, int idCampagne)
        {
            Theme unTheme = new Theme(idTheme);
            Campagne uneCampagne = new Campagne(idCampagne);

            Evenement unEvenement = new Evenement(dateDebut, dateFin, unTheme, uneCampagne);

            return EvenementDAO.GetInstance().AddEvenement(unEvenement);

        }
        public int UpdateEvenement(int id, DateTime dateDebut, DateTime dateFin, int idTheme, int idCampagne)
        {
            Theme unTheme = new Theme(idTheme);
            Campagne uneCampagne = new Campagne(idCampagne);

            Evenement unEvenement = new Evenement(id,dateDebut, dateFin, unTheme, uneCampagne);

            return EvenementDAO.GetInstance().UpdateEvenement(unEvenement);
        }

    }
}
