using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GEDESC.ClasesDAO
{
    class instalacionDAO
    {

        public static List<app.instalacion> nInstalacion()
        {
            List<app.instalacion> l = new List<app.instalacion>();
            using (MySqlConnection conn = app.BDconexion.ObtenerConexion())
            {
                MySqlCommand cmd1 = new MySqlCommand(string.Format(
                    "SELECT `NOMBREINSTALACION` FROM `instalacion`"), conn);

                MySqlDataReader reader = cmd1.ExecuteReader();


                while (reader.Read())
                {

                    app.instalacion p = new app.instalacion();
                   
                    p.nombreinstalacion = reader.GetString("NOMBREINSTALACION");
                
                    l.Add(p);
                }
                conn.Close();
                return l;
            }
        }

    }
}
