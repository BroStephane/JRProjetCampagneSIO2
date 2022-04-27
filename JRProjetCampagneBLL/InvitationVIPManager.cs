using JRProjetCampagneBO;
using JRProjetCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneBLL
{
    public class InvitationVIPManager
    {
        private static InvitationVIPManager uneInstance;
        
        /// <summary>
        /// Cette méthode crée un objet de la classe InvitationVIPManager s'il n'existe pas déjà un, puis retourne la référence à cet objet
        /// </summary>
        /// <returns></returns>
        public static InvitationVIPManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new InvitationVIPManager();
            }
            return uneInstance;
        }

        public int AddInvitationVIP(int idVIP, int idEvenement)
        {
            VIP leVIP = new VIP(idVIP);
            Evenement lEvenement = new Evenement(idEvenement); 
            return InvitationVIPDAO.GetInstance().AddInvitationVIP(leVIP,lEvenement);
        }
    }
}
