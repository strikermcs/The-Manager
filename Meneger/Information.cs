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
    public partial class Information : Form
    {
        Stock[] stock;
        Company[] companie;
        TVRadioComp[] tVRadioComp;
        Player[] player;
        public Information(Stock[] stocks,Company[] companies,TVRadioComp[] tVRadioComps,Player[] players)
        {
            InitializeComponent();
            FondLabel.Text = data.BlagoFond.ToString()+" АС";
            stock = stocks;
            companie = companies;
            tVRadioComp = tVRadioComps;
            player = players;
            Stocks.SelectedIndex = 0;
            Companies.SelectedIndex = 0;
            TVCompanies.SelectedIndex = 0;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Stocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameStockBox.Text = stock[Stocks.SelectedIndex].Name;
            PriceStockBox.Text = stock[Stocks.SelectedIndex].Price.ToString();
            RentStockBox.Text = stock[Stocks.SelectedIndex].Rent.ToString();
            OneStockBox.Text = stock[Stocks.SelectedIndex].RentWithOneHouse.ToString();
            TwoStockBox.Text = stock[Stocks.SelectedIndex].RentWithTwoHouse.ToString();
            ThreeStockBox.Text = stock[Stocks.SelectedIndex].RentWithThreeHouse.ToString();
            FourStockBox.Text = stock[Stocks.SelectedIndex].RentWithFourHouse.ToString();
            MortageStockBox.Text = stock[Stocks.SelectedIndex].MortgagePrice.ToString();
            switch (stock[Stocks.SelectedIndex].Owner)
            {
                case 0:
                    OwnerStockBox.Text = "Нет";
                    break;
                case 1:
                    OwnerStockBox.Text = player[0].Name;
                    break;
                case 2:
                    OwnerStockBox.Text = player[1].Name;
                    break;
                case 3:
                    OwnerStockBox.Text = player[2].Name;
                    break;
                case 4:
                    OwnerStockBox.Text = "Банк";
                    break;
            }

            BuildingStockBox.Text = stock[Stocks.SelectedIndex].Buildings.ToString();
            PriceOfHouseBox.Text = stock[Stocks.SelectedIndex].HousePrice.ToString();
            switch (stock[Stocks.SelectedIndex].Buildings)
            {
                case 0:
                    RezultRentaBox.Text = stock[Stocks.SelectedIndex].Rent.ToString();
                    break;
                case 1:
                    RezultRentaBox.Text = stock[Stocks.SelectedIndex].RentWithOneHouse.ToString();
                    break;
                case 2:
                    RezultRentaBox.Text = stock[Stocks.SelectedIndex].RentWithTwoHouse.ToString();
                    break;
                case 3:
                    RezultRentaBox.Text = stock[Stocks.SelectedIndex].RentWithThreeHouse.ToString();
                    break;
                case 4:
                    RezultRentaBox.Text = stock[Stocks.SelectedIndex].RentWithFourHouse.ToString();
                    break;
                case 5:
                    RezultRentaBox.Text = stock[Stocks.SelectedIndex].RentWithHotel.ToString();
                    break;
            }
        }

        private void Companies_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameCompBox.Text = companie[Companies.SelectedIndex].Name;
            PriceCompbox.Text = companie[Companies.SelectedIndex].Price.ToString();
            RentCompBox.Text = companie[Companies.SelectedIndex].Renta.ToString();
            TwoCompBox.Text = companie[Companies.SelectedIndex].RentaTwo.ToString();
            ThreeCompBox.Text = companie[Companies.SelectedIndex].RentaThree.ToString();
            FourCompBox.Text = companie[Companies.SelectedIndex].RentaFour.ToString();
            MortageCompBox.Text = companie[Companies.SelectedIndex].MortgagePrice.ToString();
            switch (companie[Companies.SelectedIndex].Owner)
            {
                case 0:
                    OwnerCompBox.Text = "Нет";
                    break;
                case 1:
                    OwnerCompBox.Text = player[0].Name;
                    break;
                case 2:
                    OwnerCompBox.Text = player[1].Name;
                    break;
                case 3:
                    OwnerCompBox.Text = player[2].Name;
                    break;
                case 4:
                    OwnerStockBox.Text = "Банк";
                    break;
            }

        }

        private void TVCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTVCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].Name;
            PriceTVCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].Price.ToString();
            MortageTVCompBox.Text = tVRadioComp[TVCompanies.SelectedIndex].MortgagePrice.ToString();
            switch (tVRadioComp[TVCompanies.SelectedIndex].Owner)
            {
                case 0:
                    OwnerTvCompBox.Text = "Нет";
                    break;
                case 1:
                    OwnerTvCompBox.Text = player[0].Name;
                    break;
                case 2:
                    OwnerTvCompBox.Text = player[1].Name;
                    break;
                case 3:
                    OwnerTvCompBox.Text = player[2].Name;
                    break;
                case 4:
                    OwnerStockBox.Text = "Банк";
                    break;
            }
        }
    }
}
