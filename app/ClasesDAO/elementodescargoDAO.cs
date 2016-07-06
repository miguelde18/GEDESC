using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GEDESC.ClasesDAO
{
    class elementodescargoDAO
    {

        //Búsqueda por Sistema, Descargo Tipo e Instalación
        

        public static void descargoTipo()
        {
            using (MySqlConnection conn = app.BDconexion.ObtenerConexion())
            {
                //Indicar si es descargo tipo

                /*Alumno pAlumno = new Alumno();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id, Nombre,  Apellido, Direccion, Fecha_nacimiento from Alumnos where Id={0}", pId), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pAlumno.Id = reader.GetInt64(0);
                    pAlumno.Nombre = reader.GetString(1);
                    pAlumno.Apellido = reader.GetString(2);
                    pAlumno.Direccion = reader.GetString(3);
                    pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));



                }
                conexion.Close();
                return pAlumno;*/

            }

        }
    }
}
