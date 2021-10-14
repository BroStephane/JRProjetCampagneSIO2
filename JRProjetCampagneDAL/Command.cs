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
        static private SqlCommand objCommand;

        static Command()
        {
            SqlConnection objConnex;
            objConnex = new SqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["GSB"].ConnectionString;
            objCommand = new SqlCommand("", objConnex);
            objCommand.CommandType = CommandType.StoredProcedure;
        }

        public static SqlCommand GetObjCommand()
        {
            //on ouvre la connexion si elle est fermée
            if (objCommand.Connection.State == System.Data.ConnectionState.Closed)
            {
                objCommand.Connection.Open();
            }
            //on retourne l'objet responsable de la connexion
            return objCommand;
        }

        public static void CloseConnexion()
        {
            //si la connexion est ouverte on la ferme
            if (objCommand.Connection != null && objCommand.Connection.State != System.Data.ConnectionState.Closed)
            {
                objCommand.Connection.Close();
            }
        }
    }
}
