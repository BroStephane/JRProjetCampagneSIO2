using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBO
{
    public class InvitationVIP
    {
        private VIP unVIP;
        private Evenement unEvenement;

        public InvitationVIP(VIP unVIP, Evenement unEvenement)
        {
            this.UnVIP = unVIP;
            this.UnEvenement = unEvenement;
        }

        public VIP UnVIP { get => unVIP; set => unVIP = value; }
        public Evenement UnEvenement { get => unEvenement; set => unEvenement = value; }

        public int idVIP { get => unVIP.Id; }
        public int idEvenement { get => UnEvenement.Id; }

    }
}
