using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Notebook;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Save_click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        string fileName = saveFileDialog1.FileName;
        File.WriteAllText(fileName, textBox1.Text);
    }

    private void Load_click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        string filename = openFileDialog1.FileName;
        string fileText = File.ReadAllText(filename);
        textBox1.Text = fileText;
    }

    private void textBox2_TextChanged(object sender, EventArgs e) { }

    private void FindButton_Click(object sender, EventArgs e)
    {
        int pos = textBox1.Text.IndexOf(textBox2.Text);
        textBox1.Select(pos, pos + textBox2.Text.Length);
        textBox1.Focus();
    }
}
