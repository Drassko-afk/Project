namespace WinFormsApp1
{
    partial class Form5
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(64, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(655, 104);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(64, 274);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(655, 24);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(64, 304);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(655, 24);
            listBox3.TabIndex = 1;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(64, 334);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(655, 24);
            listBox4.TabIndex = 1;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 20;
            listBox5.Location = new Point(64, 364);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(655, 24);
            listBox5.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 274);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 304);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 334);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(41, 364);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(17, 16);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(186, 409);
            button1.Name = "button1";
            button1.Size = new Size(533, 29);
            button1.TabIndex = 3;
            button1.Text = "Ответить(дальше)";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(25, 409);
            button2.Name = "button2";
            button2.Size = new Size(155, 29);
            button2.TabIndex = 4;
            button2.Text = "Пропустить";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 5;
            label1.Text = "Номер вопроса";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 479);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}