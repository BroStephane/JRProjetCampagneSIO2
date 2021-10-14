using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRProjetCampagneDAL
{
    static public class Command
    {

        private static SqlCommand objCommande;

        static Command()
        {
            SqlConnection objConnex = new SqlConnection();
           objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["GSB"].ConnectionString;

            objCommande = new SqlCommand("", objConnex);
            objCommande.CommandType = CommandType.StoredProcedure;
        }

        public static SqlCommand GetObjCommande()
        {
            if (objCommande.Connection.State == System.Data.ConnectionState.Closed)
            {
                objCommande.Connection.Open();
            }
            return objCommande;
        }

        public static void CloseConnexion()
        {
            if (objCommande.Connection != null && objCommande.Connection.State != System.Data.ConnectionState.Closed)
            {
                objCommande.Connection.Close();
            }
        }



    }
}
