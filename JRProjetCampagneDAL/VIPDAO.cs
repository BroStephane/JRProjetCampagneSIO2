using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class VIPDAO
    {
        private static VIPDAO uneInstance;

        // cette méthode crée un objet de la classe ClientDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static VIPDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VIPDAO();
            }
            return uneInstance;
        }


       //public int AddVIP(VIP unVIP)
       // {

       // }




    }
}
