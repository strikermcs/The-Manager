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
    public partial class Debugging : Form
    {
        public Company[] companies;
        public Player[] player;
        public Stock[] stock;
        TVRadioComp[] tVRadioComp;
        public Debugging(Company[] company,Player[] players,Stock[] stocks,TVRadioComp[] tVRadioComps)
        {
            InitializeComponent();
            companies = company;
            player = players;

            stock = stocks;
            tVRadioComp = tVRadioComps;
            BlagoFondBox.Text = data.BlagoFond.ToString();
        }

        private void Stocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameStockBox.Text =  stock[Stocks.SelectedIndex].Name;
            PriceStockBox.Text = stock[Stocks.SelectedIndex].Price.ToString();
            RentStockBox.Text = stock[Stocks.SelectedIndex].Rent.ToString();
            OneStockBox.Text = stock[Stocks.SelectedIndex].RentWithOneHouse.ToString();
            TwoStockBox.Text = stock[Stocks.SelectedIndex].RentWithTwoHouse.ToString();
            ThreeStockBox.Text = stock[Stocks.SelectedIndex].RentWithThreeHouse.ToString();
            FourStockBox.Text = stock[Stocks.SelectedIndex].RentWithFourHouse.ToString();
            MortageStockBox.Text = stock[Stocks.SelectedIndex].MortgagePrice.ToString();
            OwnerStockBox.Text = stock[Stocks.SelectedIndex].Owner.ToString();
            BuildingStockBox.Text = stock[Stocks.SelectedIndex].Buildings.ToString();
        }

        private void Companies_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameCompBox.Text = companies[Companies.SelectedIndex].Name;
            PriceCompbox.Text = companies[Companies.SelectedIndex].Price.ToString();
            RentCompBox.Text = companies[Companies.SelectedIndex].Renta.ToString();
            TwoCompBox.Text = companies[Companies.SelectedIndex].RentaTwo.ToString();
            ThreeCompBox.Text = companies[Companies.SelectedIndex].RentaThree.ToString();
            FourCompBox.Text = companies[Companies.SelectedIndex].RentaFour.ToString();
            MortageCompBox.Text = companies[Companies.SelectedIndex].MortgagePrice.ToString();
            OwnerCompBox.Text = companies[Companies.SelectedIndex].Owner.ToString();


        }

        private void TVCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTVCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].Name;
            PriceTVCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].Price.ToString();
            MortageTVCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].MortgagePrice.ToString();
            OwnerTvCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].Owner.ToString();
        }

        private void Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamePlayerBox.Text = player[Player.SelectedIndex].Name;
            MoneyPlayerBox.Text = player[Player.SelectedIndex].Money.ToString();
            StocksPlayerBox.Text = "";
            LaywerPlayerBox.Text = player[Player.SelectedIndex].HaveALawyer.ToString();
            ExchangePlayerBox.Text = player[Player.SelectedIndex].HaveAExchangeCard.ToString();
            for(int i = 0; i < player[Player.SelectedIndex].Stocks.Length; i++)
            {
                StocksPlayerBox.Text += player[Player.SelectedIndex].Stocks[i].ToString() + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.BlagoFond = Convert.ToInt32(BlagoFondBox.Text);
        }
    }
}
