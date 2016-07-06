using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace app.ClasesDAO
{
    public class planosidDAO
    {

        public static planosid obtenerPlano(Int32 idpid)
        {

            using (MySqlConnection conn = BDconexion.ObtenerConexion())
            {

                planosid plano = new planosid();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "SELECT `IDPID`,`CODPID`,`DATAPID` FROM `planosid` WHERE `IDPID` ={0}", idpid), conn);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    plano.idpid = reader.GetInt32("IDPID");
                    plano.codpid = reader.GetString("CODPID");
                    plano.datapid = reader.GetString("DATAPID");
                    



                }
                conn.Close();
                return plano;

            }
        }

        public static List <planosid> buscarPID()
        {
            List <planosid> l = new List<planosid>();
            using (MySqlConnection conn = BDconexion.ObtenerConexion())
            {
                MySqlCommand cmd1 = new MySqlCommand(string.Format(
                    "SELECT IDPID, CODPID, DATAPID FROM planosid"), conn);

                MySqlDataReader reader = cmd1.ExecuteReader();
                
                
                while (reader.Read())
                {
                    
                    planosid p = new planosid();
                    p.idpid = reader.GetInt16("IDPID");
                    p.codpid = reader.GetString("CODPID");
                    p.datapid = reader.GetString("DATAPID");

                    l.Add(p);
                }
                conn.Close();
                return l;
            }
            
        }

        public static planosid buscarPIDporTexto(String texto)
        {
            planosid p = null;
            using (MySqlConnection conn = BDconexion.ObtenerConexion())
            {
                MySqlCommand cmd2 = new MySqlCommand(string.Format(
                    "SELECT CODPID FROM planosid WHERE CODPID LIKE '%{0}%'", texto), conn);

                MySqlDataReader reader = cmd2.ExecuteReader();

                while (reader.Read())
                {
                    p = new planosid();
                    p.codpid = reader.GetString("CODPID"); 
                    
                }
                conn.Close();
                return p;
            }

        }
    }
}
