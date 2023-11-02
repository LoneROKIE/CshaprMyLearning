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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnEncender);
            Name = "Form1";
            Text = "TcpServer";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEncender;
        private RichTextBox richTextBox1;
    }
}