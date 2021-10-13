using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class CourantArtistique
    {
        private int id;
        private string libelle;
        private Artiste unArtiste;

        public CourantArtistique(int id, string libelle, Artiste unArtiste)
        {
            this.id = id;
            this.libelle = libelle;
            this.unArtiste = unArtiste;
        }

        public CourantArtistique(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public Artiste UnArtiste { get => unArtiste; set => unArtiste = value; }


    }
}
