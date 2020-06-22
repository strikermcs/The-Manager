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
    public partial class Auction : Form
    {
        int startPrice;
        Stock stocke;
        Player[] player;
        int FirstIndexPlayer;
        int SecondIndexPlayer;
        int endPrice;
        int firstMoney;
        int secondMoney;
        public Auction(Stock stock,Player[] players)
        {
            InitializeComponent();
            EndAuctiom.Enabled = false;
            stocke = stock;
            player = players;
            startPrice = stock.Price + 10;
            label3.Text = "Стартовая цена лота: " + startPrice.ToString() + " АС";
            SecondPlayerUpPrice.Enabled = false;
            label1.Text = startPrice.ToString()+" АС";
            label2.Text = startPrice.ToString()+" АС";
            firstMoney = startPrice;
            secondMoney = startPrice;
            endPrice = startPrice;

            switch (data.ActivePlayer)
            {
                case 0:
                    FirstplayerUpPrice.Text = player[1].Name + "! Поднимаю +10АС";
                    SecondPlayerUpPrice.Text = player[2].Name + "! Поднимаю +10АС";
                    FirstIndexPlayer = 1;
                    SecondIndexPlayer = 2;

                    break;

                    case 1:
                    FirstplayerUpPrice.Text = player[2].Name + "! Поднимаю +10АС";
                    SecondPlayerUpPrice.Text = player[0].Name + "! Поднимаю +10АС";
                    FirstIndexPlayer = 2;
                    SecondIndexPlayer = 0;
                    break;

                case 2:
                    FirstplayerUpPrice.Text = player[0].Name + "! Поднимаю +10АС";
                    SecondPlayerUpPrice.Text = player[1].Name + "! Поднимаю +10АС";
                    FirstIndexPlayer = 0;
                    SecondIndexPlayer = 1;
                    break;

            }
        }

        private void Auction_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(BackGround.auction, new Point(0, 0));
        }

        private void Auction_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Auction_Load(object sender, EventArgs e)
        {

        }

        private void FirstplayerUpPrice_Click(object sender, EventArgs e)
        {
            if (player[FirstIndexPlayer].Money >= (endPrice + 10))
            {
                endPrice += 10;
                firstMoney = endPrice;
                label1.Text = firstMoney.ToString() + " АС";
                SecondPlayerUpPrice.Enabled = true;
                EndAuctiom.Enabled = true;
                FirstplayerUpPrice.Enabled = false;
            }
            else
            {
                MessageBox.Show("У вас недостаточно средств для поднятия суммы", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                SecondPlayerUpPrice.Enabled = true;
                EndAuctiom.Enabled = true;
                FirstplayerUpPrice.Enabled = false;
            }
        }

        private void SecondPlayerUpPrice_Click(object sender, EventArgs e)
        {
            if (player[SecondIndexPlayer].Money >= (endPrice + 10))
            {
                endPrice += 10;
                secondMoney = endPrice;
                label2.Text = secondMoney.ToString() + " АС";
                FirstplayerUpPrice.Enabled = true;

                SecondPlayerUpPrice.Enabled = false;
            }else
            {
                MessageBox.Show("У вас недостаточно средств для поднятия суммы", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirstplayerUpPrice.Enabled = true;
                EndAuctiom.Enabled = true;
                SecondPlayerUpPrice.Enabled = false;
            }
        }

        private void EndAuctiom_Click(object sender, EventArgs e)
        {
            if(firstMoney > secondMoney)
            {
                stocke.Owner = (byte)(FirstIndexPlayer + 1);
                player[FirstIndexPlayer].AddStock(stocke);
                player[FirstIndexPlayer].Money -= endPrice;
                MessageBox.Show("\t\tПОЗРАВЛЯЕМ!!!\n Победитель: " + player[FirstIndexPlayer].Name + "\n" +
                    "Собственность: " + stocke.Name + " приобретенна за " + endPrice + " АС",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {

                stocke.Owner = (byte)(SecondIndexPlayer + 1);
                player[SecondIndexPlayer].AddStock(stocke);
                player[SecondIndexPlayer].Money -= endPrice;
                MessageBox.Show("\t\tПОЗРАВЛЯЕМ!!!\n Победитель: " + player[SecondIndexPlayer].Name + "\n" +
                    "Собственность: " + stocke.Name + " приобретенна за " + endPrice + " АС",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }
    }
}
