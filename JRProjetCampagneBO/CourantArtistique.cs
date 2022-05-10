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

        public CourantArtistique(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        //public CourantArtistique(string libelle)
        //{
            //this.libelle = libelle;
        //}


        public CourantArtistique(int id)
        {
            this.id = id;
        }

        public CourantArtistique(string libelle)
        {
            this.libelle = libelle;
        }



        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }


    }
}
