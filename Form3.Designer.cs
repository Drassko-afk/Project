namespace WinFormsApp1
{
    partial class Form3
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(471, 90);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 12);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите вопрос";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(471, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(471, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(471, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(64, 267);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(471, 27);
            textBox5.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 173);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 206);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 239);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(41, 272);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(17, 16);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 145);
            label2.Name = "label2";
            label2.Size = new Size(381, 20);
            label2.TabIndex = 10;
            label2.Text = "Введите вариант ответа и укажите правильный ответ";
            // 
            // button1
            // 
            button1.Location = new Point(171, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Вставить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(284, 398);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Вставить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(23, 450);
            button3.Name = "button3";
            button3.Size = new Size(165, 29);
            button3.TabIndex = 11;
            button3.Text = "Предыдущий вопрос";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 375);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 12;
            label3.Text = "Видеофайл";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 375);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 13;
            label4.Text = "Аудиофайл";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 375);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 14;
            label5.Text = "Изображение";
            // 
            // button4
            // 
            button4.Location = new Point(45, 398);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Вставить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(234, 450);
            button5.Name = "button5";
            button5.Size = new Size(178, 29);
            button5.TabIndex = 11;
            button5.Text = "Закончить (сохранить)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(454, 450);
            button6.Name = "button6";
            button6.Size = new Size(178, 29);
            button6.TabIndex = 11;
            button6.Text = "Следующий вопрос";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 491);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}