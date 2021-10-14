using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class Theme
    {
        int id;
        string libelle;

        public Theme(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public Theme(int id)
        {
            this.id = id;
            
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    
        
    
    }
}
