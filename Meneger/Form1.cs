using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mainlib;

namespace Meneger
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Newgame Newgame = new Newgame();
            Newgame.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock[] stocks = new Stock[22];

            stocks[0] = new Stock();
            stocks[0].Name = "Гран Виа";
            stocks[0].Price = 60;
            stocks[0].Rent = 2;
            stocks[0].RentWithOneHouse = 10;
            stocks[0].RentWithTwoHouse = 30;
            stocks[0].RentWithThreeHouse = 90;
            stocks[0].RentWithFourHouse = 160;
            stocks[0].RentWithHotel = 250;
            stocks[0].HousePrice = 50;
            stocks[0].MortgagePrice = 30;
            stocks[0].History = "Гран-Виа (исп. Gran Via — «большая дорога») — улица Мадрида, неофициально считающаяся главной улицей столицы Испании." +
                "Проспект был заложен 5 апреля 1910 года королём Альфонсо XIII, который в ходе торжественной церемонии с помощью кирки выдолбил первый камень от дома священника при церкви Сан Хосе. " +
                "Этим актом было положено начало сносу более 300 зданий, необходимому для прокладки улицы.";
            stocks[0].Owner = 0;
            stocks[0].Buildings = 0;
            stocks[0].PictureIndex = 1;
            stocks[0].StockNumber = 1;
            stocks[0].CompPosition = 1;


            stocks[1] = new Stock();
            stocks[1].Name = "Пласа Майор";
            stocks[1].Price = 60;
            stocks[1].Rent = 4;
            stocks[1].RentWithOneHouse = 20;
            stocks[1].RentWithTwoHouse = 60;
            stocks[1].RentWithThreeHouse = 180;
            stocks[1].RentWithFourHouse = 320;
            stocks[1].RentWithHotel = 450;
            stocks[1].HousePrice = 50;
            stocks[1].MortgagePrice = 30;
            stocks[1].History = "Пласа-Майор (исп. Plaza Mayor — «Главная площадь») — одна из центральных площадей испанской столицы. " +
                "Расположена в части, которую принято называть «австрийским Мадридом». Соперничает с площадью Пуэрта-дель-Соль за право " +
                "именоваться главной площадью испанской столицы, но в отличие от демократичной Пуэрта-дель-Соль, Пласа-Майор — статусная" +
                " площадь, «пуп Испании», как сказал Лопе де Вега. Площадь в стиле мадридского барокко, один из немногих памятников" +
                " эпохи Габсбургов, была построена по проекту архитектора Хуана Гомеса де Моры.";
            stocks[1].Owner = 0;
            stocks[1].Buildings = 0;
            stocks[1].PictureIndex = 2;
            stocks[1].StockNumber = 2;
            stocks[1].CompPosition = 3;


            stocks[2] = new Stock();
            stocks[2].Name = "Гавайские острова";
            stocks[2].Price = 100;
            stocks[2].Rent = 6;
            stocks[2].RentWithOneHouse = 30;
            stocks[2].RentWithTwoHouse = 90;
            stocks[2].RentWithThreeHouse = 270;
            stocks[2].RentWithFourHouse = 400;
            stocks[2].RentWithHotel = 550;
            stocks[2].HousePrice = 50;
            stocks[2].MortgagePrice = 50;
            stocks[2].History = "Гава́йские острова́ (или Гавайский архипелаг, англ. Hawaiian Islands, гав. mokupuni o Hawaiʻi)" +
                " — архипелаг из 24 островов и атоллов, расположенный в северной части Тихого океана (между 19° и 29° северной широты)." +
                " Архипелаг вытянут с северо-запада на юго-восток, имеет вулканическое происхождение.";
            stocks[2].Owner = 0;
            stocks[2].Buildings = 0;
            stocks[2].PictureIndex = 3;
            stocks[2].StockNumber = 3;
            stocks[2].CompPosition = 6;

            stocks[3] = new Stock();
            stocks[3].Name = "Таити";
            stocks[3].Price = 100;
            stocks[3].Rent = 6;
            stocks[3].RentWithOneHouse = 30;
            stocks[3].RentWithTwoHouse = 90;
            stocks[3].RentWithThreeHouse = 270;
            stocks[3].RentWithFourHouse = 400;
            stocks[3].RentWithHotel = 550;
            stocks[3].HousePrice = 50;
            stocks[3].MortgagePrice = 50;
            stocks[3].History = "Таи́ти (фр. Tahiti, таит. Tahiti) — главный остров архипелага Острова Общества и всей Французской" +
                " Полинезии, а также самый крупный остров этого заморского сообщества в Тихом океане. Столица Папеэте расположена на" +
                " северо-западном побережье.";
            stocks[3].Owner = 0;
            stocks[3].Buildings = 0;
            stocks[3].PictureIndex = 4;
            stocks[3].StockNumber = 4;
            stocks[3].CompPosition = 8;


            stocks[4] = new Stock();
            stocks[4].Name = "Фиджи";
            stocks[4].Price = 120;
            stocks[4].Rent = 8;
            stocks[4].RentWithOneHouse = 40;
            stocks[4].RentWithTwoHouse = 100;
            stocks[4].RentWithThreeHouse = 300;
            stocks[4].RentWithFourHouse = 450;
            stocks[4].RentWithHotel = 600;
            stocks[4].HousePrice = 50;
            stocks[4].MortgagePrice = 60;
            stocks[4].History = "Современное название Фиджи происходит от искажённого названия главного острова страны, Вити-Леву," +
                " а именно его тонганского произношения. Жители островов Тонга издревле имели тесные связи с фиджийцами, которые" +
                " считались в регионе храбрыми воинами и жестокими каннибалами, а их оружие и другие изделия пользовались большим" +
                " спросом. Фиджийцы называли свою родину «Вити» (фидж. Viti), однако тонганцы произносили её как «Фиси» (тонг. Fisi)." +
                " Впоследствии это слово было искажено уже европейцами, а именно британским мореплавателем Джеймсом Куком," +
                " который впервые нанёс на карты современное название островов — Фиджи";
            stocks[4].Owner = 0;
            stocks[4].Buildings = 0;
            stocks[4].PictureIndex = 5;
            stocks[4].StockNumber = 5;
            stocks[4].CompPosition = 9;

            stocks[5] = new Stock();
            stocks[5].Name = "Пьяцца Дель Пополо";
            stocks[5].Price = 140;
            stocks[5].Rent = 10;
            stocks[5].RentWithOneHouse = 50;
            stocks[5].RentWithTwoHouse = 150;
            stocks[5].RentWithThreeHouse = 450;
            stocks[5].RentWithFourHouse = 625;
            stocks[5].RentWithHotel = 750;
            stocks[5].HousePrice = 100;
            stocks[5].MortgagePrice = 70;
            stocks[5].History = "Пьяцца дель Пополо (итал. Piazza del Popolo — «Народная площадь») — площадь в Риме, от которой лучами" +
                " расходятся на юг улицы Корсо (ведёт на пьяцца Венеция), Бабуино (на пьяцца ди Спанья) и Рипетта (на мавзолей Августа)." +
                " Углы между улицами занимают весьма схожие по своему облику церкви-пропилеи Санта-Мария-деи-Мираколи (1681)" +
                " и Санта-Мария-ин-Монтесанто (1679). Площадь имеет форму овала 100 × 165 м. С севера она ограничена одноимёнными " +
                "воротами — Порта-дель-Пополо. В античности ворота были частью стены Аврелиана и назывались Фламиниевыми, " +
                "потому что к северу от них начинается древняя Фламиниева дорога, по которой на протяжении столетий прибывала" +
                " в Рим основная масса путников.";
            stocks[5].Owner = 0;
            stocks[5].Buildings = 0;
            stocks[5].PictureIndex = 6;
            stocks[5].StockNumber = 6;
            stocks[5].CompPosition = 11;


            stocks[6] = new Stock();
            stocks[6].Name = "Сант-Анджело";
            stocks[6].Price = 140;
            stocks[6].Rent = 10;
            stocks[6].RentWithOneHouse = 50;
            stocks[6].RentWithTwoHouse = 150;
            stocks[6].RentWithThreeHouse = 450;
            stocks[6].RentWithFourHouse = 625;
            stocks[6].RentWithHotel = 750;
            stocks[6].HousePrice = 100;
            stocks[6].MortgagePrice = 70;
            stocks[6].History = "Сант-Анджело (итал. Monte Sant'Angelo) — коммуна в Италии, располагается в регионе Апулия, в провинции Фоджа. " +
                "Покровителем населённого пункта считается Архангел Михаил.";
            stocks[6].Owner = 0;
            stocks[6].Buildings = 0;
            stocks[6].PictureIndex = 7;
            stocks[6].StockNumber = 7;
            stocks[6].CompPosition = 13;

            stocks[7] = new Stock();
            stocks[7].Name = "Пьяцца Венеции";
            stocks[7].Price = 160;
            stocks[7].Rent = 12;
            stocks[7].RentWithOneHouse = 60;
            stocks[7].RentWithTwoHouse = 180;
            stocks[7].RentWithThreeHouse = 500;
            stocks[7].RentWithFourHouse = 700;
            stocks[7].RentWithHotel = 900;
            stocks[7].HousePrice = 100;
            stocks[7].MortgagePrice = 80;
            stocks[7].History = "Площадь расположена у подножия Капитолия и недалеко от Римского форума. Это место ещё во времена" +
                " Римской республики было важным транспортным пунктом, здесь пересекались Фламиниева дорога с Сервиевой стеной" +
                " (Porta Fontinalis). В наше время здесь пересекаются улицы Корсо, Плебисчито и Цезара Баттисты. В XV веке" +
                " венецианский кардинал Пьетро Барбо(позднее папа Павел II) построил дворец, где после 1567 года размещалось" +
                " посольство Венецианской республики.В 1660 году было построено палаццо Д'Асте, переименованное в палаццо Бонапарте," +
                " когда там обосновалась «Мадам-Мать». Свою нынешнюю форму площадь приобрела в 1909 году, когда по проекту " +
                "архитектора Камилло Пеструччи было построен новый корпус Палаццо Венеция взамен снесённой части и других разобранных" +
                " домов, что было связано с открытием перспективы на построенный монумент Виктору Эммануилу II.";
            stocks[7].Owner = 0;
            stocks[7].Buildings = 0;
            stocks[7].PictureIndex = 8;
            stocks[7].StockNumber = 8;
            stocks[7].CompPosition = 14;



            stocks[8] = new Stock();
            stocks[8].Name = "Трафальгар сквер";
            stocks[8].Price = 180;
            stocks[8].Rent = 14;
            stocks[8].RentWithOneHouse = 70;
            stocks[8].RentWithTwoHouse = 200;
            stocks[8].RentWithThreeHouse = 550;
            stocks[8].RentWithFourHouse = 750;
            stocks[8].RentWithHotel = 950;
            stocks[8].HousePrice = 100;
            stocks[8].MortgagePrice = 90;
            stocks[8].History = "Площадь появилась в начале XIX века. До этого на её месте находились королевские конюшни," +
                " после сноса которых образовался пустырь. Архитектор Джон Нэш предложил превратить его в площадь, где можно" +
                " было бы проводить собрания и устраивать городские праздники. Его план одобрили, и уже после смерти Нэша площадь" +
                " была сформирована. Завершением строительных работ руководил архитектор Чарльз Бэрри. По проекту Чарлза Бэрри" +
                " в 1840—1845 были возведены в северной части площади терраса с уступами в обе стороны, наклонные стены с восточной" +
                " и западной стороны, два бассейна и фонтаны.Согласно замыслу Бэрри, по углам площади были установлены четыре" +
                " пьедестала для памятников знаменитым британцам.";
            stocks[8].Owner = 0;
            stocks[8].Buildings = 0;
            stocks[8].PictureIndex = 9;
            stocks[8].StockNumber = 9;
            stocks[8].CompPosition = 16;


            stocks[9] = new Stock();
            stocks[9].Name = "Уайт Холл Стрит";
            stocks[9].Price = 180;
            stocks[9].Rent = 14;
            stocks[9].RentWithOneHouse = 70;
            stocks[9].RentWithTwoHouse = 200;
            stocks[9].RentWithThreeHouse = 550;
            stocks[9].RentWithFourHouse = 750;
            stocks[9].RentWithHotel = 950;
            stocks[9].HousePrice = 100;
            stocks[9].MortgagePrice = 90;
            stocks[9].History = "Уайтхолл (Whitehall) — улица в центре Лондона, название которой стало нарицательным обозначением" +
                " британского правительства. Ведёт от здания Британского парламента в Вестминстере к Трафальгарской площади." +
                " Раньше здесь располагался одноимённый королевский дворец, от которого сохранился только Банкетный дом(1622, арх.Иниго" +
                " Джонс).Место дворцовых построек со временем заняли здания Адмиралтейства и Министерства обороны. С этим связано" +
                " и расположение на улице памятника британским солдатам, павшим во время Первой мировой войны.К Уайтхоллу примыкает" +
                " Даунинг-стрит(с резиденцией премьер - министра).";
            stocks[9].Owner = 0;
            stocks[9].Buildings = 0;
            stocks[9].PictureIndex = 10;
            stocks[9].StockNumber = 10;
            stocks[9].CompPosition = 18;


            stocks[10] = new Stock();
            stocks[10].Name = "Оксфорд стрит";
            stocks[10].Price = 200;
            stocks[10].Rent = 16;
            stocks[10].RentWithOneHouse = 80;
            stocks[10].RentWithTwoHouse = 220;
            stocks[10].RentWithThreeHouse = 600;
            stocks[10].RentWithFourHouse = 800;
            stocks[10].RentWithHotel = 1000;
            stocks[10].HousePrice = 100;
            stocks[10].MortgagePrice = 100;
            stocks[10].History = "Оксфорд-стрит (англ. Oxford Street) — лондонская улица, одна из основных улиц Вестминстера. " +
                "Самая оживлённая торговая улица (548 торговых точек), известна главным образом своими фешенебельными магазинами. " +
                "Начинается в Вестминстере у Мраморной арки (северо-восточный угол Гайд-парка) и ведёт на восток в сторону Холборна." +
                " Раньше была частью Лондон-Оксфорд-роуд, которая брала начало в Ньюгейте. Сегодня часть шоссе A40. Длина улицы" +
                " составляет 2,4 километра. На улице расположены станции Лондонского Метрополитена \"Marble Arch\", \"Bond Street\", " +
                "\"Oxford Circus\", \"Tottenham Court Road\". На каждое рождество улица украшается праздничными огнями." +
                " По традиции в ноябре эти огни включаются знаменитостями. В 1968-93 гг. по этой улице курсировал «белковый человек»" +
                " Стэнли Грин.";
            stocks[10].Owner = 0;
            stocks[10].Buildings = 0;
            stocks[10].PictureIndex = 11;
            stocks[10].StockNumber = 11;
            stocks[10].CompPosition = 19;

            stocks[11] = new Stock();
            stocks[11].Name = "Улица Пятницкая";
            stocks[11].Price = 220;
            stocks[11].Rent = 18;
            stocks[11].RentWithOneHouse = 90;
            stocks[11].RentWithTwoHouse = 250;
            stocks[11].RentWithThreeHouse = 700;
            stocks[11].RentWithFourHouse = 875;
            stocks[11].RentWithHotel = 1050;
            stocks[11].HousePrice = 150;
            stocks[11].MortgagePrice = 110;
            stocks[11].History = "Пятницкая улица появилась в конце XV — начале XVI века и представляла собой часть старомосковской дороги" +
                " на юг — в Рязань, Тулу и Серпухов. В те времена её называли Большой улицей. Первоначально она проходила немного правее" +
                " современной Пятницкой, а именно там, где сейчас находится Новокузнецкая улица. К концу XVI века её направление окончательно" +
                " установилось. Своё нынешнее название улица получила благодаря церкви Параскевы Пятницы, впервые упоминавшейся" +
                " в летописях в связи с московским пожаром 1564 года";
            stocks[11].Owner = 0;
            stocks[11].Buildings = 0;
            stocks[11].PictureIndex = 12;
            stocks[11].StockNumber = 12;
            stocks[11].CompPosition = 21;


            stocks[12] = new Stock();
            stocks[12].Name = "Охотный ряд";
            stocks[12].Price = 220;
            stocks[12].Rent = 18;
            stocks[12].RentWithOneHouse = 90;
            stocks[12].RentWithTwoHouse = 250;
            stocks[12].RentWithThreeHouse = 700;
            stocks[12].RentWithFourHouse = 875;
            stocks[12].RentWithHotel = 1050;
            stocks[12].HousePrice = 150;
            stocks[12].MortgagePrice = 110;
            stocks[12].History = "Улица Охо́тный Ряд (бывш. Охотнорядская площадь, 1933—1955[источник не указан 548 дней] — площадь" +
                " Охотного Ряда, 1961—1990 — часть проспекта Маркса) — улица в Центральном административном округе города Москвы." +
                " Проходит от Манежной площади до Театральной площади, лежит между Георгиевским переулком и Никольской улицей " +
                "параллельно им";
            stocks[12].Owner = 0;
            stocks[12].Buildings = 0;
            stocks[12].PictureIndex = 13;
            stocks[12].StockNumber = 13;
            stocks[12].CompPosition = 23;

            stocks[13] = new Stock();
            stocks[13].Name = "Улица Тверская";
            stocks[13].Price = 240;
            stocks[13].Rent = 20;
            stocks[13].RentWithOneHouse = 100;
            stocks[13].RentWithTwoHouse = 300;
            stocks[13].RentWithThreeHouse = 750;
            stocks[13].RentWithFourHouse = 925;
            stocks[13].RentWithHotel = 1100;
            stocks[13].HousePrice = 150;
            stocks[13].MortgagePrice = 120;
            stocks[13].History = "Тверска́я у́лица (с 1932 по 1990 год — часть улицы Горького) — главная улица города Москвы, одна " +
                "из крупнейших улиц Тверского района Центрального административного округа. Идёт от Кремля (Моховая улица/Охотный Ряд)" +
                " на северо-запад до Триумфальной площади (Маяковского), где переходит в 1-ю Тверскую-Ямскую улицу " +
                "(в 1932—1990 годах 1-я Тверская-Ямская также была частью улицы Горького). Улица возникла как дорога в Тверь," +
                " участок которой в черте Москвы, от Иверских ворот Китайгородской стены и до ворот Земляного города, исстари" +
                " назывался Тверская улица. В первой половине XX века Тверская улица была значительно расширена и перестроена.";
            stocks[13].Owner = 0;
            stocks[13].Buildings = 0;
            stocks[13].PictureIndex = 14;
            stocks[13].StockNumber = 14;
            stocks[13].CompPosition = 24;

            stocks[14] = new Stock();
            stocks[14].Name = "Бульвар Мадлен";
            stocks[14].Price = 260;
            stocks[14].Rent = 22;
            stocks[14].RentWithOneHouse = 110;
            stocks[14].RentWithTwoHouse = 330;
            stocks[14].RentWithThreeHouse = 800;
            stocks[14].RentWithFourHouse = 975;
            stocks[14].RentWithHotel = 1150;
            stocks[14].HousePrice = 150;
            stocks[14].MortgagePrice = 130;
            stocks[14].History = "";
            stocks[14].Owner = 0;
            stocks[14].Buildings = 0;
            stocks[14].PictureIndex = 15;
            stocks[14].StockNumber = 15;
            stocks[14].CompPosition = 26;

            stocks[15] = new Stock();
            stocks[15].Name = "Елесейские поля";
            stocks[15].Price = 260;
            stocks[15].Rent = 22;
            stocks[15].RentWithOneHouse = 110;
            stocks[15].RentWithTwoHouse = 330;
            stocks[15].RentWithThreeHouse = 800;
            stocks[15].RentWithFourHouse = 975;
            stocks[15].RentWithHotel = 1150;
            stocks[15].HousePrice = 150;
            stocks[15].MortgagePrice = 130;
            stocks[15].History = "Елисе́йские поля́, или Ша(н)з-Элизе́ (фр. avenue des Champs-Élysées, [ˌʃɑ̃zeliˈze] [шанзэлизэ], " +
                "или les Champs-Élysées, или просто les Champs), — центральная улица Парижа, одна из главных магистралей VIII округа" +
                " французской столицы. Елисейские поля простираются от площади Конкорд (Согласия) до Триумфальной арки.";
            stocks[15].Owner = 0;
            stocks[15].Buildings = 0;
            stocks[15].PictureIndex = 16;
            stocks[15].StockNumber = 16;
            stocks[15].CompPosition = 27;



            stocks[16] = new Stock();
            stocks[16].Name = "Сен - Дени";
            stocks[16].Price = 280;
            stocks[16].Rent = 24;
            stocks[16].RentWithOneHouse = 120;
            stocks[16].RentWithTwoHouse = 360;
            stocks[16].RentWithThreeHouse = 850;
            stocks[16].RentWithFourHouse = 1025;
            stocks[16].RentWithHotel = 1200;
            stocks[16].HousePrice = 150;
            stocks[16].MortgagePrice = 140;
            stocks[16].History = "Сен-Дени́ (фр. Saint-Denis [sɛ̃.d(ə).ni]) — коммуна во Франции, в 9 км к северу от центра Парижа," +
                " население — 109,3 тыс. жителей (2013). Находится на правом берегу Сены, при впадении построенного в 1824 году" +
                " канала Сен-Дени, против острова того же названия. Имеет прямое транспортное сообщение с Парижем " +
                "(станция RER D Стад де Франс — Сен-Дени и четыре станции линии 13 Парижского метрополитена).";
            stocks[16].Owner = 0;
            stocks[16].Buildings = 0;
            stocks[16].PictureIndex = 17;
            stocks[16].StockNumber = 17;
            stocks[16].CompPosition = 29;

            stocks[17] = new Stock();
            stocks[17].Name = "Брайтон Бич";
            stocks[17].Price = 300;
            stocks[17].Rent = 26;
            stocks[17].RentWithOneHouse = 130;
            stocks[17].RentWithTwoHouse = 390;
            stocks[17].RentWithThreeHouse = 900;
            stocks[17].RentWithFourHouse = 1100;
            stocks[17].RentWithHotel = 1275;
            stocks[17].HousePrice = 200;
            stocks[17].MortgagePrice = 150;
            stocks[17].History = "Бра́йтон-Бич (англ. Brighton Beach) — район, расположенный в Нью-Йорке, на самом юге Бруклина," +
                " на берегу Атлантического океана. Другое название — Маленькая Одесса (англ. Little Odessa). Брайтон-Бич граничит" +
                " с Шипсхед-Бей на севере и востоке по Белт-Паркуэй, Нептьюн-авеню, Кэсс-плейс и Восточной 12-й стрит, " +
                "с Манхэттен-Бич на востоке по Корбин-плейс, с Кони-Айленд на западе по Оушен-Паркуэй.";
            stocks[17].Owner = 0;
            stocks[17].Buildings = 0;
            stocks[17].PictureIndex = 18;
            stocks[17].StockNumber = 18;
            stocks[17].CompPosition = 31;


            stocks[18] = new Stock();
            stocks[18].Name = "5-я Авеню";
            stocks[18].Price = 300;
            stocks[18].Rent = 26;
            stocks[18].RentWithOneHouse = 130;
            stocks[18].RentWithTwoHouse = 390;
            stocks[18].RentWithThreeHouse = 900;
            stocks[18].RentWithFourHouse = 1100;
            stocks[18].RentWithHotel = 1275;
            stocks[18].HousePrice = 200;
            stocks[18].MortgagePrice = 150;
            stocks[18].History = "Пя́тая авеню́ (англ. Fifth Avenue) — улица в центре Манхэттена в Нью-Йорке. Является одной из" +
                " самых известных, самых респектабельных и дорогих улиц в мире — на ней находится множество дорогих " +
                "эксклюзивных бутиков. Пятая Авеню берёт начало у Вашингтон-Сквер-парка в Гринвич-Виллидж и ведёт на север через " +
                "Мидтаун вдоль восточной стороны Центрального парка, далее через Верхний Ист-Сайд и Гарлем, и заканчивается у пролива" +
                " Гарлем-Ривер. Обилие памятников архитектуры, исторических и культурных центров, модных бутиков и эксклюзивных" +
                " магазинов сосредоточено именно на этой улице Нью-Йорка. Авеню делит остров Манхэттен на две части и является" +
                " точкой отсчёта для улиц Нью-Йорка: улицы на восток от авеню называются восточными(East), например, " +
                "Восточная 15 - я улица(англ.East 15th Street).Та же улица, но к западу от Пятой авеню будет называться Западная " +
                "15 - я улица(англ.West 15th Street).Нумерация домов возрастает от Пятой авеню, так что ближайший к ней дом" +
                " на 15 - й Восточной улице будет иметь номер 1, так же и ближайший к Пятой авеню дом на 15 - й Западной улице будет" +
                " иметь номер 1.Нумерация улиц возрастает с юга на север. Такая схема позволяет определить по адресу тот перекрёсток," +
                " на котором находится дом, и расстояния в кварталах между двумя адресами.";
            stocks[18].Owner = 0;
            stocks[18].Buildings = 0;
            stocks[18].PictureIndex = 19;
            stocks[18].StockNumber = 19;
            stocks[18].CompPosition = 32;



            stocks[19] = new Stock();
            stocks[19].Name = "Уолл - Стрит";
            stocks[19].Price = 320;
            stocks[19].Rent = 28;
            stocks[19].RentWithOneHouse = 150;
            stocks[19].RentWithTwoHouse = 450;
            stocks[19].RentWithThreeHouse = 1000;
            stocks[19].RentWithFourHouse = 1200;
            stocks[19].RentWithHotel = 1400;
            stocks[19].HousePrice = 200;
            stocks[19].MortgagePrice = 160;
            stocks[19].History = "Уо́лл-стрит (англ. Wall Street) — название небольшой узкой улицы в нижней части Манхэттена " +
                "в городе Нью-Йорк, ведущей от Бродвея к побережью пролива Ист-Ривер. Считается историческим центром Финансового" +
                " квартала города. Главная достопримечательность улицы — Нью-Йоркская фондовая биржа. В переносном смысле" +
                " так называют как саму биржу, так и весь фондовый рынок США в целом. Сам финансовый район иногда также" +
                " называют Уолл-стрит.";
            stocks[19].Owner = 0;
            stocks[19].Buildings = 0;
            stocks[19].PictureIndex = 20;
            stocks[19].StockNumber = 20;
            stocks[19].CompPosition = 34;

            stocks[20] = new Stock();
            stocks[20].Name = "Ямато";
            stocks[20].Price = 350;
            stocks[20].Rent = 35;
            stocks[20].RentWithOneHouse = 175;
            stocks[20].RentWithTwoHouse = 500;
            stocks[20].RentWithThreeHouse = 1100;
            stocks[20].RentWithFourHouse = 1300;
            stocks[20].RentWithHotel = 1500;
            stocks[20].HousePrice = 200;
            stocks[20].MortgagePrice = 175;
            stocks[20].History = "Ямато (яп. 大和, «великая гармония, мир») — историческое государственное образование в Японии," +
                " которое возникло в районе Ямато (совр. префектура Нара) региона Кинки в III—IV веках. Существовало в течение" +
                " одноимённого периода Ямато до VIII века, пока не было переименовано в 670 году в Ниппон (яп. 日本) — «Японию»";
            stocks[20].Owner = 0;
            stocks[20].Buildings = 0;
            stocks[20].PictureIndex = 21;
            stocks[20].StockNumber = 21;
            stocks[20].CompPosition = 37;




            stocks[21] = new Stock();
            stocks[21].Name = "Минатоку";
            stocks[21].Price = 400;
            stocks[21].Rent = 50;
            stocks[21].RentWithOneHouse = 200;
            stocks[21].RentWithTwoHouse = 600;
            stocks[21].RentWithThreeHouse = 1400;
            stocks[21].RentWithFourHouse = 1700;
            stocks[21].RentWithHotel = 2000;
            stocks[21].HousePrice = 200;
            stocks[21].MortgagePrice = 200;
            stocks[21].History = "Минато (яп. 港区 Минато-ку) — один из двадцати трёх специальных районов Токио. По состоянию" +
                " на 1 марта 2008 года, в районе проживало 217 тыс. 335 человек при средней плотности 10 тыс. 865 чел.на км²." +
                " Общая площадь района составляет 20,34 км². На территории района Минато расположено 49 посольств и представительств" +
                " зарубежных государств.Именно в этом специальном районе находятся посольства Российской Федерации" +
                " и Республики Казахстан(район Адзабудай), посольство США(район Акасака) и др., Торговое представительство" +
                " Российской Федерации в Японии(район Таканава).Также в Минато располагается токийский квартал гейш Акасака.";
            stocks[21].Owner = 0;
            stocks[21].Buildings = 0;
            stocks[21].PictureIndex = 22;
            stocks[21].StockNumber = 22;
            stocks[21].CompPosition = 39;
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("Stocks.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, stocks);
            }
        }

    }






    
}
