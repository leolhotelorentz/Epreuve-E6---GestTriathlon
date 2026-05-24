using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connexion
    {
        private static string ChaineDeConnexion =
        "Data Source=SRV-SQL\\SQL_SLAM;" + "Initial Catalog=BD_TRIATHLON_GR3;" + "Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ChaineDeConnexion);
        }

        public static bool TesterConnexion()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ChaineDeConnexion))
                {
                    cn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
