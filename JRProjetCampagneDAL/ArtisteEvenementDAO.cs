using JRProjetCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    public class ArtisteEvenementDAO
    {
        private static ArtisteEvenementDAO uneInstance;

        public static ArtisteEvenementDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteEvenementDAO();
            }
            return uneInstance;
        }

        private ArtisteEvenementDAO()
        {

        }
    }
}
