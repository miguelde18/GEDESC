using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            //Inicio combobox1
            List<app.instalacion> l = GEDESC.ClasesDAO.instalacionDAO.nInstalacion();
            int n = l.Count;
            String inst;
            //MessageBox.Show(n.ToString());
            for (int i = 0; i < n; i++)
            {
                inst = l[i].nombreinstalacion;
                comboBox1.Items.Add(inst);
            }

            dataGridView1.DataSource = GEDESC.ClasesDAO.descargoDAO.listadoDescargos();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Búsqueda por TAG y Descargo Tipo
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int dt = 0;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //MessageBox.Show(textBox1.Text);
                if (checkBox1.Checked)
                {
                    dt = 1;
                }
                //MessageBox.Show(dt.ToString());
                dataGridView1.DataSource =GEDESC.ClasesDAO.descargoDAO.buscarDescargoporTag(textBox1.Text, dt);
            }
        }

        //Búsqueda por Sistema y Descargo Tipo
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int dt = 0;
            String inst = "XXX";
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //MessageBox.Show(textBox2.Text);
                if (checkBox1.Checked)
                {
                    dt = 1;
                }
                //MessageBox.Show(dt.ToString());
                //MessageBox.Show(inst);
                inst = (string) comboBox1.SelectedItem;

                //MessageBox.Show(inst);
                dataGridView1.DataSource = GEDESC.ClasesDAO.descargoDAO.buscarDescargoporSistema(textBox2.Text, dt, inst);
            }
        }

       

     
    
        private void listadoDescargos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GEDESC.ClasesDAO.descargoDAO.listadoDescargos();
        }

        public descargo desc { get; set; }

        private void abrir(object sender, EventArgs e)
        {
            
        }

    

        private void salida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apertura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int32 Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show(Id.ToString());
                desc = GEDESC.ClasesDAO.descargoDAO.obtenerDescargo(Id);
                PID pid = new PID();
                pid.descargoActual = desc;
                pid.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun descargo");
            }
        }

        
        private void nuevoDescargo_Click(object sender, EventArgs e)
        {
            PID p = new PID();
            p.ShowDialog();
            this.Close();
        }

        
    }
}
