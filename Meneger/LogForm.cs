using System;
using System.Drawing;
using System.Windows.Forms;
using mainlib;
namespace Meneger
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
           
            
        }
        
        public void AddLog(Player player, string Message)
        {
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(player.Name + ":  ");
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText(Message + "; \n\n");
            richTextBox1.ScrollToCaret();
        }

        public void AddLog(Player player, string Title, string Message)
        {
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(player.Name + ":  ");
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText(Title+ ":  ");
            richTextBox1.SelectionColor = Color.DarkSeaGreen;
            richTextBox1.AppendText(Message + "; \n\n");
            richTextBox1.ScrollToCaret();
        }

        public void AddLog(string Title, string Message)
        {
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText(Title + ":  ");
            richTextBox1.SelectionColor = Color.Brown;
            richTextBox1.AppendText(Message + "; \n\n");
            richTextBox1.ScrollToCaret();
        }
    }
}
