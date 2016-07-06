using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace app
{
    public class BDconexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=appdescargos; Uid=root; pwd=;");
            conexion.Open();
            return conexion;
        }
    }
}
