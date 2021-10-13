using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    class ArtisteManager
    {
        private static ArtisteManager uneInstance;
        public static ArtisteManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteManager();
            }
            return uneInstance;
        }

        private ArtisteManager()
        {

        }

        public List<Artiste> AddArtiste()
        {
            List<Artiste> lesArtiste = new List<Artiste>();
            return ArtisteDAO.GetInstance().AddArtiste();

        }

    }
}
