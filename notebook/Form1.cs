using System.Windows.Forms;

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

}
