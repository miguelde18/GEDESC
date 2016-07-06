namespace app
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nuevoDescargo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listadoDescargos = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Button();
            this.apertura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(318, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "DESCARGOS TIPO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(845, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 34);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "BÚSQUEDA POR SISTEMA";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 34);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "BÚSQUEDA POR TAG";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nuevoDescargo
            // 
            this.nuevoDescargo.Location = new System.Drawing.Point(119, 72);
            this.nuevoDescargo.Name = "nuevoDescargo";
            this.nuevoDescargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nuevoDescargo.Size = new System.Drawing.Size(173, 35);
            this.nuevoDescargo.TabIndex = 9;
            this.nuevoDescargo.Text = "Nuevo Descargo";
            this.nuevoDescargo.UseVisualStyleBackColor = true;
            this.nuevoDescargo.Click += new System.EventHandler(this.nuevoDescargo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "INSTALACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "INSTALACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "BÚSQUEDA POR TAG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "BÚSQUEDA POR SISTEMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DESCARGOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1215, 657);
            this.dataGridView1.TabIndex = 20;
            // 
            // listadoDescargos
            // 
            this.listadoDescargos.Location = new System.Drawing.Point(318, 135);
            this.listadoDescargos.Name = "listadoDescargos";
            this.listadoDescargos.Size = new System.Drawing.Size(173, 26);
            this.listadoDescargos.TabIndex = 21;
            this.listadoDescargos.Text = "Todos los descargos";
            this.listadoDescargos.UseVisualStyleBackColor = true;
            this.listadoDescargos.Click += new System.EventHandler(this.listadoDescargos_Click);
            // 
            // salida
            // 
            this.salida.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.salida.Location = new System.Drawing.Point(1167, 845);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(162, 44);
            this.salida.TabIndex = 22;
            this.salida.Text = "SALIR";
            this.salida.UseVisualStyleBackColor = true;
            this.salida.Click += new System.EventHandler(this.salida_Click);
            // 
            // apertura
            // 
            this.apertura.Location = new System.Drawing.Point(999, 845);
            this.apertura.Name = "apertura";
            this.apertura.Size = new System.Drawing.Size(162, 44);
            this.apertura.TabIndex = 23;
            this.apertura.Text = "ABRIR";
            this.apertura.UseVisualStyleBackColor = true;
            this.apertura.Click += new System.EventHandler(this.apertura_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 989);
            this.Controls.Add(this.apertura);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.listadoDescargos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nuevoDescargo);
            this.Controls.Add(this.comboBox1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nuevoDescargo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listadoDescargos;
        private System.Windows.Forms.Button salida;
        private System.Windows.Forms.Button apertura;
    }
}