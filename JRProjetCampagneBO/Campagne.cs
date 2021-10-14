using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JRProjetCampagneBO
{
    public class Campagne
    {
        private int id;
        private string libelle;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string objectif;
        private Employe unEmploye;
        private Agence uneAgenceEvenementiel;
        private Agence uneAgenceCommunication;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public string Objectif { get => objectif; set => objectif = value; }
        public Employe UnEmploye { get => unEmploye; set => unEmploye = value; }
        public Agence UneAgenceEvenementiel { get => uneAgenceEvenementiel; set => uneAgenceEvenementiel = value; }
        public Agence UneAgenceCommunication { get => uneAgenceCommunication; set => uneAgenceCommunication = value; }


        //premier constructeur pour valoriser tous les attributs
        public Campagne(int id, string libelle, DateTime dateDebut, DateTime dateFin, string objectif, Employe unEmploye, Agence uneAgenceEvenementiel, Agence uneAgenceCommunication)
        {
            this.id = id;
            this.libelle = libelle;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.objectif = objectif;
            this.unEmploye = unEmploye;
            this.uneAgenceEvenementiel = uneAgenceEvenementiel;
            this.uneAgenceCommunication = uneAgenceCommunication;
        }

        //deuxième constructeur pour valoriser le libelle, la dateDbut, la dateFin, objectif et unEmploye
        public Campagne(string libelle, DateTime dateDebut, DateTime dateFin, string objectif, Employe unEmploye, Agence uneAgenceEvenementiel, Agence uneAgenceCommunication)
        {
            this.libelle = libelle;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.objectif = objectif;
            this.unEmploye = unEmploye;
            this.uneAgenceEvenementiel = uneAgenceEvenementiel;
            this.uneAgenceCommunication = uneAgenceCommunication;
        }

        public Campagne(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public Campagne(int id)
        {
            this.id = id;

        }
    }
}
