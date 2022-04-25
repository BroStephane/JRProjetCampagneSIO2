using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Evenement
    {
        int id;
        string libelle;
        DateTime dateDebut;
        DateTime dateFin;
        Theme unTheme;
        Campagne uneCampagne;
        Artiste unArtiste;

        public Evenement(int id)
        {
            this.id = id;
        }

        public Evenement(int id, string libelle)
        {
            this.id = id;
            this.Libelle = libelle;
        }

        public Evenement(DateTime dateDebut, DateTime dateFin, Theme unTheme, Campagne uneCampagne)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.unTheme = unTheme;
            this.uneCampagne = uneCampagne;
           
        }

        public Evenement(int id, DateTime dateDebut, DateTime dateFin, Theme unTheme, Campagne uneCampagne)
        {
            this.id = id;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.unTheme = unTheme;
            this.uneCampagne = uneCampagne;
           
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public Theme UnTheme { get => unTheme; set => unTheme = value; }
        public Campagne UneCampagne { get => uneCampagne; set => uneCampagne = value; }
        public Artiste UnArtiste { get => unArtiste; set => unArtiste = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public string libTheme { get => unTheme.Libelle; }

        public string libCampagne { get => uneCampagne.Libelle; }

        public string leLib { get => libCampagne + " - " + libTheme + " du " + DateDebut.ToString("dd/MM/yyyy") + " au " + DateFin.ToString("dd/MM/yyyy"); }

    }
}
