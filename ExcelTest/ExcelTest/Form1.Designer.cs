namespace ExcelTest
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 35);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 35);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 26);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 2;
            label1.Text = "Write To Cell Row :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 121);
            label2.Name = "label2";
            label2.Size = new Size(177, 30);
            label2.TabIndex = 3;
            label2.Text = "Write To Cell Col :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 225);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 4;
            label3.Text = "String write to cell";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 35);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(109, 314);
            button1.Name = "button1";
            button1.Size = new Size(168, 34);
            button1.TabIndex = 6;
            button1.Text = "Write to Cell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 383);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(170, 35);
            textBox4.TabIndex = 7;
            //textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 384);
            button2.Name = "button2";
            button2.Size = new Size(192, 34);
            button2.TabIndex = 8;
            button2.Text = "Read Back Value:";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Button button2;
    }
}
