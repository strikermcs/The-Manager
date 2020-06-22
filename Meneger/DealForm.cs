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
    public partial class DealForm : Form
    {
        Stock[] stock;
        Company[] companie;
        TVRadioComp[] tVRadioComp;
        Player[] player;
        LogForm log;
        int indexone;
        int indextwo;
        public DealForm(Stock[] stocks, Company[] companies, TVRadioComp[] tVRadioComps, Player[] players, LogForm logForm )
        {
            InitializeComponent();

            stock = stocks;
            companie = companies;
            tVRadioComp = tVRadioComps;
            player = players;
            log = logForm;
            ActivePlayerNameLab.Text = players[data.ActivePlayer].Name;
            switch (data.ActivePlayer)
            {
                case 0:
                    PlayerListBox.Items.Add(players[1].Name);
                    PlayerListBox.Items.Add(players[2].Name);
                    indexone = 1;
                    indextwo = 2;
                    PlayerListBox.Update();
                    break;
                case 1:
                    PlayerListBox.Items.Add(players[0].Name);
                    PlayerListBox.Items.Add(players[2].Name);
                    indexone = 0;
                    indextwo = 2;
                    PlayerListBox.Update();
                    break;
                case 2:
                    PlayerListBox.Items.Add(players[0].Name);
                    PlayerListBox.Items.Add(players[1].Name);
                    indexone = 0;
                    indextwo = 1;
                    PlayerListBox.Update();
                    break;

            }
            PlayerListBox.SelectedIndex = 0;

            //список акций для второго игрока

            StockListUpdate(indexone);
            //-----------------------------------------------------------

            //список акций активного игрока


            for (int i = 0; i < player[data.ActivePlayer].Stocks.Length; i++)
            {
                for (int j = 0; j < stock.Length; j++)
                {
                    if (stock[j].StockNumber == player[data.ActivePlayer].Stocks[i].StockNumber)
                        StocksListBoxAct.Items.Add(stock[j].Name + " " + stock[j].StockNumber.ToString()); ;
                }
            }
            for (int i = 0; i < player[data.ActivePlayer].companies.Length; i++)
            {
                for (int k = 0; k < companie.Length; k++)
                {
                    if (companie[k].StockNumber == player[data.ActivePlayer].companies[i].StockNumber)
                        StocksListBoxAct.Items.Add(companie[k].Name + " " + companie[k].StockNumber.ToString());
                }
            }
            for (int i = 0; i < player[data.ActivePlayer].tVRadioComps.Length; i++)
            {
                for (int z = 0; z < tVRadioComp.Length; z++)
                {
                    if (tVRadioComp[z].StockNumber == player[data.ActivePlayer].tVRadioComps[i].StockNumber)
                        StocksListBoxAct.Items.Add(tVRadioComp[z].Name + " " + tVRadioComp[z].StockNumber.ToString());
                }
            }
            //-----------------------------------------------------------------------------------------------------------

        }
        private void StockListUpdate(int playerIndex)
        {
            StockListBox.Items.Clear();
            if (!player[playerIndex].CompORUser) BayTextBox.Enabled = false;
            else BayTextBox.Enabled = true;

            for (int i = 0; i < player[playerIndex].Stocks.Length; i++)
            {
                for (int j = 0; j < stock.Length; j++)
                {
                    if (stock[j].StockNumber == player[playerIndex].Stocks[i].StockNumber)
                        StockListBox.Items.Add(stock[j].Name + " " + stock[j].StockNumber.ToString()); ;
                }
            }
            for (int i = 0; i < player[playerIndex].companies.Length; i++)
            {
                for (int k = 0; k < companie.Length; k++)
                {
                    if (companie[k].StockNumber == player[playerIndex].companies[i].StockNumber)
                        StockListBox.Items.Add(companie[k].Name + " " + companie[k].StockNumber.ToString());
                }
            }
            for (int i = 0; i < player[playerIndex].tVRadioComps.Length; i++)
            {
                for (int z = 0; z < tVRadioComp.Length; z++)
                {
                    if (tVRadioComp[z].StockNumber == player[playerIndex].tVRadioComps[i].StockNumber)
                        StockListBox.Items.Add(tVRadioComp[z].Name + " " + tVRadioComp[z].StockNumber.ToString());
                }
            }

        }

        private void PlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlayerListBox.SelectedIndex == 0) StockListUpdate(indexone);
            else StockListUpdate(indextwo);
        }

        private void StocksListBoxAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StocksListBoxAct.SelectedIndex != -1)
                SellButton.Enabled = true;
            else SellButton.Enabled = false;
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            string s = StocksListBoxAct.SelectedItem.ToString();

            int value;
            int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);

            if (ActivePriceBox.Text != "")
            {
               

                if (PlayerListBox.SelectedIndex == 0)
                {
                    DialogResult result = MessageBox.Show("Вы действительно собираетесь продать акцию за " + ActivePriceBox.Text
                      +"\n Игроку: " + player[indexone].Name,"Question",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        if (!player[indexone].CompORUser)
                        {
                            CopmIntellBuyDealAction(indexone,value);
                        }
                        else
                        {

                            if (player[indexone].Money >= int.Parse(ActivePriceBox.Text))
                            {
                                if (value <= 22)
                                {
                                    player[data.ActivePlayer].DeleteStock(value);
                                    stock[value - 1].Owner = (byte)(indexone + 1);
                                    stock[value - 1].Buildings = 0;
                                    player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);
                                    player[indexone].AddStock(stock[value - 1]);
                                    player[indexone].Money -= int.Parse(ActivePriceBox.Text);
                                    StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                                    StocksListBoxAct.SelectedIndex = -1;
                                    StocksListBoxAct.Update();
                                    log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + stock[value - 1].Name + " игроку " +
                                        "" + player[indexone].Name + " за " + ActivePriceBox.Text + " АС");
                                }
                                else if (value >= 23 && value <= 26)
                                {
                                    player[data.ActivePlayer].DeleteStock(value);
                                    companie[value - 23].Owner = (byte)(indexone + 1);
                                    player[indexone].AddStock(companie[value - 23]);
                                    player[indexone].Money -= int.Parse(ActivePriceBox.Text);

                                    player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);

                                    StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                                    StocksListBoxAct.SelectedIndex = -1;
                                    StocksListBoxAct.Update();
                                    log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + companie[value - 23].Name + " игроку " +
                                       "" + player[indexone].Name + " за " + ActivePriceBox.Text + " АС");
                                }
                                else
                                {
                                    player[data.ActivePlayer].DeleteStock(value);
                                    tVRadioComp[value - 27].Owner = (byte)(indexone + 1);
                                    player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);
                                    player[indexone].Money -= int.Parse(ActivePriceBox.Text);
                                    player[indexone].AddStock(tVRadioComp[value - 27]);

                                    StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                                    StocksListBoxAct.SelectedIndex = -1;
                                    StocksListBoxAct.Update();
                                    log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + tVRadioComp[value - 27].Name + " игроку " +
                                       "" + player[indexone].Name + " за " + ActivePriceBox.Text + " АС");
                                }

                            }
                            else
                            {
                                MessageBox.Show("У игрока не достаточно средств для покупки", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы действительно собираетесь продать акцию за " + ActivePriceBox.Text
                      + "\n Игроку: " + player[indextwo].Name, "Question",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (!player[indextwo].CompORUser)
                    {
                        CopmIntellBuyDealAction(indextwo,value);
                    }
                    else
                    {
                        if (result == DialogResult.Yes)
                        {
                            if (player[indextwo].Money >= int.Parse(ActivePriceBox.Text))
                            {
                                if (value <= 22)
                                {
                                    player[data.ActivePlayer].DeleteStock(value);
                                    stock[value - 1].Owner = (byte)(indextwo + 1);
                                    stock[value - 1].Buildings = 0;
                                    player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);
                                    player[indextwo].AddStock(stock[value - 1]);
                                    player[indextwo].Money -= int.Parse(ActivePriceBox.Text);
                                    StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                                    StocksListBoxAct.SelectedIndex = -1;
                                    StocksListBoxAct.Update();
                                    log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + stock[value - 1].Name + " игроку " +
                                       "" + player[indextwo].Name + " за " + ActivePriceBox.Text + " АС");
                                }
                                else if (value >= 23 && value <= 26)
                                {
                                    player[data.ActivePlayer].DeleteStock(value);
                                    companie[value - 23].Owner = (byte)(indextwo + 1);
                                    player[indextwo].AddStock(companie[value - 23]);
                                    player[indextwo].Money -= int.Parse(ActivePriceBox.Text);

                                    player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);

                                    StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                                    StocksListBoxAct.SelectedIndex = -1;
                                    StocksListBoxAct.Update();
                                    log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + companie[value - 23].Name + " игроку " +
                                       "" + player[indextwo].Name + " за " + ActivePriceBox.Text + " АС");
                                }
                                else
                                {
                                    player[data.ActivePlayer].DeleteStock(value);
                                    tVRadioComp[value - 27].Owner = (byte)(indextwo + 1);
                                    player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);
                                    player[indextwo].Money -= int.Parse(ActivePriceBox.Text);
                                    player[indextwo].AddStock(tVRadioComp[value - 27]);

                                    StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                                    StocksListBoxAct.SelectedIndex = -1;
                                    StocksListBoxAct.Update();
                                    log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + tVRadioComp[value - 27].Name + " игроку " +
                                       "" + player[indextwo].Name + " за " + ActivePriceBox.Text + " АС");
                                }
                            }
                            else
                            {
                                MessageBox.Show("У игрока не достаточно средств для покупки", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
                if (PlayerListBox.SelectedIndex == 0) StockListUpdate(indexone);
                else StockListUpdate(indextwo);

            }
            else
            {
                MessageBox.Show("Укажите пожалуйста сумму за которую вы хотите продать акцию", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StockListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StockListBox.SelectedIndex != -1)
                BayButton.Enabled = true;
            else BayButton.Enabled = false;
        }

        private void BayButton_Click(object sender, EventArgs e)
        {
            string s = StockListBox.SelectedItem.ToString();

            int value;
            int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);



            if (PlayerListBox.SelectedIndex == 0)
            {
                if (!player[indexone].CompORUser)
                {
                    ComputerIntellSellDealAction(indexone, value);
                }
                else
                {

                    if (BayTextBox.Text != "")
                    {

                        DialogResult result = MessageBox.Show("Вы действительно собираетесь купить акцию за " + BayTextBox.Text
                                                               + "\n У игрока: " + player[indexone].Name, "Question",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (result == DialogResult.Yes)
                        {
                            if (player[data.ActivePlayer].Money >= int.Parse(BayTextBox.Text))
                            {
                                if (value <= 22)
                                {
                                    player[indexone].DeleteStock(value);
                                    stock[value - 1].Owner = (byte)(data.ActivePlayer + 1);
                                    stock[value - 1].Buildings = 0;
                                    player[data.ActivePlayer].Money -= int.Parse(BayTextBox.Text);
                                    player[data.ActivePlayer].AddStock(stock[value - 1]);
                                    player[indexone].Money += int.Parse(BayTextBox.Text);
                                    StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                                    StockListBox.SelectedIndex = -1;
                                    StockListBox.Update();
                                }
                                else if (value >= 23 && value <= 26)
                                {
                                    player[indexone].DeleteStock(value);
                                    companie[value - 23].Owner = (byte)(data.ActivePlayer + 1);
                                    player[data.ActivePlayer].AddStock(companie[value - 23]);
                                    player[data.ActivePlayer].Money -= int.Parse(BayTextBox.Text);

                                    player[indexone].Money += int.Parse(BayTextBox.Text);

                                    StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                                    StockListBox.SelectedIndex = -1;
                                    StockListBox.Update();
                                }
                                else
                                {
                                    player[indexone].DeleteStock(value);
                                    tVRadioComp[value - 27].Owner = (byte)(data.ActivePlayer + 1);
                                    player[data.ActivePlayer].Money -= int.Parse(BayTextBox.Text);
                                    player[indexone].Money += int.Parse(BayTextBox.Text);
                                    player[data.ActivePlayer].AddStock(tVRadioComp[value - 27]);

                                    StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                                    StockListBox.SelectedIndex = -1;
                                    StockListBox.Update();
                                }

                            }
                            else
                            {
                                MessageBox.Show("У игрока не достаточно средств для покупки", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Укажите пожалуйста сумму за которую вы хотите продать акцию", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }



            else
            {
                if (!player[indextwo].CompORUser)
                {
                    ComputerIntellSellDealAction(indexone, value);
                }
                else
                {
                    if (BayTextBox.Text != "")
                    {

                        DialogResult result = MessageBox.Show("Вы действительно собираетесь купить акцию за " + BayTextBox.Text
                          + "\n У игрока: " + player[indextwo].Name, "Question",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (result == DialogResult.Yes)
                        {
                            if (player[data.ActivePlayer].Money >= int.Parse(BayTextBox.Text))
                            {
                                if (value <= 22)
                                {
                                    player[indextwo].DeleteStock(value);
                                    stock[value - 1].Owner = (byte)(data.ActivePlayer + 1);
                                    stock[value - 1].Buildings = 0;
                                    player[data.ActivePlayer].Money -= int.Parse(BayTextBox.Text);
                                    player[data.ActivePlayer].AddStock(stock[value - 1]);
                                    player[indextwo].Money += int.Parse(BayTextBox.Text);
                                    StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                                    StockListBox.SelectedIndex = -1;
                                    StockListBox.Update();
                                }
                                else if (value >= 23 && value <= 26)
                                {
                                    player[indextwo].DeleteStock(value);
                                    companie[value - 23].Owner = (byte)(data.ActivePlayer + 1);
                                    player[data.ActivePlayer].AddStock(companie[value - 23]);
                                    player[data.ActivePlayer].Money -= int.Parse(BayTextBox.Text);

                                    player[indextwo].Money += int.Parse(BayTextBox.Text);

                                    StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                                    StockListBox.SelectedIndex = -1;
                                    StockListBox.Update();
                                }
                                else
                                {
                                    player[indextwo].DeleteStock(value);
                                    tVRadioComp[value - 27].Owner = (byte)(data.ActivePlayer + 1);
                                    player[data.ActivePlayer].Money -= int.Parse(BayTextBox.Text);
                                    player[indextwo].Money += int.Parse(BayTextBox.Text);
                                    player[data.ActivePlayer].AddStock(tVRadioComp[value - 27]);

                                    StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                                    StockListBox.SelectedIndex = -1;
                                    StockListBox.Update();
                                }

                            }
                            else
                            {
                                MessageBox.Show("У вас не достаточно средств для покупки", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Укажите пожалуйста сумму за которую вы хотите продать акцию", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

            StocksListBoxAct.Items.Clear();
            for (int i = 0; i < player[data.ActivePlayer].Stocks.Length; i++)
            {
                for (int j = 0; j < stock.Length; j++)
                {
                    if (stock[j].StockNumber == player[data.ActivePlayer].Stocks[i].StockNumber)
                        StocksListBoxAct.Items.Add(stock[j].Name + " " + stock[j].StockNumber.ToString()); ;
                }
            }
            for (int i = 0; i < player[data.ActivePlayer].companies.Length; i++)
            {
                for (int k = 0; k < companie.Length; k++)
                {
                    if (companie[k].StockNumber == player[data.ActivePlayer].companies[i].StockNumber)
                        StocksListBoxAct.Items.Add(companie[k].Name + " " + companie[k].StockNumber.ToString());
                }
            }
            for (int i = 0; i < player[data.ActivePlayer].tVRadioComps.Length; i++)
            {
                for (int z = 0; z < tVRadioComp.Length; z++)
                {
                    if (tVRadioComp[z].StockNumber == player[data.ActivePlayer].tVRadioComps[i].StockNumber)
                        StocksListBoxAct.Items.Add(tVRadioComp[z].Name + " " + tVRadioComp[z].StockNumber.ToString());
                }
            }




        }
        //-----------------------------------------------------------------

        public void CopmIntellBuyDealAction(int index,int val)
        {
           

            if (player[index].Money >= (int.Parse(ActivePriceBox.Text) + 200))
            {
                if (val <= 22)
                {
                    if ((stock[val - 1].Price + 300) < int.Parse(ActivePriceBox.Text))
                    {
                        MessageBox.Show("Нет, я вынужден отклонить ваше предложенние. Предложите лучшее условие!",
                            "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        player[data.ActivePlayer].DeleteStock(val);
                        stock[val - 1].Owner = (byte)(index + 1);
                        stock[val - 1].Buildings = 0;
                        player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);
                        player[index].AddStock(stock[val - 1]);
                        player[index].Money -= int.Parse(ActivePriceBox.Text);
                        StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                        StocksListBoxAct.SelectedIndex = -1;
                        StocksListBoxAct.Update();
                        log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + stock[val - 1].Name + " игроку " +
                                       "" + player[index].Name + " за " + ActivePriceBox.Text + " АС");
                    }
                }
                else if (val >= 23 && val <= 26)
                {

                    if ((companie[val - 23].Price + 300) < int.Parse(ActivePriceBox.Text))
                    {
                        MessageBox.Show("Нет, я вынужден отклонить ваше предложенние. Предложите лучшее условие!",
                            "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        player[data.ActivePlayer].DeleteStock(val);
                        companie[val - 23].Owner = (byte)(index + 1);
                        player[index].AddStock(companie[val - 23]);
                        player[index].Money -= int.Parse(ActivePriceBox.Text);

                        player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);

                        StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                        StocksListBoxAct.SelectedIndex = -1;
                        StocksListBoxAct.Update();
                        log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + companie[val - 23].Name + " игроку " +
                                       "" + player[index].Name + " за " + ActivePriceBox.Text + " АС");
                    }
                }
                else
                {

                    if ((tVRadioComp[val - 27].Price + 300) < int.Parse(ActivePriceBox.Text))
                    {
                        MessageBox.Show("Нет, я вынужден отклонить ваше предложенние. Предложите лучшее условие!",
                            "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        player[data.ActivePlayer].DeleteStock(val);
                        tVRadioComp[val - 27].Owner = (byte)(index + 1);
                        player[data.ActivePlayer].Money += int.Parse(ActivePriceBox.Text);
                        player[index].Money -= int.Parse(ActivePriceBox.Text);
                        player[index].AddStock(tVRadioComp[val - 27]);

                        StocksListBoxAct.Items.RemoveAt(StocksListBoxAct.SelectedIndex);
                        StocksListBoxAct.SelectedIndex = -1;
                        StocksListBoxAct.Update();
                        log.AddLog("Сделка:", player[data.ActivePlayer].Name + " продал " + tVRadioComp[val - 27].Name + " игроку " +
                                       "" + player[index].Name + " за " + ActivePriceBox.Text + " АС");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет, я вынужден отклонить ваше предложенние. Предложите лучшее условие!",
                           "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //---------------------------------------------------------------------------------------
        public void ComputerIntellSellDealAction(int index, int val)
        {
            int cost;
            if (MayCompSellAction(index, val)){




                if (val <= 22)
                {
                    cost = stock[val - 1].Price + 400;
                    DialogResult result = MessageBox.Show("Эту акцию могу продать за " + cost + " АС. Вы согласны?",
                                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        if (player[data.ActivePlayer].Money >= cost)
                        {

                            player[index].DeleteStock(val);
                            stock[val - 1].Owner = (byte)(data.ActivePlayer + 1);
                            stock[val - 1].Buildings = 0;
                            player[data.ActivePlayer].Money -= cost;
                            player[data.ActivePlayer].AddStock(stock[val - 1]);
                            player[index].Money += cost;
                            StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                            StockListBox.SelectedIndex = -1;
                            StockListBox.Update();
                        }
                        else
                        {
                            MessageBox.Show("У вас недостаточно средств", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                    }
                }
                else if (val >= 23 && val <= 26)
                {
                    cost = companie[val - 23].Price + 350;
                    DialogResult result = MessageBox.Show("Эту акцию могу продать за " + cost + " АС. Вы согласны?",
                         "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        if (player[data.ActivePlayer].Money >= cost)
                        {
                            player[index].DeleteStock(val);
                            companie[val - 23].Owner = (byte)(data.ActivePlayer + 1);
                            player[data.ActivePlayer].AddStock(companie[val - 23]);
                            player[data.ActivePlayer].Money -= cost;

                            player[index].Money += cost;

                            StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                            StockListBox.SelectedIndex = -1;
                            StockListBox.Update();
                        }
                        else
                        {
                            MessageBox.Show("У вас недостаточно средств", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    cost = tVRadioComp[val - 27].Price + 280;
                    DialogResult result = MessageBox.Show("Эту акцию могу продать за " + cost + " АС. Вы согласны?",
                                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        if (player[data.ActivePlayer].Money >= cost)
                        {
                            player[index].DeleteStock(val);
                            tVRadioComp[val - 27].Owner = (byte)(data.ActivePlayer + 1);
                            player[data.ActivePlayer].Money -= cost;
                            player[index].Money += cost;
                            player[data.ActivePlayer].AddStock(tVRadioComp[val - 27]);

                            StockListBox.Items.RemoveAt(StockListBox.SelectedIndex);
                            StockListBox.SelectedIndex = -1;
                            StockListBox.Update();
                        }
                        else
                        {
                            MessageBox.Show("У вас недостаточно средств", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                    }
                }

                
            }
            else
            {
                MessageBox.Show("Извините, но я не продам эту акцию не за какие деньги.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }  
        
        //------------------------------------------------------------------------------------------

        public bool MayCompSellAction(int plindex,int value)
        {
            if (value <= 22)
            {
                if (value - 1 == 0 || value - 1 == 1) return false;
                else if (value - 1 == 2 || value - 1 == 3 || value - 1 == 4)
                {
                    int tmp = 0;
                    if (stock[2].Owner == plindex + 1) tmp++;
                    if (stock[3].Owner == plindex + 1) tmp++;
                    if (stock[4].Owner == plindex + 1) tmp++;
                    if (tmp > 1) return false;
                    else return true;
                }
                else if (value - 1 == 5 || value - 1 == 6 || value - 1 == 7)
                {
                    int tmp = 0;
                    if (stock[5].Owner == plindex + 1) tmp++;
                    if (stock[6].Owner == plindex + 1) tmp++;
                    if (stock[7].Owner == plindex + 1) tmp++;
                    if (tmp > 1) return false;
                    else return true;
                }
                else if (value - 1 == 8 || value - 1 == 9 || value - 1 == 10)
                {
                    int tmp = 0;
                    if (stock[8].Owner == plindex + 1) tmp++;
                    if (stock[9].Owner == plindex + 1) tmp++;
                    if (stock[10].Owner == plindex + 1) tmp++;
                    if (tmp > 1) return false;
                    else return true;
                }
                else if (value - 1 == 11 || value - 1 == 12 || value - 1 == 13)
                {
                    int tmp = 0;
                    if (stock[11].Owner == plindex + 1) tmp++;
                    if (stock[12].Owner == plindex + 1) tmp++;
                    if (stock[13].Owner == plindex + 1) tmp++;
                    if (tmp > 1) return false;
                    else return true;
                }
                else if (value - 1 == 14 || value - 1 == 15 || value - 1 == 16)
                {
                    int tmp = 0;
                    if (stock[14].Owner == plindex + 1) tmp++;
                    if (stock[15].Owner == plindex + 1) tmp++;
                    if (stock[16].Owner == plindex + 1) tmp++;
                    if (tmp > 1) return false;
                    else return true;
                }
                else if (value - 1 == 17 || value - 1 == 18 || value - 1 == 19)
                {
                    int tmp = 0;
                    if (stock[17].Owner == plindex + 1) tmp++;
                    if (stock[18].Owner == plindex + 1) tmp++;
                    if (stock[19].Owner == plindex + 1) tmp++;
                    if (tmp > 1) return false;
                    else return true;
                }
                else return false;

            }
            else return true;
        }
    }

}
    

