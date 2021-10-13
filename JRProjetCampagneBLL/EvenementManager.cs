using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetEvenementBLL
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

        //public int AddEvenement(DateTime dateDebut, DateTime dateFin, )
        //{

        //}


    }
}
