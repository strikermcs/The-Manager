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

    public partial class Locationmy : Form
    {
        Stock stocke;
        Player[] player;
        Stock[] stocksr;
        string tmpstring;
        LogForm log;
        public Image GetImage(int index)
        {
            switch (index)
            {
                case 1: return stock._1;
                case 2: return stock._2;
                case 3: return stock._3;
                case 4: return stock._4;
                case 5: return stock._5;
                case 6: return stock._6;
                case 7: return stock._7;
                case 8: return stock._8;
                case 9: return stock._9;
                case 10: return stock._10;
                case 11: return stock._11;
                case 12: return stock._12;
                case 13: return stock._13;
                case 14: return stock._14;
                case 15: return stock._15;
                case 16: return stock._16;
                case 17: return stock._17;
                case 18: return stock._18;
                case 19: return stock._19;
                case 20: return stock._20;
                case 21: return stock._21;
                case 22: return stock._22;

                case 31: return stock._1x;
                case 32: return stock._2x;
                case 33: return stock._3x;
                case 34: return stock._4x;
                case 35: return stock._5x;
                case 36: return stock._6x;
                case 37: return stock._7x;
                case 38: return stock._8x;
                case 39: return stock._9x;
                case 40: return stock._10x;
                case 41: return stock._11x;
                case 42: return stock._12x;
                case 43: return stock._13x;
                case 44: return stock._14x;
                case 45: return stock._15x;
                case 46: return stock._16x;
                case 47: return stock._17x;
                case 48: return stock._18x;
                case 49: return stock._19x;
                case 50: return stock._20x;
                case 51: return stock._21x;
                case 52: return stock._22x;

                default: return null;
            }

        }
        public Image GetbackImage(int index)
        {
            switch (index)
            {
                case 1: return BackGround._1f;
                case 2: return BackGround._2f;
                case 3: return BackGround._3f;
                case 4: return BackGround._4f;
                case 5: return BackGround._5f;
                case 6: return BackGround._6f;
                case 7: return BackGround._7f;
                case 8: return BackGround._8f;
                case 9: return BackGround._9f;
                case 10: return BackGround._9f;
                case 11: return BackGround._10f;
                case 12: return BackGround._11f;
                case 13: return BackGround._8f;
                case 14: return BackGround._13f;
                case 15: return BackGround._14f;
                case 16: return BackGround._15f;
                case 17: return BackGround._16f;
                case 18: return BackGround._17f;
                case 19: return BackGround._18f;
                case 20: return BackGround._19f;
                case 21: return BackGround._20f;
                case 22: return BackGround._22f;
                default: return null;
            }

        }

        public Locationmy(Stock stocker, Player[] players, Stock[] stocks, LogForm  logForm)
        {


            InitializeComponent();
            stocke = stocker;
            player = players;
            stocksr = stocks;
            log = logForm;
            if (!players[data.ActivePlayer].CompORUser)
            {

                ComputerIntellLocation();

            }
            else
            {

                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                if (stocker.Owner == 4) StockBox.Image = GetImage(stocker.PictureIndex + 30);
                else StockBox.Image = GetImage(stocker.PictureIndex);
                Text = stocker.Name;
                AboutText.Text = stocker.History;

                BuyLayButton.Text = "Купить: " + stocke.Price.ToString() + " АС";
                if (players[data.ActivePlayer].Position != stocker.CompPosition)
                {
                    CloseButton.Enabled = true;
                    BuyHouseButton.Enabled = false;
                    BuyHotelButton.Enabled = false;
                    BuyLayButton.Enabled = false;
                    CanselSaleButton.Enabled = false;
                    if (stocke.Owner == 0) tmpstring = "Владельца нет";

                    else if (stocke.Owner == 4) tmpstring = "Имущество заложенно";
                    else tmpstring = players[stocke.Owner - 1].Name;
                    UserNameLabel.Text = tmpstring;
                    if (stocke.Buildings <= 4) QuantityHauseLabel.Text = stocke.Buildings.ToString();
                    if (stocke.Buildings == 5)
                    {
                        QuantityHauseLabel.Text = "4";
                        QuantityHotelLabel.Text = "1";
                    }
                }
                else
                {
                    CloseButton.Enabled = false;
                    BuyHouseButton.Enabled = false;
                    BuyHotelButton.Enabled = false;

                    if (stocke.Owner == 0)
                    {
                        tmpstring = "Владельца нет";
                        BuyLayButton.Enabled = true;
                        CanselSaleButton.Enabled = true;
                    }
                    else if (stocke.Owner == 4)
                    {
                        CloseButton.Enabled = true;
                        BuyHouseButton.Enabled = false;
                        BuyHotelButton.Enabled = false;
                        BuyLayButton.Enabled = false;
                        CanselSaleButton.Enabled = false;
                        tmpstring = "Имущество заложенно";
                    }
                    else
                    {
                        CloseButton.Enabled = true;
                        BuyHouseButton.Enabled = false;
                        BuyHotelButton.Enabled = false;
                        BuyLayButton.Enabled = false;
                        CanselSaleButton.Enabled = false;


                        switch (stocke.Owner)
                        {
                            case 1:
                                if (data.ActivePlayer != stocke.Owner - 1 && data.PlayerIsDo == false)
                                {
                                    switch (stocke.Buildings)
                                    {
                                        case 0:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                                "размере " + stocke.Rent.ToString() + " АС");
                                            players[0].Money += stocke.Rent;
                                            players[data.ActivePlayer].Money -= stocke.Rent;
                                            log.AddLog(players[data.ActivePlayer],"Платит аренду "+players[0].Name+" " +
                                                "в размере "+ stocke.Rent+ " АС, за посещение " + stocke.Name);
                                            break;
                                        case 1:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithOneHouse.ToString() + " АС");
                                            players[0].Money += stocke.RentWithOneHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithOneHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " " +
                                               "в размере " + stocke.RentWithOneHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 2:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithTwoHouse.ToString() + " АС");
                                            players[0].Money += stocke.RentWithTwoHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithTwoHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " " +
                                               "в размере " + stocke.RentWithTwoHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 3:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithThreeHouse.ToString() + " АС");
                                            players[0].Money += stocke.RentWithThreeHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithThreeHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " " +
                                               "в размере " + stocke.RentWithThreeHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 4:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithFourHouse.ToString() + " АС");
                                            players[0].Money += stocke.RentWithFourHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithFourHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " " +
                                               "в размере " + stocke.RentWithFourHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 5:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithHotel.ToString() + " АС");
                                            players[0].Money += stocke.RentWithHotel;
                                            players[data.ActivePlayer].Money -= stocke.RentWithHotel;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " " +
                                               "в размере " + stocke.RentWithHotel + " АС, за посещение " + stocke.Name);
                                            break;

                                    }
                                    data.PlayerIsDo = true;


                                }
                                else
                                {
                                    CloseButton.Enabled = true;
                                    if (stocke.Buildings < 4)
                                    {
                                        BuyHouseButton.Enabled = true;
                                        BuyHotelButton.Enabled = false;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;

                                    }
                                    else if (stocke.Buildings == 4)
                                    {
                                        BuyHouseButton.Enabled = false;
                                        BuyHotelButton.Enabled = true;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;
                                    }
                                    else
                                    {
                                        BuyHouseButton.Enabled = false;
                                        BuyHotelButton.Enabled = false;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;
                                    }

                                }
                                break;
                            case 2:
                                if (data.ActivePlayer != stocke.Owner - 1 && data.PlayerIsDo == false)
                                {
                                    switch (stocke.Buildings)
                                    {
                                        case 0:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                                "размере " + stocke.Rent.ToString() + " АС");
                                            players[1].Money += stocke.Rent;
                                            players[data.ActivePlayer].Money -= stocke.Rent;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " " +
                                               "в размере " + stocke.Rent + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 1:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithOneHouse.ToString() + " АС");
                                            players[1].Money += stocke.RentWithOneHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithOneHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " " +
                                              "в размере " + stocke.RentWithOneHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 2:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithTwoHouse.ToString() + " АС");
                                            players[1].Money += stocke.RentWithTwoHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithTwoHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " " +
                                              "в размере " + stocke.RentWithTwoHouse + " АС, за посещение "+stocke.Name);
                                            break;
                                        case 3:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithThreeHouse.ToString() + " АС");
                                            players[1].Money += stocke.RentWithThreeHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithThreeHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " " +
                                              "в размере " + stocke.RentWithThreeHouse + " АС, за посещение "+stocke.Name);
                                            break;
                                        case 4:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithFourHouse.ToString() + " АС");
                                            players[1].Money += stocke.RentWithFourHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithFourHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " " +
                                              "в размере " + stocke.RentWithFourHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 5:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithHotel.ToString() + " АС");
                                            players[1].Money += stocke.RentWithHotel;
                                            players[data.ActivePlayer].Money -= stocke.RentWithHotel;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " " +
                                              "в размере " + stocke.RentWithHotel + " АС, за посещение " + stocke.Name);
                                            break;
                                    }
                                    data.PlayerIsDo = true;
                                }
                                else
                                {
                                    CloseButton.Enabled = true;
                                    if (stocke.Buildings < 4)
                                    {
                                        BuyHouseButton.Enabled = true;
                                        BuyHotelButton.Enabled = false;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;

                                    }
                                    else if (stocke.Buildings == 4)
                                    {
                                        BuyHouseButton.Enabled = false;
                                        BuyHotelButton.Enabled = true;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;
                                    }
                                    else
                                    {
                                        BuyHouseButton.Enabled = false;
                                        BuyHotelButton.Enabled = false;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;
                                    }

                                }
                                break;

                            case 3:
                                if (data.ActivePlayer != stocke.Owner - 1 && data.PlayerIsDo == false)
                                {
                                    switch (stocke.Buildings)
                                    {
                                        case 0:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                                "размере " + stocke.Rent.ToString() + " АС");
                                            players[2].Money += stocke.Rent;
                                            players[data.ActivePlayer].Money -= stocke.Rent;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " " +
                                              "в размере " + stocke.Rent + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 1:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithOneHouse.ToString() + " АС");
                                            players[2].Money += stocke.RentWithOneHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithOneHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " " +
                                              "в размере " + stocke.RentWithOneHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 2:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithTwoHouse.ToString() + " АС");
                                            players[2].Money += stocke.RentWithTwoHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithTwoHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " " +
                                              "в размере " + stocke.RentWithTwoHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 3:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithThreeHouse.ToString() + " АС");
                                            players[2].Money += stocke.RentWithThreeHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithThreeHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " " +
                                              "в размере " + stocke.RentWithThreeHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 4:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithFourHouse.ToString() + " АС");
                                            players[2].Money += stocke.RentWithFourHouse;
                                            players[data.ActivePlayer].Money -= stocke.RentWithFourHouse;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " " +
                                              "в размере " + stocke.RentWithFourHouse + " АС, за посещение " + stocke.Name);
                                            break;
                                        case 5:
                                            MessageBox.Show("Вы находитесь на чужой територии. вы должны уплатить ренту в " +
                                               "размере " + stocke.RentWithHotel.ToString() + " АС");
                                            players[2].Money += stocke.RentWithHotel;
                                            players[data.ActivePlayer].Money -= stocke.RentWithHotel;
                                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " " +
                                              "в размере " + stocke.RentWithHotel + " АС, за посещение " + stocke.Name);
                                            break;

                                    }
                                    data.PlayerIsDo = true;

                                }
                                else
                                {
                                    CloseButton.Enabled = true;
                                    if (stocke.Buildings < 4)
                                    {
                                        BuyHouseButton.Enabled = true;
                                        BuyHotelButton.Enabled = false;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;

                                    }
                                    else if (stocke.Buildings == 4)
                                    {
                                        BuyHouseButton.Enabled = false;
                                        BuyHotelButton.Enabled = true;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;
                                    }
                                    else
                                    {
                                        BuyHouseButton.Enabled = false;
                                        BuyHotelButton.Enabled = false;
                                        BuyLayButton.Enabled = false;
                                        CanselSaleButton.Enabled = false;
                                    }

                                }
                                break;

                        }
                        tmpstring = players[stocke.Owner - 1].Name;
                    }
                    UserNameLabel.Text = tmpstring;
                    if (stocke.Buildings <= 4) QuantityHauseLabel.Text = stocke.Buildings.ToString();
                    if (stocke.Buildings == 5)
                    {
                        QuantityHauseLabel.Text = "4";
                        QuantityHotelLabel.Text = "1";
                    }
                }
                ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player[data.ActivePlayer].Money >= stocke.Price)
            {
                BuyLocation();
                log.AddLog(player[data.ActivePlayer], "Покупает " + stocke.Name+ " " +
                                              "за " + stocke.Price + " АС");
                MessageBox.Show("Недвижимость приобретена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auction auction = new Auction(stocke, player);
            auction.ShowDialog();
            Close();
        }

        private void Locationmy_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(GetbackImage(stocke.PictureIndex), new Point(0, 0));
        }

        private void Locationmy_MouseDown(object sender, MouseEventArgs e)
        {

            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);

        }

        private void Locationmy_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuyHouseButton_Click(object sender, EventArgs e)
        {
            if (data.ActivePlayer == stocke.Owner - 1)
            {
                if (stocke.CompPosition == 1 || stocke.CompPosition == 3)
                {
                    if (stocksr[0].Owner == stocksr[1].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " +stocke.Name );
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else if (stocke.CompPosition == 6 || stocke.CompPosition == 8 || stocke.CompPosition == 9)
                {

                    if (stocksr[2].Owner == stocksr[3].Owner && stocksr[3].Owner == stocksr[4].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
                else if (stocke.CompPosition == 11 || stocke.CompPosition == 13 || stocke.CompPosition == 14)
                {

                    if (stocksr[5].Owner == stocksr[6].Owner && stocksr[6].Owner == stocksr[7].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
                else if (stocke.CompPosition == 16 || stocke.CompPosition == 18 || stocke.CompPosition == 19)
                {

                    if (stocksr[8].Owner == stocksr[9].Owner && stocksr[9].Owner == stocksr[10].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
                else if (stocke.CompPosition == 21 || stocke.CompPosition == 23 || stocke.CompPosition == 24)
                {

                    if (stocksr[11].Owner == stocksr[12].Owner && stocksr[12].Owner == stocksr[13].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
                else if (stocke.CompPosition == 26 || stocke.CompPosition == 27 || stocke.CompPosition == 29)
                {

                    if (stocksr[14].Owner == stocksr[15].Owner && stocksr[15].Owner == stocksr[16].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
                else if (stocke.CompPosition == 31 || stocke.CompPosition == 32 || stocke.CompPosition == 34)
                {

                    if (stocksr[17].Owner == stocksr[18].Owner && stocksr[18].Owner == stocksr[19].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
                else if (stocke.CompPosition == 37 || stocke.CompPosition == 39)
                {

                    if (stocksr[20].Owner == stocksr[21].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 4)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            MessageBox.Show("Дом успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                            Close();
                        }
                        else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Для постройки домов вы должны владеть всеми акциями данной цветовой " +
                      "категории", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }



                }
            }
            else
            {
                MessageBox.Show("Только владелец этой акции здесь может строить дома", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }


        }

        private void BuyHotelButton_Click(object sender, EventArgs e)
        {
            if (data.ActivePlayer == stocke.Owner - 1)
            {
                if (player[data.ActivePlayer].Money >= stocke.HousePrice)
                {
                    player[data.ActivePlayer].Money -= stocke.HousePrice;
                    stocke.Buildings += 1;
                    MessageBox.Show("Отель успешно постоен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);
                    Close();
                }
                else MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("Только владелец этой акции здесь может строить дома", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
        }

        public void BuyLocation()
        {
            stocke.Owner = (byte)(data.ActivePlayer + 1);
            player[data.ActivePlayer].AddStock(stocke);
            player[data.ActivePlayer].Money -= stocke.Price;
        }


        //------------------------------------------------------------------------------------------------
        public void ComputerIntellLocation()
        {
            if(stocke.Owner != 0 && stocke.Owner != data.ActivePlayer + 1)
            {
                PayForRent();
            }
            else if(stocke.Owner == data.ActivePlayer + 1)
            {
               BuildAHouse();
                    
            }else if(player[data.ActivePlayer].Money > stocke.Price + 300)
            {
                BuyLocation();
                log.AddLog(player[data.ActivePlayer], "Покупает " + stocke.Name + " " +
                                             "за " + stocke.Price + " АС");
            }

            Close();
        }

        //--------------------------------------------------------------------------------------------------

        public void PayForRent()
        {
            switch (stocke.Owner)
            {
                case 1:

                    switch (stocke.Buildings)
                    {
                        case 0:
                            player[0].Money += stocke.Rent;
                            player[data.ActivePlayer].Money -= stocke.Rent;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " " +
                                               "в размере " + stocke.Rent + " АС, за посещение " + stocke.Name);
                            break;
                        case 1:
                            player[0].Money += stocke.RentWithOneHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithOneHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " " +
                                              "в размере " + stocke.RentWithOneHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 2:
                            player[0].Money += stocke.RentWithTwoHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithTwoHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " " +
                                              "в размере " + stocke.RentWithTwoHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 3:
                            player[0].Money += stocke.RentWithThreeHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithThreeHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " " +
                                              "в размере " + stocke.RentWithThreeHouse + " АС, за посещение "+stocke.Name);
                            break;
                        case 4:
                            player[0].Money += stocke.RentWithFourHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithFourHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " " +
                                              "в размере " + stocke.RentWithFourHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 5:
                            player[0].Money += stocke.RentWithHotel;
                            player[data.ActivePlayer].Money -= stocke.RentWithHotel;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " " +
                                              "в размере " + stocke.RentWithHotel + " АС, за посещение " + stocke.Name);
                            break;

                    }

                    break;

                case 2:

                    switch (stocke.Buildings)
                    {
                        case 0:
                            player[1].Money += stocke.Rent;
                            player[data.ActivePlayer].Money -= stocke.Rent;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " " +
                                              "в размере " + stocke.Rent + " АС, за посещение " + stocke.Name);
                            break;
                        case 1:
                            player[1].Money += stocke.RentWithOneHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithOneHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " " +
                                             "в размере " + stocke.RentWithOneHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 2:
                            player[1].Money += stocke.RentWithTwoHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithTwoHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " " +
                                             "в размере " + stocke.RentWithTwoHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 3:
                            player[1].Money += stocke.RentWithThreeHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithThreeHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " " +
                                             "в размере " + stocke.RentWithThreeHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 4:
                            player[1].Money += stocke.RentWithFourHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithFourHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " " +
                                             "в размере " + stocke.RentWithFourHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 5:
                            player[1].Money += stocke.RentWithHotel;
                            player[data.ActivePlayer].Money -= stocke.RentWithHotel;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " " +
                                             "в размере " + stocke.RentWithHotel + " АС, за посещение "+stocke.Name);
                            break;
                    }

                    break;

                case 3:

                    switch (stocke.Buildings)
                    {
                        case 0:
                            player[2].Money += stocke.Rent;
                            player[data.ActivePlayer].Money -= stocke.Rent;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " " +
                                             "в размере " + stocke.Rent + " АС, за посещение "+stocke.Name);
                            break;
                        case 1:
                            player[2].Money += stocke.RentWithOneHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithOneHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " " +
                                            "в размере " + stocke.RentWithOneHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 2:
                            player[2].Money += stocke.RentWithTwoHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithTwoHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " " +
                                            "в размере " + stocke.RentWithTwoHouse + " АС, за посещение "+stocke.Name);
                            break;
                        case 3:
                            player[2].Money += stocke.RentWithThreeHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithThreeHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " " +
                                            "в размере " + stocke.RentWithThreeHouse + " АС, за посещение " + stocke.Name);
                            break;
                        case 4:
                            player[2].Money += stocke.RentWithFourHouse;
                            player[data.ActivePlayer].Money -= stocke.RentWithFourHouse;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " " +
                                            "в размере " + stocke.RentWithFourHouse + " АС, за посещение "+stocke.Name);
                            break;
                        case 5:
                            player[2].Money += stocke.RentWithHotel;
                            player[data.ActivePlayer].Money -= stocke.RentWithHotel;
                            log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " " +
                                            "в размере " + stocke.RentWithHotel + " АС, за посещение "+stocke.Name);
                            break;

                    }

                    break;

            }
        }

        public void BuildAHouse()
        {
            if (data.ActivePlayer == stocke.Owner - 1)
            {
                if (stocke.CompPosition == 1 || stocke.CompPosition == 3)
                {
                    if (stocksr[0].Owner == stocksr[1].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                       

                    }
                   
                }
                else if (stocke.CompPosition == 6 || stocke.CompPosition == 8 || stocke.CompPosition == 9)
                {

                    if (stocksr[2].Owner == stocksr[3].Owner && stocksr[3].Owner == stocksr[4].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                        
                    }
                    



                }
                else if (stocke.CompPosition == 11 || stocke.CompPosition == 13 || stocke.CompPosition == 14)
                {

                    if (stocksr[5].Owner == stocksr[6].Owner && stocksr[6].Owner == stocksr[7].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                       
                    }
                   



                }
                else if (stocke.CompPosition == 16 || stocke.CompPosition == 18 || stocke.CompPosition == 19)
                {

                    if (stocksr[8].Owner == stocksr[9].Owner && stocksr[9].Owner == stocksr[10].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                        
                    }
                   


                }
                else if (stocke.CompPosition == 21 || stocke.CompPosition == 23 || stocke.CompPosition == 24)
                {

                    if (stocksr[11].Owner == stocksr[12].Owner && stocksr[12].Owner == stocksr[13].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                        
                    }
                   



                }
                else if (stocke.CompPosition == 26 || stocke.CompPosition == 27 || stocke.CompPosition == 29)
                {

                    if (stocksr[14].Owner == stocksr[15].Owner && stocksr[15].Owner == stocksr[16].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                       
                    }
                   


                }
                else if (stocke.CompPosition == 31 || stocke.CompPosition == 32 || stocke.CompPosition == 34)
                {

                    if (stocksr[17].Owner == stocksr[18].Owner && stocksr[18].Owner == stocksr[19].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                       
                    }
                   



                }
                else if (stocke.CompPosition == 37 || stocke.CompPosition == 39)
                {

                    if (stocksr[20].Owner == stocksr[21].Owner)
                    {
                        if (player[data.ActivePlayer].Money >= stocke.HousePrice && stocke.Buildings < 5)
                        {
                            player[data.ActivePlayer].Money -= stocke.HousePrice;
                            stocke.Buildings += 1;
                            log.AddLog(player[data.ActivePlayer], "Пострил дом в " + stocke.Name);

                        }
                       
                    }
                   



                }
            }
          
        }
    }
    
}
