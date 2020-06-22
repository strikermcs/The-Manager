using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mainlib;

namespace Meneger
{
    public partial class FinExchange : Form
    {
        Stock[] stock;
        Company[] companie;
        TVRadioComp[] tVRadioComp;
        Player[] player;
        Bank[] bank;
        int Trays = 0;
        public FinExchange(Stock[] stocks, Company[] companies, TVRadioComp[] tVRadioComps, Player[] players,Bank[] banks)
        {
            InitializeComponent();
            stock = stocks;
            companie = companies;
            tVRadioComp = tVRadioComps;
            player = players;
            bank = banks;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            groupBox8.Enabled = false;
            groupBox9.Enabled = false;
            groupBox10.Enabled = false;
            groupBox11.Enabled = false;
            groupBox12.Enabled = false;
            KostiButt.Enabled = false;
            if (player[data.ActivePlayer].ByExCard)
            {
                player[data.ActivePlayer].ByExCard = false;
                button1.Enabled = false;
                button2.Enabled = false;
                Trays = 3;
                TryLab.Text = Trays.ToString();
                KostiButt.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Акредитование места на бирже стоит 50 АС. Хотите продолжить?",
                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (player[data.ActivePlayer].Money >= 50)
                {
                    player[data.ActivePlayer].Money -= 50;
                    Trays = 3;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    KostiButt.Enabled = true;
                    TryLab.Text = Trays.ToString();
                }
                else
                {
                    MessageBox.Show("Извините но у вас недостаточно денег", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void KostiButt_Click(object sender, EventArgs e)
        {
            KostiButt.Enabled = false;
            int rezult;
            


                Random rand = new Random();
                rezult = rand.Next(2, 13);

                KostiLab.Text = rezult.ToString();

                switch (rezult)
                {
                    case 2:
                        groupBox2.Enabled = true;
                        groupBox2.BackColor = Color.Green;
                        break;
                    case 3:
                        groupBox3.Enabled = true;
                        groupBox3.BackColor = Color.Green;
                        break;
                    case 4:
                        groupBox4.Enabled = true;
                        groupBox4.BackColor = Color.Green;
                        break;
                    case 5:
                        groupBox5.Enabled = true;
                        groupBox5.BackColor = Color.Green;
                        break;
                    case 6:
                        groupBox6.Enabled = true;
                        groupBox6.BackColor = Color.Green;
                        break;
                    case 7:
                        groupBox11.Enabled = true;
                        groupBox11.BackColor = Color.Green;
                        break;
                    case 8:
                        groupBox10.Enabled = true;
                        groupBox10.BackColor = Color.Green;
                        break;
                    case 9:
                        groupBox9.Enabled = true;
                        groupBox9.BackColor = Color.Green;
                        break;
                    case 10:
                        groupBox8.Enabled = true;
                        groupBox8.BackColor = Color.Green;
                        break;
                    case 11:
                        groupBox7.Enabled = true;
                        groupBox7.BackColor = Color.Green;
                        break;
                    case 12:
                        groupBox12.Enabled = true;
                        groupBox12.BackColor = Color.Green;
                        break;
                }
                Trays--;
                TryLab.Text = Trays.ToString();

        }

        private void FirstBottCansel_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox2.BackColor = SystemColors.Control;

            for(int i = 0; i < stock.Length; i++)
            {
                if (stock[i].Owner == data.ActivePlayer - 1) stock[i].MortgagePrice = stock[i].Price;
            }

            KostiButt.Enabled = true;

            
        }

        private void TwoBotOK_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            groupBox3.BackColor = SystemColors.Control;
            bank[data.ActivePlayer].CreditTake = true;
            bank[data.ActivePlayer].CreditRepay = 500;
            bank[data.ActivePlayer].CreditPayForCircle = 125;
            KostiButt.Enabled = true;
        }

        private void TwoCansel_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            groupBox3.BackColor = SystemColors.Control;
            KostiButt.Enabled = true;
        }

        private void FourBotOK_Click(object sender, EventArgs e)
        {
            groupBox5.Enabled = false;
            groupBox5.BackColor = SystemColors.Control;
            player[data.ActivePlayer].Money += 150;
            KostiButt.Enabled = true;
        }

        private void FiveBotOK_Click(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox6.BackColor = SystemColors.Control;

            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i].Owner == data.ActivePlayer - 1) stock[i].Rent = (ushort)(stock[i].Rent / 2);
            }
            KostiButt.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox11.Enabled = false;
            groupBox11.BackColor = SystemColors.Control;

            if (bank[data.ActivePlayer].CreditTake)
            {
                player[data.ActivePlayer].Money -= bank[data.ActivePlayer].CreditRepay;
                bank[data.ActivePlayer].CreditTake = false;
                bank[data.ActivePlayer].CreditRepay = 0;
                bank[data.ActivePlayer].CreditPayForCircle = 0;
                MessageBox.Show("Кредит погашен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KostiButt.Enabled = true;
            }
            else
            {
                MessageBox.Show("У вас нет кредита", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KostiButt.Enabled = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            groupBox10.Enabled = false;
            groupBox10.BackColor = SystemColors.Control;

            KostiButt.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox10.Enabled = false;
            groupBox10.BackColor = SystemColors.Control;
            bool tmp = true;
            for(int i = 0; i < companie.Length; i++)
            {
                if(companie[i].Owner == 0)
                {
                    tmp = false;
                   DialogResult result = MessageBox.Show("Есть свободная " + companie[i].Name + ". Будете брать за 100АС?",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        if(player[data.ActivePlayer].Money >= 100)
                        {
                            companie[i].Owner = (byte)(data.ActivePlayer + 1);
                            player[data.ActivePlayer].AddStock(companie[i]);
                            player[data.ActivePlayer].Money -= 100;
                            MessageBox.Show("Компания приобретена");
                            KostiButt.Enabled = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("У вас недостаточно средств", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KostiButt.Enabled = true;
                            return;
                        }
                    }
                }
            }
            if (tmp)
            {
                MessageBox.Show("Извините нет свободной компании", "Information", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            KostiButt.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox8.Enabled = false;
            groupBox8.BackColor = SystemColors.Control;
            player[data.ActivePlayer].Money -= 100;
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            groupBox7.Enabled = false;
            groupBox7.BackColor = SystemColors.Control;

            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i].Owner == data.ActivePlayer - 1)
                {

                    stock[i].Rent *= 2;
                    stock[i].RentWithFourHouse *= 2;
                    stock[i].RentWithHotel *= 2;

                    stock[i].RentWithOneHouse *= 2;
                    stock[i].RentWithThreeHouse *= 2;
                    stock[i].RentWithTwoHouse *= 2;

                }
            }

            KostiButt.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            groupBox4.BackColor = SystemColors.Control;
            KostiButt.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox9.Enabled = false;
            groupBox9.BackColor = SystemColors.Control;
            KostiButt.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox12.Enabled = false;
            groupBox12.BackColor = SystemColors.Control;
            KostiButt.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(Trays == 0)
            {
                KostiButt.Enabled = false;
                button2.Enabled = true;
            }
        }
    }
}