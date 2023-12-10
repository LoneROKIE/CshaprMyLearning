namespace MainF
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
            label1 = new Label();
            txtId = new TextBox();
            textNombre = new TextBox();
            textApellido1 = new TextBox();
            textApellido2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label6 = new Label();
            btnIniciarServ = new Button();
            richTextBox1 = new RichTextBox();
            labelServ = new Label();
            labelEs = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PERSONA";
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 86);
            txtId.Name = "txtId";
            txtId.Size = new Size(156, 27);
            txtId.TabIndex = 1;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(114, 153);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(125, 27);
            textNombre.TabIndex = 2;
            // 
            // textApellido1
            // 
            textApellido1.Location = new Point(114, 216);
            textApellido1.Name = "textApellido1";
            textApellido1.Size = new Size(125, 27);
            textApellido1.TabIndex = 3;
            // 
            // textApellido2
            // 
            textApellido2.Location = new Point(114, 285);
            textApellido2.Name = "textApellido2";
            textApellido2.Size = new Size(125, 27);
            textApellido2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "ID persona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 160);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 223);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Apellido 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 292);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 8;
            label5.Text = "Apellido 2";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(114, 344);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar Persona";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 188);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(609, 293);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 11;
            button2.Text = "Ver lista de Personas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 46);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 12;
            label6.Text = "Lista Personas";
            // 
            // btnIniciarServ
            // 
            btnIniciarServ.Location = new Point(1008, 16);
            btnIniciarServ.Name = "btnIniciarServ";
            btnIniciarServ.Size = new Size(141, 29);
            btnIniciarServ.TabIndex = 13;
            btnIniciarServ.Text = "Iniciar servidor";
            btnIniciarServ.UseVisualStyleBackColor = true;
            btnIniciarServ.Click += btnIniciarServ_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(938, 86);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(244, 265);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // labelServ
            // 
            labelServ.AutoSize = true;
            labelServ.Location = new Point(920, 25);
            labelServ.Name = "labelServ";
            labelServ.Size = new Size(50, 20);
            labelServ.TabIndex = 15;
            labelServ.Text = "label7";
            // 
            // labelEs
            // 
            labelEs.AutoSize = true;
            labelEs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEs.Location = new Point(815, 17);
            labelEs.Name = "labelEs";
            labelEs.Size = new Size(80, 28);
            labelEs.TabIndex = 16;
            labelEs.Text = "Estado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 395);
            Controls.Add(labelEs);
            Controls.Add(labelServ);
            Controls.Add(richTextBox1);
            Controls.Add(btnIniciarServ);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textApellido2);
            Controls.Add(textApellido1);
            Controls.Add(textNombre);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox textNombre;
        private TextBox textApellido1;
        private TextBox textApellido2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label6;
        private Button btnIniciarServ;
        private RichTextBox richTextBox1;
        private Label labelServ;
        private Label labelEs;
    }
}
