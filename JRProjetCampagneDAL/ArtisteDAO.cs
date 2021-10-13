using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class ArtisteDAO
    {
        private static ArtisteDAO uneInstance;

          public static ArtisteDAO GetInstance()
          {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteDAO();
            }
            return uneInstance;
          }

        private ArtisteDAO()
        {

        }


    }
}
