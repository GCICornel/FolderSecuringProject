namespace FolderSecuringProject
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
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Folder securing";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 127);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 1;
            button1.Text = "Secure folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Add password";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(252, 127);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 4;
            button2.Text = "Chose path for folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Folder path:";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 173);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Folder securing";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
    }
}
