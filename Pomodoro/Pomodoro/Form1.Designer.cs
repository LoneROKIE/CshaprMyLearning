namespace Pomodoro
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            groupBox1 = new GroupBox();
            labelhoras = new Label();
            labelMinutos = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 339);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(113, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Session";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(labelhoras);
            groupBox1.Controls.Add(labelMinutos);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pomodoro !!!";
            // 
            // labelhoras
            // 
            labelhoras.AutoSize = true;
            labelhoras.Location = new Point(85, 125);
            labelhoras.Name = "labelhoras";
            labelhoras.Size = new Size(50, 20);
            labelhoras.TabIndex = 3;
            labelhoras.Text = "label2";
            // 
            // labelMinutos
            // 
            labelMinutos.AutoSize = true;
            labelMinutos.Location = new Point(63, 242);
            labelMinutos.Name = "labelMinutos";
            labelMinutos.Size = new Size(50, 20);
            labelMinutos.TabIndex = 1;
            labelMinutos.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "TIMER";
            // 
            // button2
            // 
            button2.Location = new Point(161, 339);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 2;
            button2.Text = "Stop Session";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(314, 339);
            button3.Name = "button3";
            button3.Size = new Size(113, 29);
            button3.TabIndex = 3;
            button3.Text = "Pause Session";
            button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label labelMinutos;
        private System.Windows.Forms.Timer timer1;
        private Label labelhoras;
    }
}
