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
    public partial class Banks : Form
    {
        int sumCredit = 500;
        int PaybayCircle = 115;
        int Moves;
        int sumPay = 575;
        int percend = 35;
        Stock[] stosk;
        Company[] companie;
        TVRadioComp[] tVRadios;
        Player[] player;
        Bank[] bank;
        public Banks(Stock[] stocks,Company[] companies, TVRadioComp[] tVRadioComps,Player[] players,Bank[] banks)
        {
            InitializeComponent();
            stosk = stocks;
            companie = companies;
            tVRadios = tVRadioComps;
            player = players;
            bank = banks;
            BuyStockButton.Enabled = false;
            MogStockButton.Enabled = false;

            //создание списка
            for (int i = 0; i < bank[data.ActivePlayer].stocks.Length; i++)
            {
                for (int j = 0; j < stosk.Length; j++)
                {
                    if (stosk[j].StockNumber == bank[data.ActivePlayer].stocks[i].StockNumber)
                        ListOfStocks.Items.Add(stosk[j].Name + " " + stosk[j].StockNumber.ToString()); ;
                }
            }
            for (int i = 0; i < bank[data.ActivePlayer].companies.Length; i++)
            {
                for (int k = 0; k < companie.Length; k++)
                {
                    if (companie[k].StockNumber == bank[data.ActivePlayer].companies[i].StockNumber)
                        ListOfStocks.Items.Add(companie[k].Name + " " + companie[k].StockNumber.ToString());
                }
            }
            for (int i = 0; i < bank[data.ActivePlayer].vRadioComps.Length; i++)
            {
                for (int z = 0; z < tVRadios.Length; z++)
                {
                    if (tVRadios[z].StockNumber == bank[data.ActivePlayer].vRadioComps[i].StockNumber)
                        ListOfStocks.Items.Add(tVRadios[z].Name + " " + tVRadios[z].StockNumber.ToString());
                }
            }
            //

            if (bank[data.ActivePlayer].CreditTake)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                button1.Enabled = true;
            }

            CreditSumLab.Text = trackBar1.Value.ToString() + " АС";
            MovesLab.Text = trackBar2.Value.ToString() + " кругов";
            proceLab.Text = percend+ "%";
            PayLab.Text = sumPay.ToString()+" АС";
            PayCircleLab.Text = PaybayCircle.ToString()+ " АС";

            InfoPayLab.Text = bank[data.ActivePlayer].CreditRepay.ToString()+" АС";
            InfoPayForCircleLab.Text = bank[data.ActivePlayer].CreditPayForCircle.ToString()+ " АС";
            InfoCircleLab.Text = bank[data.ActivePlayer].CircleOst.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Value = (trackBar1.Value / 100) * 100;
            UpdateVal();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateVal();
            
        }

        private void UpdateVal()
        {
            sumCredit = trackBar1.Value;
            percend = trackBar2.Value + 30;
            sumPay = sumCredit / 100 * percend + sumCredit;
            Moves = trackBar2.Value;
            PaybayCircle = sumPay / Moves;

            CreditSumLab.Text = sumCredit + " АС";
            MovesLab.Text = Moves.ToString() + " кругов";
            proceLab.Text = percend.ToString() + "%";
            PayLab.Text = sumPay.ToString() + " АС";
            PayCircleLab.Text = PaybayCircle.ToString() + " АС";
            
        }
        private void GiveCredit()
        {
            bank[data.ActivePlayer].CreditTake = true;
            bank[data.ActivePlayer].CreditRepay = sumPay;
            bank[data.ActivePlayer].CreditPayForCircle = PaybayCircle;
            bank[data.ActivePlayer].CircleOst = Moves;
            player[data.ActivePlayer].Money += sumCredit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int StockOwners = 0;

            for(int i = 0; i < stosk.Length; i++)
            {
                if (stosk[i].Owner == data.ActivePlayer + 1) StockOwners++; 
            }

            if(StockOwners < 8)
            {
                switch (StockOwners)
                {
                    case 0:
                        MessageBox.Show("Извините но банк не одобрил вам кредит", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:
                        MessageBox.Show("Извините но банк не одобрил вам кредит", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Извините но банк не одобрил вам кредит", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 3:
                        MessageBox.Show("Извините но банк не одобрил вам кредит", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 4:
                        if (sumCredit > 1000)
                        {
                            MessageBox.Show("Извините но банк не одобрил вам кредит! Попробуйте взять меньшую сумму.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            GiveCredit();
                            MessageBox.Show("Поздравляем банк одобрил вам кредит!!!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = false;
                        }
                        break;
                    case 5:
                        if (sumCredit > 1500)
                        {
                            MessageBox.Show("Извините но банк не одобрил вам кредит! Попробуйте взять меньшую сумму.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            GiveCredit();
                            MessageBox.Show("Поздравляем банк одобрил вам кредит!!!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = false;
                        }
                        break;
                    case 6:
                        if (sumCredit > 2000)
                        {
                            MessageBox.Show("Извините но банк не одобрил вам кредит! Попробуйте взять меньшую сумму.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            GiveCredit();
                            MessageBox.Show("Поздравляем банк одобрил вам кредит!!!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = false;
                        }
                        break;
                    case 7:
                        if (sumCredit > 2500)
                        {
                            MessageBox.Show("Извините но банк не одобрил вам кредит! Попробуйте взять меньшую сумму.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            GiveCredit();
                            MessageBox.Show("Поздравляем банк одобрил вам кредит!!!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = false;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Поздравляем банк одобрил вам кредит!!!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                GiveCredit();
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player[data.ActivePlayer].Money >= bank[data.ActivePlayer].CreditRepay)
            {
                player[data.ActivePlayer].Money -= bank[data.ActivePlayer].CreditRepay;
                bank[data.ActivePlayer].CreditRepay = 0;
                bank[data.ActivePlayer].CreditPayForCircle = 0;
                bank[data.ActivePlayer].CircleOst = 0;
                bank[data.ActivePlayer].CreditTake = false;
                MessageBox.Show("Поздравляем!!! Вы успешно погасили кредит.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Увы!!! У вас недостаточно средств для погашения кредита.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListOfStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListOfStocks.SelectedIndex != -1)
            {

                BuyStockButton.Enabled = true;
                MogStockButton.Enabled = true;
                string s = ListOfStocks.SelectedItem.ToString();

                int value;
                int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);

                if (value <= 22)
                {
                    BuyStockBox.Text = stosk[value - 1].Price.ToString();
                    MorStockBox.Text = (stosk[value - 1].MortgagePrice + 20).ToString();
                }
                else if (value >= 23 && value <= 26)
                {
                    BuyStockBox.Text = companie[value - 23].Price.ToString();
                    MorStockBox.Text = (companie[value - 23].MortgagePrice+20).ToString();
                }
                else
                {
                    BuyStockBox.Text = tVRadios[value - 27].Price.ToString();
                    MorStockBox.Text = (tVRadios[value - 27].MortgagePrice+20).ToString();
                }
            }
            else
            {
                BuyStockButton.Enabled = false;
                MogStockButton.Enabled = false;
            }



        }

        private void BuyStockButton_Click(object sender, EventArgs e)
        {
            string s = ListOfStocks.SelectedItem.ToString();

            int value;
            int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);
            DialogResult result = MessageBox.Show("Вы действительно собираетесь продать акцию? ", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (value <= 22)
                {
                    bank[data.ActivePlayer].DeleteStock(value);
                    stosk[value - 1].Owner = 0;
                    stosk[value - 1].Buildings = 0;
                    player[data.ActivePlayer].Money += stosk[value - 1].Price;
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else if (value >= 23 && value <= 26)
                {
                    bank[data.ActivePlayer].DeleteStock(value);
                    companie[value - 23].Owner = 0;

                    player[data.ActivePlayer].Money += companie[value - 23].Price;
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else
                {
                    bank[data.ActivePlayer].DeleteStock(value);
                    tVRadios[value - 27].Owner = 0;

                    player[data.ActivePlayer].Money += tVRadios[value - 27].Price;
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
            }
        }

        private void MogStockButton_Click(object sender, EventArgs e)
        {
            string s = ListOfStocks.SelectedItem.ToString();

            int value;
            int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);
            DialogResult result = MessageBox.Show("Вы действительно хотите выкупить акцию", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (value <= 22)
                {
                    bank[data.ActivePlayer].DeleteStock(value);
                    stosk[value - 1].Owner = (byte)(data.ActivePlayer+1);
                    stosk[value - 1].Buildings = 0;
                    player[data.ActivePlayer].Money -= stosk[value - 1].MortgagePrice + 20;
                    player[data.ActivePlayer].AddStock(stosk[value - 1]);
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else if (value >= 23 && value <= 26)
                {
                    bank[data.ActivePlayer].DeleteStock(value);
                    companie[value - 23].Owner = (byte)(data.ActivePlayer+1);

                    player[data.ActivePlayer].Money -= companie[value - 23].MortgagePrice + 20;
                    player[data.ActivePlayer].AddStock(companie[value - 23]);
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else
                {
                    bank[data.ActivePlayer].DeleteStock(value);
                    tVRadios[value - 27].Owner = (byte)(data.ActivePlayer+1);

                    player[data.ActivePlayer].Money -= tVRadios[value - 27].MortgagePrice + 20;
                    player[data.ActivePlayer].AddStock(tVRadios[value - 27]);
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
            }
        }
    }
    
    
}
