using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private string pseudo;
        private string password;
        private Service unService;
        private Profil unProfil;


        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Password { get => password; set => password = value; }
        public Service UnService { get => unService; set => unService = value; }
        public Profil UnProfil { get => unProfil; set => unProfil = value; }
        public string Identite { get => nom + " " + prenom; }

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

        public Employe(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Employe(int id)
        {
            this.id = id;
        }
    }
}
