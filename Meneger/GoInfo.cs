using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mainlib;

namespace Meneger
{
    public partial class GoInfo : Form
    {
        public GoInfo(Player player)
        {
            
            InitializeComponent();
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.AutoSize = false;

            label2.Text = player.Name;
        }

        private void GoInfo_Load(object sender, EventArgs e)
        {

        }

        private void GoInfo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(BackGround.final, new Point(0, 0));
        }

        private void GoInfo_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.MayComputerGo = 4;
            Close();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label2.Left = this.Width / 2 - label2.Width / 2;
        }
    }
}
