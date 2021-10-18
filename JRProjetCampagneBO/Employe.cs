using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Employe
    {
        /// <summary>
        /// les attributs de la classe Employe
        /// </summary>
        private int id;
        private string nom;
        private string prenom;
        private string pseudo;
        private string password;
        private Service unService;
        private Profil unProfil;

        /// <summary>
        /// les propriétés des attrbibuts de la classe Employe 
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Password { get => password; set => password = value; }
        public Service UnService { get => unService; set => unService = value; }
        public Profil UnProfil { get => unProfil; set => unProfil = value; }
        public string Identite { get => nom + " " + prenom; }

        /// <summary>
        /// le constructeur valorisant tous les attributs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pseudo"></param>
        /// <param name="password"></param>
        /// <param name="unService"></param>
        /// <param name="unProfil"></param>
        public Employe(int id, string nom, string prenom, string pseudo, string password, Service unService, Profil unProfil)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.Pseudo = pseudo;
            this.Password = password;
            this.unService = unService;
            this.unProfil = unProfil;
        }

        /// <summary>
        /// le constructeur valorisant l'id, le nom et prénom
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Employe(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        /// <summary>
        /// le constructeur valorisant l'id
        /// </summary>
        /// <param name="id"></param>
        public Employe(int id)
        {
            this.id = id;
        }
    }
}
