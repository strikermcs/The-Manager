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
    public partial class Force : Form
    {
        int Number;
        public Force(ref Player[] players,ref Stock[] stocks,ref Company[] companies,ref TVRadioComp[] tVRadioComps,LogForm log )
        {
            InitializeComponent();
            Random rand = new Random();
            Number = rand.Next(1, 16);
            switch (Number)
            {
                case 1:
                    ForcePicture.Image = Res.for1;
                    tVRadioComps[0].Price *= 2;
                    tVRadioComps[1].Price *= 2;
                    log.AddLog("Форс-мажор", "Кризис перепроизводства. Услуги Рекламной и Телекомпаний выросли в цене на 100%");
                    data.TVCompServise = true;
                    break;
                case 2:
                    ForcePicture.Image = Res.for2;
                    stocks[11].Buildings /= 2;
                    stocks[12].Buildings /= 2;
                    stocks[13].Buildings /= 2;
                    stocks[17].Buildings /= 2;
                    stocks[18].Buildings /= 2;
                    stocks[19].Buildings /= 2;
                    log.AddLog("Форс-мажор", "Ураганом уничтоженно 50% домов в крастном и оранжевом секторе");
                    break;
                case 3:
                    ForcePicture.Image = Res.for3;
                    stocks[2].Buildings = 0;
                    stocks[3].Buildings = 0;
                    stocks[4].Buildings = 0;
                    stocks[21].Buildings = 0;
                    stocks[20].Buildings = 0;
                    log.AddLog("Форс-мажор", "Наводнением уничтожено 100% домов в районах: Фиджи, Таити, Гавайские" +
                        "острова, Минатоку, Ямато");
                    break;
                case 4:
                    ForcePicture.Image = Res.for6;
                    players[0].Money -= 10;
                    players[1].Money -= 10;
                    players[2].Money -= 10;
                    data.BlagoFond += 30;
                    log.AddLog("Форс-мажор", "Леди и джентельмены, пожертвуйте в благотворительный фонд по 10 АС каждый");
                    break;
                case 5:
                    ForcePicture.Image = Res.for5;
                    stocks[0].Rent *= 2;
                    stocks[1].Rent *= 2;
                    log.AddLog("Форс-мажор", "В связи с инфляцией рента выше на 100% в районах: Пласса Майор, Гран Виа");
                    break;
                case 6:
                    ForcePicture.Image = Res.for6;
                    players[0].Money -= 10;
                    players[1].Money -= 10;
                    players[2].Money -= 10;
                    data.BlagoFond += 30;
                    log.AddLog("Форс-мажор", "Леди и джентельмены, пожертвуйте в благотворительный фонд по 10 АС каждый");
                    break;
                case 7:
                    ForcePicture.Image = Res.for7;
                    stocks[20].Rent += 10;
                    stocks[21].Rent += 10;
                    log.AddLog("Форс-мажор", "В связи с монополизацией ГОСПРОМ сектора, рента выше на 20%: Минатоку, Ямато");
                    break;
                case 8:
                    ForcePicture.Image = Res.for8;
                    stocks[8].Rent /=2;
                    stocks[9].Rent /= 2;
                    stocks[10].Rent /= 2;
                    stocks[14].Rent /= 2;
                    stocks[15].Rent /= 2;
                    stocks[16].Rent /= 2;
                    log.AddLog("Форс-мажор", "Ливневыми дождями затопило кварталы: Трафальгар сквер, Оксфорд стрит," +
                        "Уайт Холл Стрит, Сен-Дени, Бульвар Мадлен, Елесейские поля. Рента упала вдвое");
                    break;
                case 9:
                    ForcePicture.Image = Res.for9;
                    stocks[0].Buildings = 0;
                    stocks[1].Buildings = 0;
                    stocks[5].Buildings = 0;
                    stocks[6].Buildings = 0;
                    stocks[7].Buildings = 0;
                    log.AddLog("Форс-мажор", "Пожары от засухи уничтожили 100% домов в районах: Пласса Майор, Сант Анджело," +
                        "Дель Пополо, Пьяцца Венеции, Гран Виа");
                    break;
                case 10:
                    ForcePicture.Image = Res.for10;
                    for(int i = 0; i < 4; i++)
                    {
                        companies[i].Price *= 2;
                        companies[i].Renta *= 2;
                    }
                    log.AddLog("Форс-мажор", "В следствии падения цен на нефтепродукты, акции транспортных компаний выросли в цене" +
                        "на 50%, рента выросла вдвое");
                    break;
                case 11:
                    ForcePicture.Image = Res.for11;
                    for(int i = 8; i < 20; i++)
                    {
                        stocks[i].HousePrice -= ((byte)(stocks[i].HousePrice / 100 * 50));
                    }
                    log.AddLog("Форс-мажор", "На 50% снижены цены на дома в желтом, красном и оранжевом секторе ");
                    break;
                case 12:
                    ForcePicture.Image = Res.for13;
                    for (int i = 2; i < 8; i++)
                    {
                        stocks[i].Rent *= 2;
                    }
                    log.AddLog("Форс-мажор", "Открытие курортного сезона: Фиджи, Таити, Гавайские острова, Сант Анджело" +
                        ", Дель Пополо, Пьяцца Венеции. Рента выше на 50%");
                    break;
                case 13:
                    ForcePicture.Image = Res.for13;
                    for (int i = 2; i < 8; i++)
                    {
                      stocks[i].Rent *= 2 ;
                    }
                    log.AddLog("Форс-мажор", "Открытие курортного сезона: Фиджи, Таити, Гавайские острова, Сант Анджело" +
                        ", Дель Пополо, Пьяцца Венеции. Рента выше на 50%");
                    break;
                case 14:
                    ForcePicture.Image = Res.for14;
                    for (int i = 0; i < 4; i++)
                    {
                        companies[i].Price /= 2;
                        companies[i].Renta /= 2;
                    }
                    log.AddLog("Форс-мажор", "Энергетический кризис. Акции транспортных компаний упали в цене на 50%." +
                        " Рента упала вдвое");
                    break;
                case 15:
                    ForcePicture.Image = Res.for15;
                    if (tVRadioComps[0].Price >= 150 && tVRadioComps[1].Price >= 150)
                    {
                        tVRadioComps[0].Price /= 2;
                        tVRadioComps[1].Price /= 2;
                    }
                    log.AddLog("Форс-мажор", "Акции рекламной и телекомпаний упали в цене на 50%");
                    data.TVCompServise = false;
                    break;
            }
        }

       

        private void forcok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Force_Load(object sender, EventArgs e)
        {
            


        }
    }
}
