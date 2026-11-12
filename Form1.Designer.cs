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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Title = new Label();
            SecuringFolder = new Button();
            textBox1 = new TextBox();
            PasswordLabel = new Label();
            ChosingPathButton = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            PasswordConfirmation = new Label();
            ReinsertPasswordText = new TextBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(88, 15);
            Title.TabIndex = 0;
            Title.Text = "Folder securing";
            Title.Click += Title_Click;
            // 
            // SecuringFolder
            // 
            SecuringFolder.Location = new Point(13, 127);
            SecuringFolder.Name = "SecuringFolder";
            SecuringFolder.Size = new Size(114, 23);
            SecuringFolder.TabIndex = 1;
            SecuringFolder.Text = "Secure folder";
            SecuringFolder.UseVisualStyleBackColor = true;
            SecuringFolder.Click += SecuringFolder_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(13, 40);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(82, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Add password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // ChosingPathButton
            // 
            ChosingPathButton.Location = new Point(252, 127);
            ChosingPathButton.Name = "ChosingPathButton";
            ChosingPathButton.Size = new Size(132, 23);
            ChosingPathButton.TabIndex = 4;
            ChosingPathButton.Text = "Chose path for folder";
            ChosingPathButton.UseVisualStyleBackColor = true;
            ChosingPathButton.Click += ChosingPathButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // PasswordConfirmation
            // 
            PasswordConfirmation.AutoSize = true;
            PasswordConfirmation.Location = new Point(-2, 72);
            PasswordConfirmation.Name = "PasswordConfirmation";
            PasswordConfirmation.Size = new Size(102, 15);
            PasswordConfirmation.TabIndex = 7;
            PasswordConfirmation.Text = "Reinsert password";
            // 
            // ReinsertPasswordText
            // 
            ReinsertPasswordText.Location = new Point(104, 69);
            ReinsertPasswordText.Name = "ReinsertPasswordText";
            ReinsertPasswordText.Size = new Size(302, 23);
            ReinsertPasswordText.TabIndex = 8;
            ReinsertPasswordText.TextChanged += ReinsertPasswordText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 173);
            Controls.Add(ReinsertPasswordText);
            Controls.Add(PasswordConfirmation);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(ChosingPathButton);
            Controls.Add(PasswordLabel);
            Controls.Add(textBox1);
            Controls.Add(SecuringFolder);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Folder securing";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button SecuringFolder;
        private TextBox textBox1;
        private Label PasswordLabel;
        private Button ChosingPathButton;
        private TextBox textBox2;
        private Label label3;
        private Label PasswordConfirmation;
        private TextBox ReinsertPasswordText;
    }
}
