using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRProjetCampagneBO;
using JRProjetCampagneDAL;

namespace JRProjetCampagneBLL
{
    public class MessageManager
    {
        private static MessageManager uneInstance;

        public static MessageManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new MessageManager();
            }
            return uneInstance;
        }

        public int AddMessage(string message, DateTime date, int idCategVIP, int idEvenement)
        {
            CategorieVIP uneCateg = new CategorieVIP(idCategVIP);

            Evenement unEvenement = new Evenement(idEvenement);

            Message unMessage = new Message(message, date, unEvenement, uneCateg);

            return MessageDAO.GetInstance().AddMessage(unMessage);

        }
    }
}
