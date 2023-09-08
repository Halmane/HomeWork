using System.Text.RegularExpressions;
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
        if (SaveTxt.ShowDialog() == DialogResult.Cancel)
            return;
        string fileName = SaveTxt.FileName;
        File.WriteAllText(fileName, TxtFile.Text);
    }

    private void Load_click(object sender, EventArgs e)
    {
        if (OpenTxt.ShowDialog() == DialogResult.Cancel)
            return;
        string filename = OpenTxt.FileName;
        string fileText = File.ReadAllText(filename);
        TxtFile.Text = fileText;
    }

    private void Find(object sender, EventArgs e)
    {
        if (FindTxt.TextLength == 0)
            return;
        Regex regex = new Regex(FindTxt.Text);
        MatchCollection matches = regex.Matches(TxtFile.Text);
        TxtFile.SelectAll();
        TxtFile.SelectionBackColor = TxtFile.BackColor;
        foreach (Match match in matches)
        {
            TxtFile.Select(match.Index, match.Length);
            TxtFile.SelectionBackColor = Color.Yellow;
        }
    }
}
