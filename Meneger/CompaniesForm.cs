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
    
    public partial class CompaniesForm : Form
    {
        Company compan;
        string tmpstring;
        Player[] player;
        Company[] companiesz;
        LogForm log;
        int CountofCompany = 0; 
        public Image GetImage(int index)
        {
            switch (index)
            {
                case 23: return stock._23;
                case 24: return stock._24;
                case 25: return stock._25;
                case 26: return stock._26;

                case 53: return stock._23x;
                case 54: return stock._24x;
                case 55: return stock._25x;
                case 56: return stock._26x;

                default: return null;
            }

        }
        public Image GetbackImage(int index)
        {
            switch (index)
            {
                case 23: return BackGround.flot;
                case 24: return BackGround.GDComp;
                case 25: return BackGround.AvtoComp;
                case 26: return BackGround.AviaComp;
               
                default: return null;
            }

        }
        public CompaniesForm(Company company, Player[] players, Company[] companies, LogForm logForm )
        {

            InitializeComponent();
            log = logForm;
            compan = company;
            player = players;
            companiesz = companies;

            if (!players[data.ActivePlayer].CompORUser)
            {
                ComputerIntellCompany();
            }
            else
            {

                SetStyle(ControlStyles.SupportsTransparentBackColor, true);

                if (company.Owner == 4) CompBox.Image = GetImage(company.ImageIndex + 30);
                else CompBox.Image = GetImage(company.ImageIndex);
               

                if (compan.Owner == 0)
                {
                    UserNameLabel.Text = "Владельца нет";
                    BuyLayButton.Enabled = true;
                    CanselSaleButton.Enabled = true;
                    CloseButton.Enabled = false;
                }
                else if (company.Owner == 4)
                {
                    UserNameLabel.Text = "Им. заложенно";
                    BuyLayButton.Enabled = false;
                    CanselSaleButton.Enabled = false;
                    CloseButton.Enabled = true;
                }
                else
                {
                    UserNameLabel.Text = player[compan.Owner - 1].Name;
                    BuyLayButton.Enabled = false;
                    CanselSaleButton.Enabled = false;

                    switch (compan.Owner)
                    {
                        case 1:
                            if (data.ActivePlayer != compan.Owner - 1)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (companiesz[i].Owner == 1) CountofCompany++;
                                }
                                MessageBox.Show("Вы находитесь на чужой територии!!! Владелец владеет " + CountofCompany.ToString() + " компаниями." +
                                    "Вы должны заплатить ренту в размере " + compan.GetRenta(CountofCompany).ToString() + " АС", "Info" +
                                    "rmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player[data.ActivePlayer].Money -= compan.GetRenta(CountofCompany);
                                player[0].Money += compan.GetRenta(CountofCompany);
                                log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " в размере " +
                        "" + compan.GetRenta(CountofCompany) + " АС за посещение " + compan.Name);
                            }


                            CloseButton.Enabled = true;

                            break;
                        case 2:
                            if (data.ActivePlayer != compan.Owner - 1)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (companiesz[i].Owner == 2) CountofCompany++;
                                }
                                MessageBox.Show("Вы находитесь на чужой територии!!! Владелец владеет " + CountofCompany.ToString() + " компаниями." +
                                    "Вы должны заплатить ренту в размере " + compan.GetRenta(CountofCompany).ToString() + " АС", "Info" +
                                    "rmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player[data.ActivePlayer].Money -= compan.GetRenta(CountofCompany);
                                player[1].Money += compan.GetRenta(CountofCompany);
                                log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " в размере " +
                        "" + compan.GetRenta(CountofCompany) + " АС за посещение " + compan.Name);
                            }


                            CloseButton.Enabled = true;
                            break;

                        case 3:

                            if (data.ActivePlayer != compan.Owner - 1)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (companiesz[i].Owner == 3) CountofCompany++;
                                }
                                MessageBox.Show("Вы находитесь на чужой територии!!! Владелец владеет " + CountofCompany.ToString() + " компаниями." +
                                    "Вы должны заплатить ренту в размере " + compan.GetRenta(CountofCompany).ToString() + " АС", "Info" +
                                    "rmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player[data.ActivePlayer].Money -= compan.GetRenta(CountofCompany);
                                player[2].Money += compan.GetRenta(CountofCompany);
                                log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " в размере " +
                        "" + compan.GetRenta(CountofCompany) + " АС за посещение " + compan.Name);
                            }


                            CloseButton.Enabled = true;
                            break;
                    }

                }
                ShowDialog();
            }
        }

        private void CompaniesForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CompaniesForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(GetbackImage(compan.ImageIndex), new Point(0, 0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuyLayButton_Click(object sender, EventArgs e)
        {
            if (player[data.ActivePlayer].Money >= compan.Price)
            {
                compan.Owner = (byte)(data.ActivePlayer + 1);
                player[data.ActivePlayer].AddStock(compan);
                player[data.ActivePlayer].Money -= compan.Price;
                MessageBox.Show("Недвижимость приобретена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.AddLog(player[data.ActivePlayer], " Купил " + compan.Name + " за " + compan.Price + " АС");
                Close();
            }
            else
            {
                MessageBox.Show("Недостаточно средств", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void CanselSaleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        public void BuyCompany()
        {
            if (player[data.ActivePlayer].Money > compan.Price+200)
            {
                compan.Owner = (byte)(data.ActivePlayer + 1);
                player[data.ActivePlayer].AddStock(compan);
                player[data.ActivePlayer].Money -= compan.Price;
                log.AddLog(player[data.ActivePlayer], " Купил " + compan.Name + " за " + compan.Price + " АС");
                
            }
        }

        public void PayRent()
        {
            switch (compan.Owner)
            {
                case 1:
                   
                    
                        for (int i = 0; i < 4; i++)
                        {
                            if (companiesz[i].Owner == 1) CountofCompany++;
                        }
                        
                        player[data.ActivePlayer].Money -= compan.GetRenta(CountofCompany);
                        player[0].Money += compan.GetRenta(CountofCompany);
                    log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[0].Name + " в размере " +
                        "" + compan.GetRenta(CountofCompany) + " АС за посещение " + compan.Name);
              break;


                case 2:
                   
                        for (int i = 0; i < 4; i++)
                        {
                            if (companiesz[i].Owner == 2) CountofCompany++;
                        }
                        player[data.ActivePlayer].Money -= compan.GetRenta(CountofCompany);
                        player[1].Money += compan.GetRenta(CountofCompany);
                    log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[1].Name + " в размере " +
                        "" + compan.GetRenta(CountofCompany) + " АС за посещение " + compan.Name);
                    break;

                case 3:

                        for (int i = 0; i < 4; i++)
                        {
                            if (companiesz[i].Owner == 3) CountofCompany++;
                        }
                        player[data.ActivePlayer].Money -= compan.GetRenta(CountofCompany);
                        player[2].Money += compan.GetRenta(CountofCompany);
                        log.AddLog(player[data.ActivePlayer], "Платит аренду " + player[2].Name + " в размере " +
                       "" + compan.GetRenta(CountofCompany) + " АС, за посещение "+compan.Name);
                  

                    break;
            }
        }

        public void ComputerIntellCompany()
        {
            if (compan.Owner != 0 && compan.Owner != data.ActivePlayer + 1)
            {
                PayRent();
            }
            else if (compan.Owner == 0) BuyCompany(); 

        }
    }
}
