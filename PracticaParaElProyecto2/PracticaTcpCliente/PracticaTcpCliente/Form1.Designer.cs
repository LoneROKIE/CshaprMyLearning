namespace PracticaTcpCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxIdentificacion = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApe1 = new TextBox();
            textBoxApe2 = new TextBox();
            dataGridView1 = new DataGridView();
            buttonConsultarTodosLosClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 35);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 110);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(369, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite la identificacion del cliente que desea consultar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Identificacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 253);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 297);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 7;
            label5.Text = "Apellido 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 341);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 8;
            label6.Text = "Apellido 2";
            // 
            // textBoxIdentificacion
            // 
            textBoxIdentificacion.Enabled = false;
            textBoxIdentificacion.Location = new Point(117, 209);
            textBoxIdentificacion.Multiline = true;
            textBoxIdentificacion.Name = "textBoxIdentificacion";
            textBoxIdentificacion.Size = new Size(179, 32);
            textBoxIdentificacion.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Enabled = false;
            textBoxNombre.Location = new Point(117, 250);
            textBoxNombre.Multiline = true;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(179, 32);
            textBoxNombre.TabIndex = 11;
            // 
            // textBoxApe1
            // 
            textBoxApe1.Enabled = false;
            textBoxApe1.Location = new Point(117, 294);
            textBoxApe1.Multiline = true;
            textBoxApe1.Name = "textBoxApe1";
            textBoxApe1.Size = new Size(179, 32);
            textBoxApe1.TabIndex = 12;
            // 
            // textBoxApe2
            // 
            textBoxApe2.Enabled = false;
            textBoxApe2.Location = new Point(117, 338);
            textBoxApe2.Multiline = true;
            textBoxApe2.Name = "textBoxApe2";
            textBoxApe2.Size = new Size(179, 32);
            textBoxApe2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(430, 188);
            dataGridView1.TabIndex = 14;
            // 
            // buttonConsultarTodosLosClientes
            // 
            buttonConsultarTodosLosClientes.Location = new Point(357, 158);
            buttonConsultarTodosLosClientes.Name = "buttonConsultarTodosLosClientes";
            buttonConsultarTodosLosClientes.Size = new Size(94, 29);
            buttonConsultarTodosLosClientes.TabIndex = 15;
            buttonConsultarTodosLosClientes.Text = "Consultar Clientes";
            buttonConsultarTodosLosClientes.UseVisualStyleBackColor = true;
            buttonConsultarTodosLosClientes.Click += buttonConsultarTodosLosClientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 434);
            Controls.Add(buttonConsultarTodosLosClientes);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxApe2);
            Controls.Add(textBoxApe1);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxIdentificacion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxIdentificacion;
        private TextBox textBoxNombre;
        private TextBox textBoxApe1;
        private TextBox textBoxApe2;
        private DataGridView dataGridView1;
        private Button buttonConsultarTodosLosClientes;
    }
}