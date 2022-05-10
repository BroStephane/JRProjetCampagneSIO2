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

        public Artiste(string nom, string siteWeb, CourantArtistique unCourantArtistique)
        {
            this.nom = nom;
            this.siteWeb = siteWeb;
            this.unCourantArtistique = unCourantArtistique;
        }
        
        public Artiste(int id)
        {
            this.id = id;
        }


        [System.ComponentModel.Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string SiteWeb { get => siteWeb; set => siteWeb = value; }
        [System.ComponentModel.Browsable(false)]
        public CourantArtistique UnCourantArtistique { get => unCourantArtistique; set => unCourantArtistique = value; }

        public string LibelleCourant { get => unCourantArtistique.Libelle; }

    }
}
