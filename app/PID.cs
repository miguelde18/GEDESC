using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace app
{
    public partial class PID : Form
    {
        public PID()
        {
            InitializeComponent();
            
            //Inicialización con descargo elegido
            if (descargoActual != null)
            {
                MessageBox.Show(descargoActual.coddescargo);
                MessageBox.Show("sigue por aqui");

            }



        }

        public planosid planoActual{ get; set; }
        public descargo descargoActual { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoPID pid = new ListadoPID();
            pid.ShowDialog();

            if (pid.plano != null)
            {
                planoActual = pid.plano;

                OpenFileDialog ofd1 = new OpenFileDialog();
                MessageBox.Show(pid.plano.datapid);
                ofd1.FileName = pid.plano.datapid;
                PIDSeleccionado.src = ofd1.FileName;


                /*btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;*/

            }
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
