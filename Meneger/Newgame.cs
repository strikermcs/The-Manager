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
    public partial class Newgame : Form
    {
        Player[] player = new Player[3];
        
        public Newgame()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Start Start = new Start();
            Start.Show();
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                player[i] = new Player();
                player[i].Money = 1500;
                player[i].Position = 0;
                player[i].PositionX = 0;
                player[i].PositionY = 0;

            }
            player[0].CompORUser = true;
            if (comboBox1.SelectedIndex == 0) player[1].CompORUser = true;
            else player[1].CompORUser = false;
            if (comboBox2.SelectedIndex == 0) player[2].CompORUser = true;
            else player[2].CompORUser = false;

            player[0].Name = textBox2.Text;
            player[1].Name = textBox3.Text;
            player[2].Name = textBox4.Text;
           

            Main Main = new Main(player);
            Main.Show();
            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") button1.Enabled = false;
            else button1.Enabled = true;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "") button1.Enabled = false;
            else button1.Enabled = true;
        }
    }
}
