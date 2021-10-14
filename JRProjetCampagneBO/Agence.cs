using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Agence
    {
        private int id;
        private string nom;
        private string rue;
        private string telephone;
        private string emailContact;
        private string siteWeb;
        private char typeAgence;
        private Ville uneVille;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string EmailContact { get => emailContact; set => emailContact = value; }
        public string SiteWeb { get => siteWeb; set => siteWeb = value; }
        public char TypeAgence { get => typeAgence; set => typeAgence = value; }
        public Ville UneVille { get => uneVille; set => uneVille = value; }

        public Agence(int id, string nom, string rue, string telephone, string emailContact, string siteWeb, char typeAgence, Ville uneVille)
        {
            this.Id = id;
            this.Nom = nom;
            this.Rue = rue;
            this.Telephone = telephone;
            this.EmailContact = emailContact;
            this.SiteWeb = siteWeb;
            this.TypeAgence = typeAgence;
            this.UneVille = uneVille;
        }

        public Agence(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public Agence(int id)
        {
            this.Id = id;
        }

    }
}
