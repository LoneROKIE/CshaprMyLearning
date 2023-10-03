namespace Presentacion
{
    partial class Principal1
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            textBoxColor = new TextBox();
            textBoxNombreV = new TextBox();
            textBoxTipo = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(464, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(469, 350);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vehiculos Registrados";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(457, 299);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(textBoxColor);
            groupBox1.Controls.Add(textBoxNombreV);
            groupBox1.Controls.Add(textBoxTipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 350);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Vehiculo";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(93, 279);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(218, 40);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Vehiculo";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(107, 159);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(139, 34);
            textBoxColor.TabIndex = 5;
            // 
            // textBoxNombreV
            // 
            textBoxNombreV.Location = new Point(179, 109);
            textBoxNombreV.Name = "textBoxNombreV";
            textBoxNombreV.Size = new Size(191, 34);
            textBoxNombreV.TabIndex = 4;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Location = new Point(107, 62);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(183, 34);
            textBoxTipo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 168);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 2;
            label3.Text = "Color";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 71);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "TIPO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre Vehiculo";
            // 
            // Principal1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(946, 373);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Principal1";
            Text = "Principal1";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox textBoxColor;
        private TextBox textBoxNombreV;
        private TextBox textBoxTipo;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}