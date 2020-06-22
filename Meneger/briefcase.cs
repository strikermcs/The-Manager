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
    public partial class briefcase : Form
    {
        Stock[] stock;
        Company[] companie;
        TVRadioComp[] tVRadioComp;
        Player[] player;
        Bank[] bank;
        public briefcase(Stock[] stocks,Company[] companies,TVRadioComp[] tVRadioComps,Player[] players,Bank[] banks)
        {
            InitializeComponent();
            BuyStockButton.Enabled = false;
            MogStockButton.Enabled = false;
            stock = stocks;
            companie = companies;
            tVRadioComp = tVRadioComps;
            player = players;
            bank = banks;

            CardInterpolBox.Text = player[data.ActivePlayer].HaveALawyer.ToString();
            CardBirBox.Text = player[data.ActivePlayer].HaveAExchangeCard.ToString();
            for (int i = 0; i < player[data.ActivePlayer].Stocks.Length; i++)
            {
                for (int j = 0; j < stock.Length; j++)
                {
                    if (stock[j].StockNumber == player[data.ActivePlayer].Stocks[i].StockNumber)
                        ListOfStocks.Items.Add(stock[j].Name + " " + stock[j].StockNumber.ToString()); ;
                }
            }
            for (int i = 0; i < player[data.ActivePlayer].companies.Length; i++)
            {
                for (int k = 0; k < companie.Length; k++)
                {
                    if (companie[k].StockNumber == player[data.ActivePlayer].companies[i].StockNumber)
                        ListOfStocks.Items.Add(companie[k].Name + " " + companie[k].StockNumber.ToString());
                }
            }
            for (int i = 0; i < player[data.ActivePlayer].tVRadioComps.Length; i++)
            {
                for (int z = 0; z < tVRadioComp.Length; z++)
                {
                    if (tVRadioComp[z].StockNumber == player[data.ActivePlayer].tVRadioComps[i].StockNumber)
                        ListOfStocks.Items.Add(tVRadioComp[z].Name + " " + tVRadioComp[z].StockNumber.ToString());
                }
            }
            
        }

        private void BuyInterpolCardButton_Click(object sender, EventArgs e)
        {
            if (player[data.ActivePlayer].HaveALawyer > 0)
            {
                DialogResult rezult;
                rezult = MessageBox.Show("Вы действительно хотите продать карточку? Банк дает за нее 100 АС","Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezult == DialogResult.Yes)
                {
                    player[data.ActivePlayer].HaveALawyer -= 1;
                    player[data.ActivePlayer].Money += 100;
                    CardInterpolBox.Text = player[data.ActivePlayer].HaveALawyer.ToString();
                }
                else return;
            }
            else
            {
                MessageBox.Show("Упппсс!!! У вас нет ни одной карточки.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BuyBirCardButton_Click(object sender, EventArgs e)
        {
            if (player[data.ActivePlayer].HaveAExchangeCard > 0)
            {
                DialogResult rezult;
                rezult = MessageBox.Show("Вы действительно хотите продать карточку? Банк дает за нее 500 АС", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezult == DialogResult.Yes)
                {
                    player[data.ActivePlayer].HaveAExchangeCard -= 1;
                    player[data.ActivePlayer].Money += 500;
                    CardBirBox.Text = player[data.ActivePlayer].HaveAExchangeCard.ToString();
                }
                else return;
            }
            else
            {
                MessageBox.Show("Упппсс!!! У вас нет ни одной карточки.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ListOfStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfStocks.SelectedIndex != -1)
            {

                BuyStockButton.Enabled = true;
                MogStockButton.Enabled = true;


                string s = ListOfStocks.SelectedItem.ToString();

                int value;
                int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);

                if (value <= 22)
                {
                    BuyStockBox.Text = stock[value - 1].Price.ToString();
                    MorStockBox.Text = stock[value - 1].MortgagePrice.ToString();
                }
                else if (value >= 23 && value <= 26)
                {
                    BuyStockBox.Text = companie[value - 23].Price.ToString();
                    MorStockBox.Text = companie[value - 23].MortgagePrice.ToString();
                }
                else
                {
                    BuyStockBox.Text = tVRadioComp[value - 27].Price.ToString();
                    MorStockBox.Text = tVRadioComp[value - 27].MortgagePrice.ToString();
                }
            }
            else {
                BuyStockButton.Enabled = false;
                MogStockButton.Enabled = false;
            }

        }

        private void BuyStockButton_Click(object sender, EventArgs e)
        {
            string s = ListOfStocks.SelectedItem.ToString();

            int value;
            int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out value);
            DialogResult result = MessageBox.Show("Вы действительно собираетесь продать акцию? \n " +
                "Все постройки на в этом месте будут утеряны", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (value <= 22)
                {
                   player[data.ActivePlayer].DeleteStock(value);
                    stock[value - 1].Owner = 0;
                    stock[value - 1].Buildings = 0;
                    player[data.ActivePlayer].Money += stock[value - 1].Price;
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else if (value >= 23 && value <= 26)
                {
                    player[data.ActivePlayer].DeleteStock(value);
                    companie[value - 23].Owner = 0;
                    
                    player[data.ActivePlayer].Money += companie[value - 23].Price;
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else
                {
                    player[data.ActivePlayer].DeleteStock(value);
                    tVRadioComp[value - 27].Owner = 0;

                    player[data.ActivePlayer].Money += tVRadioComp[value - 27].Price;
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
            DialogResult result = MessageBox.Show("Вы действительно собираетесь заложить акцию? \n " +
                "Все постройки на в этом месте будут утеряны", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (value <= 22)
                {
                    player[data.ActivePlayer].DeleteStock(value);
                    stock[value - 1].Owner = 4;
                    stock[value - 1].Buildings = 0;
                    player[data.ActivePlayer].Money += stock[value - 1].MortgagePrice;
                    bank[data.ActivePlayer].AddStock(stock[value - 1]);
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else if (value >= 23 && value <= 26)
                {
                    player[data.ActivePlayer].DeleteStock(value);
                    companie[value - 23].Owner = 4;

                    player[data.ActivePlayer].Money += companie[value - 23].MortgagePrice;
                    bank[data.ActivePlayer].AddStock(companie[value - 23]);
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
                else
                {
                    player[data.ActivePlayer].DeleteStock(value);
                    tVRadioComp[value - 27].Owner = 4;

                    player[data.ActivePlayer].Money += tVRadioComp[value - 27].MortgagePrice;
                    bank[data.ActivePlayer].AddStock(tVRadioComp[value - 27]);
                    ListOfStocks.Items.RemoveAt(ListOfStocks.SelectedIndex);
                    ListOfStocks.SelectedIndex = -1;
                    ListOfStocks.Update();
                }
            }
        }

        private void ExecBirCardButton_Click(object sender, EventArgs e)
        {
            if(player[data.ActivePlayer].HaveAExchangeCard > 0)
            {
                player[data.ActivePlayer].HaveAExchangeCard -= 1;
                player[data.ActivePlayer].ByExCard = true;
                FinExchange exchange = new FinExchange(stock, companie, tVRadioComp, player, bank);
                exchange.ShowDialog();
                Close();
            }
        }
    }
}
