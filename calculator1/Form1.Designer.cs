namespace calculator1
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(61, 152);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(116, 237);
            label3.Name = "label3";
            label3.Size = new Size(33, 35);
            label3.TabIndex = 2;
            label3.Text = "=";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(149, 295);
            button1.Name = "button1";
            button1.Size = new Size(86, 70);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(264, 295);
            button2.Name = "button2";
            button2.Size = new Size(86, 70);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.Location = new Point(264, 380);
            button3.Name = "button3";
            button3.Size = new Size(86, 70);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(149, 380);
            button4.Name = "button4";
            button4.Size = new Size(86, 70);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.Location = new Point(45, 380);
            button5.Name = "button5";
            button5.Size = new Size(86, 70);
            button5.TabIndex = 8;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(45, 295);
            button6.Name = "button6";
            button6.Size = new Size(86, 65);
            button6.TabIndex = 9;
            button6.Text = "form 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 502);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
