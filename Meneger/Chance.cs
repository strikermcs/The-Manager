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
    public partial class Chance : Form
    {
        Player[] player;
        Stock[] stock;
        LogForm log;
        public Chance(Stock[] stocks,Player[] players,LogForm logForm)
        {
            InitializeComponent();
            player = players;
            stock = stocks;
            log = logForm;
            ExecChance();
        }

        public void ExecChance()
        {
            int number;
            Random random = new Random();
            number = random.Next(1, 16);
            switch (number)
            {
                case 1:
                    pictureBox1.Image = Res.ch1;
                    player[data.ActivePlayer].HaveAExchangeCard += 1;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "У вас есть шанс посетить биржу");
                    break;
                case 2:
                    pictureBox1.Image = Res.ch2;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Генеральный ремонт всего вашего имущиства." +
                        "Уплатите за каждый дом 25 АС, за каждый отель 100 АС ");
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
                    sumb = build * 25; sumh = hotel * 100;
                    rezult = sumb + sumh;
                    MessageBox.Show("Ремонт улиц:\n\tКоличество домов: " + build + "\n\tколичество отелей: " + hotel + "\n" +
                        "Итого с Вас: " + rezult + " АС", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player[data.ActivePlayer].Money -= rezult;
                    break;
                case 3:
                    pictureBox1.Image = Res.ch3;
                    player[data.ActivePlayer].Position = 23;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Продвигайтесь на охотный ряд");
                    data.MoveTo = true;
                    break;
                case 4:
                    pictureBox1.Image = Res.ch4;
                    if (player[data.ActivePlayer].Position < 15) player[data.ActivePlayer].Position = 15;
                    else if (player[data.ActivePlayer].Position > 15 && player[data.ActivePlayer].Position < 25)
                        player[data.ActivePlayer].Position = 25;
                    else if (player[data.ActivePlayer].Position > 25 && player[data.ActivePlayer].Position < 35)
                        player[data.ActivePlayer].Position = 35;
                    else player[data.ActivePlayer].Position = 5;
                    data.MoveTo = true;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Продвигайтесь к ближайшей транспортной компании");
                    break;
                case 5:
                    pictureBox1.Image = Res.ch5;
                    player[data.ActivePlayer].Money += 200;
                    player[data.ActivePlayer].Position = 5;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Провигайтесь на торговый флот. При переходе через СТАРТ " +
                        "получите 200 АС");
                    data.MoveTo = true;
                    break;
                case 6:
                    pictureBox1.Image = Res.ch6;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Вы избраны президентом совместного предприятия." +
                        "Получите от каждого игрока 50 АС");
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
                case 7:
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Вы задержаны интерполом. при переходе через СТАРТ не получаете 200 АС");
                    if (player[data.ActivePlayer].HaveALawyer > 0)
                    {
                       if(player[data.ActivePlayer].CompORUser) MessageBox.Show("У вас хороший адвокат!!! Вопросы с интерполом решины", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.AddLog(player[data.ActivePlayer], "Адвокат", "У тебя нет конфликтов с интерполом");
                    }
                    else
                    {
                        log.AddLog(player[data.ActivePlayer], "Задержан интерполом");
                        pictureBox1.Image = Res.ch7;
                        player[data.ActivePlayer].CanMove = false;
                        player[data.ActivePlayer].Money -= 200;
                    }
                    break;
                case 8:
                    pictureBox1.Image = Res.ch8;
                    player[data.ActivePlayer].Money += 50;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Вам возмещается подоходный налог. получите 50 АС");
                    break;
                case 9:
                    pictureBox1.Image = Res.ch9;
                    player[data.ActivePlayer].Position -= 6;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "На 6 ходов назад");
                    data.MoveTo = true;
                    break;
                case 10:
                    pictureBox1.Image = Res.ch10;
                    player[data.ActivePlayer].Money += 50;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Банк платит вам дивиденты. Получите 50 АС");
                    break;
                case 11:
                    pictureBox1.Image = Res.ch11;
                    if (player[data.ActivePlayer].Position < 12) player[data.ActivePlayer].Position = 12;
                    else player[data.ActivePlayer].Position = 28;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Продвигайтесь к ближайшей компании(ТЕЛЕ или Рекламной)");
                    data.MoveTo = true;
                    break;
                case 12:
                    pictureBox1.Image = Res.ch12;
                    player[data.ActivePlayer].Position = 0;
                    player[data.ActivePlayer].Money += 100;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Продвигайтесь на СТАРТ, получите 100 АС ");
                    data.MoveTo = true;
                    break;
                case 13:
                    pictureBox1.Image = Res.ch13;
                    player[data.ActivePlayer].CanMove = false;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Вы задержаны интерполом по ошибке");
                    break;
                case 14:
                    pictureBox1.Image = Res.ch14;
                    player[data.ActivePlayer].Position = 11;
                    player[data.ActivePlayer].Money += 200;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Продвигайтесь на Пяцца Дель Пополо");

                    data.MoveTo = true;
                    break;
                case 15:
                    pictureBox1.Image = Res.ch15;
                    player[data.ActivePlayer].Position = 39;
                    data.MoveTo = true;
                    log.AddLog(player[data.ActivePlayer], "Шанс", "Продвигайтесь в район Минатоку");
                    break;

            }
        }

        private void Chance_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
