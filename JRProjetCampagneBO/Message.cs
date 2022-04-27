using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Message
    {
        private int id;
        private string contenu;
        private DateTime date;
        private Evenement unEvenement;
        private CategorieVIP uneCategorieVIP;

        public Message(int id, string contenu, DateTime date, Evenement unEvenement, CategorieVIP uneCategorieVIP)
        {
            this.id = id;
            this.contenu = contenu;
            this.date = date;
            this.unEvenement = unEvenement;
            this.uneCategorieVIP = uneCategorieVIP;
        }
        public Message( string contenu, DateTime date, Evenement unEvenement, CategorieVIP uneCategorieVIP)
        {
            
            this.contenu = contenu;
            this.date = date;
            this.unEvenement = unEvenement;
            this.uneCategorieVIP = uneCategorieVIP;
        }

        public int Id { get => id; set => id = value; }
        public string Contenu { get => contenu; set => contenu = value; }
        public DateTime Date { get => date; set => date = value; }
        public Evenement UnEvenement { get => unEvenement; set => unEvenement = value; }
        public CategorieVIP UneCategorieVIP { get => uneCategorieVIP; set => uneCategorieVIP = value; }
    }
}
