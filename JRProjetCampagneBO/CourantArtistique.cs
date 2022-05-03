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
        private string leLibelle;

        public CourantArtistique(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public CourantArtistique(int id)
        {
            this.id = id;
        }

        public CourantArtistique(string leLibelle, int leIdCourArtistique)
        {
            this.leLibelle = leLibelle;
        }

        public CourantArtistique(string leLibelle)
        {
            this.leLibelle = leLibelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

    }
}
