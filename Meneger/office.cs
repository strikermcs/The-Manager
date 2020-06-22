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
    public partial class office : Form
    {
        public Stock[] stock;
        public Player[] player;
        LogForm log;
        public office(Stock[] stocks, Player[] players,LogForm logForm)
        {
            InitializeComponent();
            stock = stocks;
            player = players;
            log = logForm;
            ExecuteOffice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ExecuteOffice()
        {
            int number;
            Random random = new Random();
            number = random.Next(1, 16);
            switch (number)
            {
                case 1:
                    pictureBox1.Image = Res.off1;
                    player[data.ActivePlayer].HaveALawyer += 1;
                    log.AddLog(player[data.ActivePlayer], "Офис", "У вас блестящий адвокат конфликтов с интерполом нет");
                    break;
                case 2:
                    if (player[data.ActivePlayer].HaveALawyer > 0)
                    {
                        MessageBox.Show("У вас хороший адвокат!!! Вопросы с интерполом решины", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        pictureBox1.Image = Res.off2;
                        player[data.ActivePlayer].CanMove = false;
                        player[data.ActivePlayer].Money -= 200;
                        log.AddLog(player[data.ActivePlayer], "Офис", "Вы задержаны интерполом. При переходе через СТАРТ" +
                            " не получаете 200 АС ");
                    }
                    break;
                case 3:
                    pictureBox1.Image = Res.off3;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Премьера в опере. От каждого игрока получите 50 АС");
                    switch (data.ActivePlayer)
                    {
                        case 0:
                            player[0].Money += 100;
                            player[1].Money -= 50;
                            player[2].Money -= 50;
                            break;
                        case 1:
                            player[1].Money += 100;
                            player[0].Money -= 50;
                            player[2].Money -= 50;
                            break;
                        case 2:
                            player[2].Money += 100;
                            player[0].Money -= 50;
                            player[1].Money -= 50;
                            break;
                    }
                    break;
                case 4:
                    pictureBox1.Image = Res.off4;
                    player[data.ActivePlayer].Money += 10;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Вы получили первый приз на конкурсе красоты. Получите 10 АС");
                    break;
                case 5:
                    pictureBox1.Image = Res.off5;
                    player[data.ActivePlayer].HaveAExchangeCard += 1;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Вы акредитовали место на бирже");
                    break;
                case 6:
                    pictureBox1.Image = Res.off6;
                    player[data.ActivePlayer].Money -= 100;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Уплатите доктору 100 АС");
                    break;
                case 7:
                    pictureBox1.Image = Res.off7;
                    player[data.ActivePlayer].Money += 100;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Вы унаследовали 100 АС");
                    break;
                case 8:
                    pictureBox1.Image = Res.off8;
                    player[data.ActivePlayer].Money += 100;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Вы окончили Киевскую школу менеджеров. " +
                        "Ваши деловые качества улучшились. Получите 100 АС");
                    break;
                case 9:
                    pictureBox1.Image = Res.off9;
                    player[data.ActivePlayer].Money += 45;
                    log.AddLog(player[data.ActivePlayer], "Офис", "От продажи акций палучите 45 АС");
                    break;
                case 10:
                    pictureBox1.Image = Res.off10;
                    player[data.ActivePlayer].Money += 100;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Рождество!!! Получите 100 АС");
                    break;
                case 11:
                    pictureBox1.Image = Res.off11;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Передвигайтесь на СТАРТ, получите 200 АС ");

                    data.ReMove = true;
                    break;
                case 12:
                    pictureBox1.Image = Res.off12;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Вы оценили ремонт своих улиц за каждый дом 40 АС за отель 115 АС");
                    // Вы оценили ремонт своих улиц за каждый дом 40 ас за отель 115 ас
                    int build = 0;
                    int hotel = 0;
                    int sumb = 0;
                    int sumh = 0;
                    int rezult;
                    for (int i = 0; i < stock.Length; i++)
                    {
                        if (stock[i].Owner == data.ActivePlayer + 1)
                        {
                            if (stock[i].Buildings <= 4) build += stock[i].Buildings;
                            else
                            {
                                build += 4;
                                hotel++;
                            }
                        }
                    }
                    sumb = build * 40; sumh = hotel * 115;
                    rezult = sumb + sumh;
                    MessageBox.Show("Ремонт улиц:\n\tКоличество домов: " + build + "\n\tколичество отелей: " + hotel + "\n" +
                        "Итого с Вас: " + rezult + " АС", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player[data.ActivePlayer].Money -= rezult;
                    break;
                case 13:
                    pictureBox1.Image = Res.off13;
                    player[data.ActivePlayer].Money -= 50;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Уплатите услуги сервиса 50 АС ");
                    break;
                case 14:
                    pictureBox1.Image = Res.off14;
                    player[data.ActivePlayer].Money += 200;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Банк ошибся в вашу пользу, получите 200 АС ");
                    break;
                case 15:
                    pictureBox1.Image = Res.off15;
                    MessageBox.Show("Благотварительный фонд на данное времмя состовляет: " + data.BlagoFond.ToString(), "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player[data.ActivePlayer].Money += data.BlagoFond;
                    log.AddLog(player[data.ActivePlayer], "Офис", "Получите благотворительный фонд");
                    data.BlagoFond = 0;
                    break;

            }
        }
        private void office_Load(object sender, EventArgs e)
        {
           
        }
    }
}
