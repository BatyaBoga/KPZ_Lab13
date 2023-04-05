namespace KPZ_Lab13
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(276, 316);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 25);
            this.textBox4.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(535, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 25);
            this.textBox6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Joe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Oleh";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(31, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 225);
            this.listBox1.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(276, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 225);
            this.listBox2.TabIndex = 14;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 17;
            this.listBox3.Location = new System.Drawing.Point(535, 31);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(180, 225);
            this.listBox3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}