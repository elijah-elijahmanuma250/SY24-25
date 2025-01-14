namespace GameOfChance
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(382, 435);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "Spin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 400);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(382, 471);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 3;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(604, 169);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(612, 145);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "number picked ";
            // 
            // button3
            // 
            button3.Location = new Point(615, 204);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 6;
            button3.Text = "Confirm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(632, 341);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 7;
            label2.Text = "bet amount ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(632, 365);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(632, 400);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 9;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Segoe UI", 100F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(26, 100);
            label3.Name = "label3";
            label3.Size = new Size(520, 221);
            label3.TabIndex = 10;
            label3.Text = "1-100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 562);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private Label label2;
        private TextBox textBox3;
        private Button button4;
        private Label label3;
    }
}
