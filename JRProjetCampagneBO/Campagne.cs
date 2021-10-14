using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JRProjetCampagneBO
{
    public class Campagne
    {
        int id;
        string libelle;
        DateTime dateDebut;
        DateTime dateFin;
        string objectif;
        string typeAgence;
        Employe unEmployeResp;

        public Campagne(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public Campagne(int id)
        {
            this.id = id;

        }

        public Campagne(int id, string libelle, DateTime dateDebut, DateTime dateFin, string objectif, string typeAgence)
        {
            this.id = id;
            this.libelle = libelle;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.objectif = objectif;
            this.typeAgence = typeAgence;
        }

        public Campagne(int id, string libelle, DateTime dateDebut, DateTime dateFin, string objectif, string typeAgence, Employe unEmployeResp)
        {
            this.id = id;
            this.libelle = libelle;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.objectif = objectif;
            this.typeAgence = typeAgence;
            this.unEmployeResp = unEmployeResp;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public string Objectif { get => objectif; set => objectif = value; }
        public string TypeAgence { get => typeAgence; set => typeAgence = value; }
        public Employe UnEmployeResp { get => unEmployeResp; set => unEmployeResp = value; }
    }
}
