namespace WinFormsApp1
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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 4;
            label1.Text = "Person Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 108);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 5;
            label2.Text = "Father's Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 188);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 6;
            label3.Text = "DateOfBirth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 258);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Preferences";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(346, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(346, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            comboBox1.Items.Add("Investments");
            comboBox1.Items.Add("Savings");
             

            // 
            // button1
            // 
            button1.Location = new Point(299, 344);
            button1.Name = "button1";
            button1.Size = new Size(197, 34);
            button1.TabIndex = 10;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "My First App";
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
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button1;
    }
}
