using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JRProjetCampagneBO
{
    /// <summary>
    /// Classe publique de la table Campagne de la base de données GSB 
    /// </summary>
    public class Campagne
    {
        /// <summary>
        /// Les attributs de la classe Campagne
        /// </summary>
        private int id;
        private string libelle;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string objectif;
        private Employe unEmploye;
        private Agence uneAgenceEvenementiel;
        private Agence uneAgenceCommunication;

        /// <summary>
        /// Les propriétés des attibuts de la classe Campagne
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public string Objectif { get => objectif; set => objectif = value; }
        public Employe UnEmploye { get => unEmploye; set => unEmploye = value; }
        public Agence UneAgenceEvenementiel { get => uneAgenceEvenementiel; set => uneAgenceEvenementiel = value; }
        public Agence UneAgenceCommunication { get => uneAgenceCommunication; set => uneAgenceCommunication = value; }
        public string unEmployeIdentite { get => unEmploye.Identite; } 
        public string uneAgenceEvenementielNom { get => uneAgenceEvenementiel.Nom; }
        public string uneAgenceCommunicationNom { get => uneAgenceCommunication.Nom; }


        
        /// <summary>
        /// le constructeur valorisant tous les attributs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="objectif"></param>
        /// <param name="unEmploye"></param>
        /// <param name="uneAgenceEvenementiel"></param>
        /// <param name="uneAgenceCommunication"></param>
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
        /// <summary>
        /// le constructeur valorisant le libelle, la dateDbut, la dateFin, l'objectif, unEmploye, uneAgenceEvenementiel et uneAgenceCommunication
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="objectif"></param>
        /// <param name="unEmploye"></param>
        /// <param name="uneAgenceEvenementiel"></param>
        /// <param name="uneAgenceCommunication"></param>
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

        /// <summary>
        /// le constructeur valorisant l'id et le libelle
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Campagne(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        /// <summary>
        /// le constructeur valorisant l'id
        /// </summary>
        /// <param name="id"></param>
        public Campagne(int id)
        {
            this.id = id;

        }

    }
}
