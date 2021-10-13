using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Artiste
    {
        private int id;
        private string nom;
        private string sitWeb;
        private CourantArtistique unCourantArtistique;

        public Artiste(int id, string nom, string sitWeb, CourantArtistique unCourantArtistique)
        {
            this.id = id;
            this.nom = nom;
            this.sitWeb = sitWeb;
            this.unCourantArtistique = unCourantArtistique;
        }

        public Artiste(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string SitWeb { get => sitWeb; set => sitWeb = value; }
        public CourantArtistique UnCourantArtistique { get => unCourantArtistique; set => unCourantArtistique = value; }
    }
}
