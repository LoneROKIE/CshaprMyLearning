namespace PracticaTcpServer
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
            btnEncender = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxIdentificacion = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido1 = new TextBox();
            textBoxApellido2 = new TextBox();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(12, 63);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(94, 29);
            btnEncender.TabIndex = 0;
            btnEncender.Text = "Encender";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += btnEncender_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(403, 311);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 127);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 187);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 241);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 293);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Apellido 2";
            // 
            // textBoxIdentificacion
            // 
            textBoxIdentificacion.Location = new Point(610, 123);
            textBoxIdentificacion.Name = "textBoxIdentificacion";
            textBoxIdentificacion.Size = new Size(125, 27);
            textBoxIdentificacion.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(610, 180);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellido1
            // 
            textBoxApellido1.Location = new Point(610, 234);
            textBoxApellido1.Name = "textBoxApellido1";
            textBoxApellido1.Size = new Size(125, 27);
            textBoxApellido1.TabIndex = 8;
            // 
            // textBoxApellido2
            // 
            textBoxApellido2.Location = new Point(610, 286);
            textBoxApellido2.Name = "textBoxApellido2";
            textBoxApellido2.Size = new Size(125, 27);
            textBoxApellido2.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(591, 355);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Persona";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(765, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(525, 319);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Controls.Add(textBoxApellido2);
            Controls.Add(textBoxApellido1);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxIdentificacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnEncender);
            Name = "Form1";
            Text = "TcpServer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncender;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxIdentificacion;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido1;
        private TextBox textBoxApellido2;
        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}