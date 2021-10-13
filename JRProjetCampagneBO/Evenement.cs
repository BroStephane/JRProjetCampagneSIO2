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
        DateTime dateDebut;
        DateTime dateFin;
        Theme unTheme;
        Campagne uneCampagne;
        Artiste unArtiste;

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
    }
}
