using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Ville
    {
        private int numero_insee;
        private string nom;

        //Les propriétés pour gérer les attributs
        public int Numero_insee { get => numero_insee; set => numero_insee = value; }
        public string Nom { get => nom; set => nom = value; }

        //Constructeur permettant de valoriser les 2 attributs
        public Ville(int numero_insee, string nom)
        {
            this.numero_insee = numero_insee;
            this.nom = nom;
        }
        //Constructeur permettant de valoriser l'attribut numero_insee
        public Ville(int numero_insee)
        {
            this.numero_insee = numero_insee;
        }
    }
}
