using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class ArtisteEvenement
    {
        private Artiste idArtiste;
        private Evenement idEvenement;
        private float cachet;

        public ArtisteEvenement(Artiste idArtiste, Evenement idEvenement, float cachet)
        {
            this.idArtiste = idArtiste;
            this.idEvenement = idEvenement;
            this.cachet = cachet;
        }

        public ArtisteEvenement(Artiste idArtiste, Evenement idEvenement)
        {
            this.idArtiste = idArtiste;
            this.idEvenement = idEvenement;
        }
        public Artiste IdArtiste { get => idArtiste; set => idArtiste = value; }
        public Evenement IdEvenement { get => idEvenement; set => idEvenement = value; }
        public float Cachet { get => cachet; set => cachet = value; }
    }


}
