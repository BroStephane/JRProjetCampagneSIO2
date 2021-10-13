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
        private string siteWeb;
        private CourantArtistique unCourantArtistique;

        public Artiste(int id, string nom, string siteWeb, CourantArtistique unCourantArtistique)
        {
            this.id = id;
            this.nom = nom;
            this.siteWeb = siteWeb;
            this.unCourantArtistique = unCourantArtistique;
        }

        public Artiste(string nom, string siteWeb)
        {
            this.nom = nom;
            this.siteWeb = siteWeb;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string SitWeb { get => siteWeb; set => siteWeb = value; }
        public CourantArtistique UnCourantArtistique { get => unCourantArtistique; set => unCourantArtistique = value; }
    }
}
