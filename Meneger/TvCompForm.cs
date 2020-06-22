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
    public partial class TvCompForm : Form
    {
        TVRadioComp TVRadio;
        string tmpstring;
        Player[] players;
        LogForm log;
        TVRadioComp[] TVRadios;
        int indexComp; 
        public Image GetImage(int index)
        {
            switch (index)
            {
                case 27: return stock._27;
                case 28: return stock._28;

                case 57: return stock._27x;
                case 58: return stock._28x;

                default: return null;
            }

        }
        public Image GetbackImage(int index)
        {
            switch (index)
            {
                case 27: return BackGround.Re;
                case 28: return BackGround.TV;
               

                default: return null;
            }

        }
        public TvCompForm(TVRadioComp tVRadioComp, Player[] player,TVRadioComp[] tVRadioComps,int index,LogForm logForm)
        {
           

            InitializeComponent();

            TVRadio = tVRadioComp;
            TVRadios = tVRadioComps;
            players = player;
            log = logForm;
            indexComp = index;
            if (!players[data.ActivePlayer].CompORUser)
            {
                ComputerIntellTVRadioLocation();
            }
            else
            {

                CloseButton.Enabled = false;
                if (tVRadioComp.Owner == 4) TvCompBox.Image = GetImage(TVRadio.ImageIndex + 30);
                else TvCompBox.Image = GetImage(TVRadio.ImageIndex);
                if (TVRadio.Owner == 0) tmpstring = "Владельца нет";
                else if (TVRadio.Owner == 4) tmpstring = "Заложенно";
                else tmpstring = players[TVRadio.Owner - 1].Name;
                UserNameLabel.Text = tmpstring;

                if (TVRadio.Owner == 0)
                {
                    tmpstring = "Владельца нет";
                    BuyLayButton.Enabled = true;
                    CanselSaleButton.Enabled = true;
                }
                else if (TVRadio.Owner == 4)
                {
                    BuyLayButton.Enabled = false;
                    CanselSaleButton.Enabled = true;
                }
                else
                {
                    BuyLayButton.Enabled = false;
                    CanselSaleButton.Enabled = false;

                    switch (TVRadio.Owner)
                    {
                        case 1:
                            if (data.ActivePlayer != TVRadio.Owner - 1)
                            {
                                if (index == 0)
                                {
                                    if (tVRadioComps[1].Owner == 1)
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, true, 0);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                    else
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, false, 0);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                }
                                else
                                {

                                    if (tVRadioComps[0].Owner == 1)
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, true, 0);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                    else
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, false, 0);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Это ваша компания", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CloseButton.Enabled = true;
                            }
                            break;


                        case 2:
                            if (data.ActivePlayer != TVRadio.Owner - 1)
                            {
                                if (index == 0)
                                {
                                    if (tVRadioComps[1].Owner == 2)
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, true, 1);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                    else
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, false, 1);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                }
                                else
                                {

                                    if (tVRadioComps[0].Owner == 2)
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, true, 1);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                    else
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, false, 1);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Это ваша компания", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CloseButton.Enabled = true;
                            }
                            break;

                        case 3:
                            if (data.ActivePlayer != TVRadio.Owner - 1)
                            {
                                if (index == 0)
                                {
                                    if (tVRadioComps[1].Owner == 3)
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, true, 2);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                    else
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, false, 2);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                }
                                else
                                {

                                    if (tVRadioComps[0].Owner == 3)
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, true, 2);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                    else
                                    {
                                        TvCompanyPay companyPay = new TvCompanyPay(players, false, 2);
                                        companyPay.ShowDialog();
                                        CloseButton.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Это ваша компания", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CloseButton.Enabled = true;
                            }
                            break;
                    }

                }
                ShowDialog();
            }

        }

        private void TvCompForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void TvCompForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(GetbackImage(TVRadio.ImageIndex), new Point(0, 0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CanselSaleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuyLayButton_Click(object sender, EventArgs e)
        {
            if (players[data.ActivePlayer].Money >= TVRadio.Price)
            {
                TVRadio.Owner = (byte)(data.ActivePlayer + 1);
                players[data.ActivePlayer].AddStock(TVRadio);
                players[data.ActivePlayer].Money -= TVRadio.Price;
                MessageBox.Show("Недвижимость приобретена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.AddLog(players[data.ActivePlayer], "Покупает " + TVRadio.Name + ", за " + TVRadio.Price + " АС");
                Close();
            }
            else
            {
                MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }


        public void BuyTVComp()
        {
            TVRadio.Owner = (byte)(data.ActivePlayer + 1);
            players[data.ActivePlayer].AddStock(TVRadio);
            players[data.ActivePlayer].Money -= TVRadio.Price;
        }

        public void PayRent()
        {
            int kosti;
            int renta;
           
            Random rnd = new Random();
            kosti = rnd.Next(2, 13);
           
            switch (TVRadio.Owner)
            {
                case 1:
                   
                        if (indexComp == 0)
                        {
                            if (TVRadios[1].Owner == 1)
                            {
                                renta = TVRadioComp.GetRenta(true, kosti);
                                if (data.TVCompServise == true) renta *= 2;
                                players[0].Money += renta;
                                players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                        }
                            else
                            {
                            renta = TVRadioComp.GetRenta(false, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[0].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                            }
                        }
                        else
                        {

                            if (TVRadios[0].Owner == 1)
                            {
                            renta = TVRadioComp.GetRenta(true, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[0].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                        }
                            else
                            {
                            renta = TVRadioComp.GetRenta(false, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[0].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[0].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                            }
                        }
                  
                   break;


                case 2:
                   
                        if (indexComp == 0)
                        {
                            if (TVRadios[1].Owner == 2)
                            {
                            renta = TVRadioComp.GetRenta(true, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[1].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                        }
                            else
                            {
                            renta = TVRadioComp.GetRenta(false, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[1].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                             }
                        }
                        else
                        {

                            if (TVRadios[0].Owner == 2)
                            {
                            renta = TVRadioComp.GetRenta(true, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[1].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                        }
                            else
                            {
                            renta = TVRadioComp.GetRenta(false, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[1].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[1].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                             }
                        }
                    
                    
                    break;

                case 3:
                   
                        if (indexComp == 0)
                        {
                            if (TVRadios[1].Owner == 3)
                            {
                            renta = TVRadioComp.GetRenta(true, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[2].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                        }
                            else
                            {
                            renta = TVRadioComp.GetRenta(false, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[2].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                            }
                        }
                        else
                        {

                            if (TVRadios[0].Owner == 3)
                            {
                            renta = TVRadioComp.GetRenta(true, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[2].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                        }
                            else
                            {
                            renta = TVRadioComp.GetRenta(false, kosti);
                            if (data.TVCompServise == true) renta *= 2;
                            players[2].Money += renta;
                            players[data.ActivePlayer].Money -= renta;
                            log.AddLog(players[data.ActivePlayer], "Платит аренду " + players[2].Name + " за " +
                                "посещение " + TVRadio.Name + " сумму в размере " + renta + " АС");
                            }
                        }
                   
                    break;
            }
        }


        public void ComputerIntellTVRadioLocation()
        {
            if (TVRadio.Owner != data.ActivePlayer+1 && TVRadio.Owner != 0)
            {
                PayRent();
            }else if(TVRadio.Owner == 0)
            {
                if (players[data.ActivePlayer].Money > TVRadio.Price + 200)
                {
                    BuyTVComp();
                    log.AddLog(players[data.ActivePlayer], "Покупает " + TVRadio.Name + ", за " + TVRadio.Price + " АС");
                }
            }

        }
    }
}
