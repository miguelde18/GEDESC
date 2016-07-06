namespace app
{
    partial class ListadoPID
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SeleccionarPID = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CargarTodos = new System.Windows.Forms.Button();
            this.BuscarPID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1072, 661);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SeleccionarPID
            // 
            this.SeleccionarPID.Location = new System.Drawing.Point(802, 37);
            this.SeleccionarPID.Name = "SeleccionarPID";
            this.SeleccionarPID.Size = new System.Drawing.Size(169, 46);
            this.SeleccionarPID.TabIndex = 1;
            this.SeleccionarPID.Text = "Seleecionar PID";
            this.SeleccionarPID.UseVisualStyleBackColor = true;
            this.SeleccionarPID.Click += new System.EventHandler(this.SeleccionarPID_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(977, 37);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(169, 46);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(71, 38);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(72, 13);
            this.text1.TabIndex = 3;
            this.text1.Text = "BUSCAR PID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // CargarTodos
            // 
            this.CargarTodos.Location = new System.Drawing.Point(282, 63);
            this.CargarTodos.Name = "CargarTodos";
            this.CargarTodos.Size = new System.Drawing.Size(121, 21);
            this.CargarTodos.TabIndex = 5;
            this.CargarTodos.Text = "Cargar Todos";
            this.CargarTodos.UseVisualStyleBackColor = true;
            this.CargarTodos.Click += new System.EventHandler(this.CargarTodos_Click);
            // 
            // BuscarPID
            // 
            this.BuscarPID.Location = new System.Drawing.Point(161, 63);
            this.BuscarPID.Name = "BuscarPID";
            this.BuscarPID.Size = new System.Drawing.Size(121, 21);
            this.BuscarPID.TabIndex = 6;
            this.BuscarPID.Text = "Buscar";
            this.BuscarPID.UseVisualStyleBackColor = true;
            this.BuscarPID.Click += new System.EventHandler(this.BuscarPID_Click);
            // 
            // ListadoPID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 830);
            this.Controls.Add(this.BuscarPID);
            this.Controls.Add(this.CargarTodos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.SeleccionarPID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoPID";
            this.Text = "ListadoPID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SeleccionarPID;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CargarTodos;
        private System.Windows.Forms.Button BuscarPID;
    }
}