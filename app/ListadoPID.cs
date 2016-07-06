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
    public partial class ListadoPID : Form
    {
        public ListadoPID()
        {
            InitializeComponent();
        }

        public planosid plano { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = ClasesDAO.planosidDAO.buscarPID();
            /*dataGridView1.DataSource = planosidDAO(txtNombre.Text, txtApellido.Text);*/
        }

        private void CargarTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClasesDAO.planosidDAO.buscarPID();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            PID p = new PID();
            p.Show();
            //this.Close();
        }

        private void BuscarPID_Click(object sender, EventArgs e)
        {
            /*String plano = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                plano = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                //Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
              
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Plano");
            }*/
            MessageBox.Show(textBox1.Text);
            dataGridView1.DataSource = ClasesDAO.planosidDAO.buscarPIDporTexto(textBox1.Text);
        }

        


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { 
                MessageBox.Show(textBox1.Text);
                dataGridView1.DataSource = ClasesDAO.planosidDAO.buscarPIDporTexto(textBox1.Text);
            }
        }

        private void SeleccionarPID_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Int32 Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    MessageBox.Show(Id.ToString());
                    plano = app.ClasesDAO.planosidDAO.obtenerPlano(Id);
                    MessageBox.Show(plano.datapid);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Aun no ha seleccionado Ningun plano");
                }

            
        }
    }
}
