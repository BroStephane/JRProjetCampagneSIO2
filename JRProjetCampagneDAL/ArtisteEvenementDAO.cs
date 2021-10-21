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
        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private ArtisteEvenementDAO()
        {

        }
    }
}
