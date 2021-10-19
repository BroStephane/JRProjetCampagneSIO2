using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Agence
    {
        /// <summary>
        /// Les attributs de la classe Agence
        /// </summary>
        private int id;
        private string nom;
        private string rue;
        private string telephone;
        private string emailContact;
        private string siteWeb;
        private char typeAgence;
        private Ville uneVille;

        /// <summary>
        /// Les propriétés des attributs de la classe Agence
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string EmailContact { get => emailContact; set => emailContact = value; }
        public string SiteWeb { get => siteWeb; set => siteWeb = value; }
        public char TypeAgence { get => typeAgence; set => typeAgence = value; }
        public Ville UneVille { get => uneVille; set => uneVille = value; }
        public string leNomVille { get => uneVille.Nom; }

        /// <summary>
        /// Le constructeur valorisant tous les attributs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="rue"></param>
        /// <param name="telephone"></param>
        /// <param name="emailContact"></param>
        /// <param name="siteWeb"></param>
        /// <param name="typeAgence"></param>
        /// <param name="uneVille"></param>
        public Agence(int id, string nom, string rue, Ville uneVille , string telephone, string emailContact, string siteWeb, char typeAgence)
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

        /// <summary>
        /// le constructeur valorisant l'id et le nom
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        public Agence(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }
        /// <summary>
        /// le constructeur valorisant l'id
        /// </summary>
        /// <param name="id"></param>
        public Agence(int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// le constructeur valorisant le nom
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        public Agence(string nom)
        {
            this.Nom = nom;
        }

        //Constructeur permettant de valoriser seulement 7 attributs
        /// <summary>
        /// le constructeur valorisant le nom, la rue, le telephone, l'email de contact, le site web, le type d'agence et uneVille
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="rue"></param>
        /// <param name="telephone"></param>
        /// <param name="emailContact"></param>
        /// <param name="siteWeb"></param>
        /// <param name="typeAgence"></param>
        /// <param name="uneVille"></param>
        public Agence(string nom, string rue, Ville uneVille , string telephone, string emailContact, string siteWeb, char typeAgence)
        {
            this.nom = nom;
            this.rue = rue;
            this.telephone = telephone;
            this.emailContact = emailContact;
            this.siteWeb = siteWeb;
            this.typeAgence = typeAgence;
            this.uneVille = uneVille;
        }
    }
}
