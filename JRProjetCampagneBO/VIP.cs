using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class VIP
    {
        int id;
        string nom;
        string rue;
        string mail;
        Ville uneVille;
        CategorieVIP uneCategorieVIP;

        public VIP(int id)
        {
            this.id = id;
        }

        public VIP(int id, string nom, string rue, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.mail = mail;
        }

        public VIP(string nom, string rue, string mail, Ville uneVille, CategorieVIP uneCategorieVIP)
        {
            this.nom = nom;
            this.rue = rue;
            this.mail = mail;
            this.uneVille = uneVille;
            this.UneCategorieVIP = uneCategorieVIP;
        }

        public VIP(int id, string nom, string rue, string mail, Ville uneVille)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.mail = mail;
            this.uneVille = uneVille;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Mail { get => mail; set => mail = value; }
        public Ville UneVille { get => uneVille; set => uneVille = value; }
        public CategorieVIP UneCategorieVIP { get => uneCategorieVIP; set => uneCategorieVIP = value; }
    }
}
