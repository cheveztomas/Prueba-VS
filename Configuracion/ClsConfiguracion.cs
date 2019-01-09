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
            string conexion = "Data Source = 35.202.83.220; Initial Catalog = PAGINA_WEB; User Id = root; Password = 1234; ";
            return conexion;
        }
    }
}
