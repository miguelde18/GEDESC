using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GEDESC.ClasesDAO
{
    class descargoDAO
    {

        //Listado de todos los descargos
        public static List<app.descargo> listadoDescargos()
        {
            List<app.descargo> l = new List<app.descargo>();
            using (MySqlConnection conn = app.BDconexion.ObtenerConexion())
            {
                MySqlCommand cmd1 = new MySqlCommand(string.Format(
                    "SELECT IDDESCARGO, CODDESCARGO, DESCARGOTIPO FROM descargos"), conn);

                MySqlDataReader reader = cmd1.ExecuteReader();


                while (reader.Read())
                {

                    app.descargo p = new app.descargo();
                    p.iddescargo = reader.GetInt16(0);
                    p.coddescargo = reader.GetString("CODDESCARGO");
                    p.descargotipo = reader.GetInt32(2);

                    l.Add(p);
                }
                conn.Close();
                return l;
            }
        }

        public static List<app.descargo> buscarDescargoporSistema(String sistema, int dt, String inst)
        {
            List<app.descargo> l = new List<app.descargo>();
            using (MySqlConnection conn = app.BDconexion.ObtenerConexion())
            {
                MySqlCommand cmd1 = new MySqlCommand(string.Format(
                    "SELECT descargos.CODDESCARGO FROM elementopid, elementodescargo, descargos WHERE elementodescargo.TAG = elementopid.TAG AND elementopid.SISTEMA = '%{0}%' AND descargos.CODDESCARGO = elementodescargo.CODDESCARGO AND descargos.DESCARGOTIPO = {1} AND elementopid.INSTALACION = '{2}'", sistema, dt, inst), conn);

                MySqlDataReader reader = cmd1.ExecuteReader();


                while (reader.Read())
                {

                    app.descargo p = new app.descargo();
                    //p.idpid = reader.GetInt16(0);
                    p.coddescargo = reader.GetString("CODDESCARGO");
                    //p.datapid = reader.GetString(2);

                    l.Add(p);
                }
                conn.Close();
                return l;
            }
        }

        //Búsqueda por TAG, Descargo Tipo e Instalación
        public static List<app.descargo> buscarDescargoporTag(String tag, int dt)
        {
            List<app.descargo> l = new List<app.descargo>();
            using (MySqlConnection conn = app.BDconexion.ObtenerConexion())
            {
                MySqlCommand cmd1 = new MySqlCommand(string.Format(
                    "SELECT descargos.CODDESCARGO FROM elementodescargo, descargos where elementodescargo.TAG LIKE '%{0}%' AND descargos.CODDESCARGO = elementodescargo.CODDESCARGO AND descargos.DESCARGOTIPO = {1}", tag, dt), conn);

                MySqlDataReader reader = cmd1.ExecuteReader();


                while (reader.Read())
                {

                    app.descargo p = new app.descargo();
                    //p.idpid = reader.GetInt16(0);
                    p.coddescargo = reader.GetString("CODDESCARGO");
                    //p.datapid = reader.GetString(2);

                    l.Add(p);
                }
                conn.Close();
                return l;
            }

        }

        public static app.descargo obtenerDescargo(Int32 idplano)
        {

            using (MySqlConnection conn = app.BDconexion.ObtenerConexion())
            {

                app.descargo desc = new app.descargo();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "SELECT `IDDESCARGO`,`CODDESCARGO`,`DESCARGOTIPO` FROM `descargos` WHERE `IDDESCARGO` ={0}", idplano), conn);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    desc.iddescargo = reader.GetInt32("IDDESCARGO");
                    desc.coddescargo = reader.GetString("CODDESCARGO");
                    desc.descargotipo = reader.GetInt16("DESCARGOTIPO");




                }
                conn.Close();
                return desc;

            }
        }
    }
}
