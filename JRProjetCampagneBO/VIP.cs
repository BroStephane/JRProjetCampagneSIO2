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

        public VIP(string nom, string rue, string mail, Ville uneVille)
        {
            this.nom = nom;
            this.rue = rue;
            this.mail = mail;
            this.uneVille = uneVille;
        }

        public VIP(int id, string nom, string rue, string mail, Ville uneVille)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.mail = mail;
            this.uneVille = uneVille;
        }
    }
}
