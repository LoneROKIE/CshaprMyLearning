namespace ServerProgram
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
            btnEncenderApagarServidor = new Button();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnEncenderApagarServidor
            // 
            btnEncenderApagarServidor.Location = new Point(12, 70);
            btnEncenderApagarServidor.Name = "btnEncenderApagarServidor";
            btnEncenderApagarServidor.Size = new Size(94, 29);
            btnEncenderApagarServidor.TabIndex = 0;
            btnEncenderApagarServidor.Text = "Encender";
            btnEncenderApagarServidor.UseVisualStyleBackColor = true;
            btnEncenderApagarServidor.Click += btnEncenderApagarServidor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 1;
            label1.Text = "Estado del Servidor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 47);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Apagado";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 115);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(381, 323);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEncenderApagarServidor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncenderApagarServidor;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}