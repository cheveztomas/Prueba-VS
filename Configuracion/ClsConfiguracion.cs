using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Configuracion
{
    public class ClsConfiguracion
    {
        public static string getConnectionString()
        {
            string conexion = "Server=35.202.83.220; Database=pagina_web; UID=root; PWD=1234; Port=3306";
            return conexion;
        }
    }
}
