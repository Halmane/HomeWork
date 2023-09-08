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
            SaveTxt = new SaveFileDialog();
            OpenTxt = new OpenFileDialog();
            TxtFile = new RichTextBox();
            FindTxt = new RichTextBox();
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
            // OpenTxt
            // 
            OpenTxt.FileName = "OpenTxt";
            // 
            // TxtFile
            // 
            TxtFile.Location = new Point(3, 29);
            TxtFile.Name = "TxtFile";
            TxtFile.Size = new Size(792, 420);
            TxtFile.TabIndex = 5;
            TxtFile.Text = "";
            // 
            // FindTxt
            // 
            FindTxt.Location = new Point(123, 2);
            FindTxt.Name = "FindTxt";
            FindTxt.Size = new Size(278, 21);
            FindTxt.TabIndex = 6;
            FindTxt.Text = "";
            FindTxt.TextChanged += Find;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FindTxt);
            Controls.Add(TxtFile);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SaveButton;
        private Button LoadButton;
        private SaveFileDialog SaveTxt;
        private OpenFileDialog OpenTxt;
        private RichTextBox TxtFile;
        private RichTextBox FindTxt;
    }
}