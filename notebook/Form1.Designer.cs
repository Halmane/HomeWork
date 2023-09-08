namespace Notebook
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
            SaveButton = new Button();
            LoadButton = new Button();
            FindButton = new Button();
            textBox1 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(54, 21);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += Save_click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(63, 2);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(54, 21);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += Load_click;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(455, 2);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(54, 21);
            FindButton.TabIndex = 2;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(793, 420);
            textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(FindButton);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Button LoadButton;
        private Button FindButton;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox2;
    }
}