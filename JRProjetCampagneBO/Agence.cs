using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Agence
    {
        int id;
        string nom;
        string rue;
        string telephone;
        string email;
        string site;
        char typeAgence;
        Ville laVille;
        string sonNom;
        string saRue;
        string sonTelephone;
        string sonEmail;
        string sonSite;
        char sonTypeAgence;
        int saVille;

        //Les propriétés pour gérer les attributs
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Site { get => site; set => site = value; }
        public char TypeAgence { get => typeAgence; set => typeAgence = value; }
        public Ville LaVille { get => laVille; set => laVille = value; }

        //Constructeur permettant de valoriser les 8 attributs
        public Agence(int id, string nom, string rue, string telephone, string email, string site, char typeAgence, Ville laVille)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.telephone = telephone;
            this.email = email;
            this.site = site;
            this.typeAgence = typeAgence;
            this.laVille = laVille;
        }
        //Constructeur permettant de valoriser seulement 7 attributs
        public Agence(string nom, string rue, string telephone, string email, string site, char typeAgence, Ville laVille)
        {
            this.nom = nom;
            this.rue = rue;
            this.telephone = telephone;
            this.email = email;
            this.site = site;
            this.typeAgence = typeAgence;
            this.laVille = laVille;
        }
        //Constructeur permettant de valoriser seulement 7 attributs
        public Agence(string sonNom, string saRue, string sonTelephone, string sonEmail, string sonSite, char sonTypeAgence, int saVille)
        {
            this.sonNom = sonNom;
            this.saRue = saRue;
            this.sonTelephone = sonTelephone;
            this.sonEmail = sonEmail;
            this.sonSite = sonSite;
            this.sonTypeAgence = sonTypeAgence;
            this.saVille = saVille;
        }
    }
}
