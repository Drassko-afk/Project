namespace WinFormsApp1
{
    partial class Form7
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
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            checkBox3 = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(664, -1);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 343);
            vScrollBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 33);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 1;
            label1.Text = "Включить режим подсказок";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(53, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(53, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 2;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 56);
            label2.Name = "label2";
            label2.Size = new Size(264, 20);
            label2.TabIndex = 1;
            label2.Text = "Показать ошибки при тестировании";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(53, 79);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 2;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 76);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 1;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 343);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(vScrollBar1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private CheckBox checkBox3;
        private Label label3;
    }
}