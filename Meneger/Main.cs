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
using System.Media;

namespace Meneger
{
    public partial class Main : Form
    {

        
        Stock[]  stocks;
        Player[] players;
        Position PlPosition = new Position();
        Company[] companies = new Company[4];
        TVRadioComp[] tVRadioComps = new TVRadioComp[2];
        Bank[] banks = new Bank[3];
        LogForm LogForm = new LogForm();

        string   tmpstring;
        byte     tmpForce = 3;
        
        // Класс отвечающий за озвучку
        public  class SoundP
        {
            SoundPlayer SoundPl = new SoundPlayer();
            public  void Open(string nameOfSong)
            {
                switch (nameOfSong)
                {
                    case "open":
                        SoundPl.Stream = Soundres.open;
                        break;
                    case "newstart":
                        SoundPl.Stream = Soundres.newstart;
                        break;
                    case "go":
                        SoundPl.Stream = Soundres.go;
                        break;
                    case "forcemag":
                        SoundPl.Stream = Soundres.forcemag;
                        break;
                    case "newgo":
                        SoundPl.Stream = Soundres.newgo;
                        break;
                    case "kosti":
                        SoundPl.Stream = Soundres.kosti;
                        break;
                    case "office":
                        SoundPl.Stream = Soundres.office;
                        break;

                }
               
                SoundPl.Play();
            }
        }

        SoundP soundP = new SoundP();

        public Main(Player[] player)
        {
            players = player;
          
            InitializeComponent();
            data.IsPlayerGo = false;
            data.ActivePlayer = 0;
            data.TVCompServise = false;
            FirstVladLabel.Text = player[0].Name;
            SecondVladLabel.Text = player[1].Name;
            FirdVladLabel.Text = player[2].Name;
            data.MayComputerGo = 0;

            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("Stocks.dat", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                stocks = (Stock[])binFormat.Deserialize(fStream);
            }

            for(int i = 0; i < 4; i++)
            {
                companies[i] = new Company();

            }
            companies[0].Name = "Торговый флот";
            companies[0].ImageIndex = 23;
            companies[0].StockNumber = 23;

            companies[1].Name = "Железно - дорожняя компания";
            companies[1].ImageIndex = 24;
            companies[1].StockNumber = 24;

            companies[2].Name = "Автомобильная компания";
            companies[2].ImageIndex = 25;
            companies[2].StockNumber = 25;

            companies[3].Name = "Авиа компания";
            companies[3].ImageIndex = 26;
            companies[3].StockNumber = 26;

            tVRadioComps[0] = new TVRadioComp();
            tVRadioComps[0].Name = "Рекламная компания";
            tVRadioComps[0].ImageIndex = 28;
            tVRadioComps[0].StockNumber = 27;

            tVRadioComps[1] = new TVRadioComp();
            tVRadioComps[1].Name = "Теле компания";
            tVRadioComps[1].ImageIndex = 27;
            tVRadioComps[1].StockNumber = 28;

            soundP.Open("newgo");
            GoInfo goInfo = new GoInfo(players[data.ActivePlayer]);
            goInfo.ShowDialog();

            for(int i = 0; i < 3; i++)
            {
                players[i].CanMove = true;
                players[i].HaveAExchangeCard = 0;
                players[i].HaveALawyer = 0;
                banks[i] = new Bank();
                banks[i].CreditTake = false;
                banks[i].CreditRepay = 0;
            }

            data.PlayerIsDo = false;
            

        }

       

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start Start = new Start();
            Start.Show();
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            
            data.PlayerNum = 0;
            data.startpositionpl1 = 0;
            data.startpositionpl2 = 0;
            data.startpositionpl3 = 0;
            
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Pl1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Pl1, players[0].Name);
        }

        private void Pl2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Pl2, players[1].Name);
        }

        private void Pl3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Pl3, players[2].Name);
        }

        private void brosok_Click(object sender, EventArgs e)
        {
            BrosokCl();
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayerNamelabel.Text = players[data.ActivePlayer].Name;
            PlayerMoneylabel.Text = players[data.ActivePlayer].Money.ToString()+" АС";

            /////////////////////////////////////////////////////////////
            switch (stocks[0].Owner)
            {
                case 0:
                    panel1.BackColor = Color.White;
                    break;
                case 1:
                    panel1.BackColor = Color.Red;
                    break;
                case 2:
                    panel1.BackColor = Color.Blue;
                    break;
                case 3:
                    panel1.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel1.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[1].Owner)
            {
                case 0:
                    panel2.BackColor = Color.White;
                    break;
                case 1:
                    panel2.BackColor = Color.Red;
                    break;
                case 2:
                    panel2.BackColor = Color.Blue;
                    break;
                case 3:
                    panel2.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel2.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[2].Owner)
            {
                case 0:
                    panel4.BackColor = Color.White;
                    break;
                case 1:
                    panel4.BackColor = Color.Red;
                    break;
                case 2:
                    panel4.BackColor = Color.Blue;
                    break;
                case 3:
                    panel4.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel4.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[3].Owner)
            {
                case 0:
                    panel5.BackColor = Color.White;
                    break;
                case 1:
                    panel5.BackColor = Color.Red;
                    break;
                case 2:
                    panel5.BackColor = Color.Blue;
                    break;
                case 3:
                    panel5.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel5.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[4].Owner)
            {
                case 0:
                    panel6.BackColor = Color.White;
                    break;
                case 1:
                    panel6.BackColor = Color.Red;
                    break;
                case 2:
                    panel6.BackColor = Color.Blue;
                    break;
                case 3:
                    panel6.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel6.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[5].Owner)
            {
                case 0:
                    panel7.BackColor = Color.White;
                    break;
                case 1:
                    panel7.BackColor = Color.Red;
                    break;
                case 2:
                    panel7.BackColor = Color.Blue;
                    break;
                case 3:
                    panel7.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel7.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[6].Owner)
            {
                case 0:
                    panel8.BackColor = Color.White;
                    break;
                case 1:
                    panel8.BackColor = Color.Red;
                    break;
                case 2:
                    panel8.BackColor = Color.Blue;
                    break;
                case 3:
                    panel8.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel8.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            
                switch (stocks[7].Owner)
            {
                case 0:
                    panel9.BackColor = Color.White;
                    break;
                case 1:
                    panel9.BackColor = Color.Red;
                    break;
                case 2:
                    panel9.BackColor = Color.Blue;
                    break;
                case 3:
                    panel9.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel9.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[8].Owner)
            {
                case 0:
                    panel10.BackColor = Color.White;
                    break;
                case 1:
                    panel10.BackColor = Color.Red;
                    break;
                case 2:
                    panel10.BackColor = Color.Blue;
                    break;
                case 3:
                    panel10.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel10.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[9].Owner)
            {
                case 0:
                    panel11.BackColor = Color.White;
                    break;
                case 1:
                    panel11.BackColor = Color.Red;
                    break;
                case 2:
                    panel11.BackColor = Color.Blue;
                    break;
                case 3:
                    panel11.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel11.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[10].Owner)
            {
                case 0:
                    panel12.BackColor = Color.White;
                    break;
                case 1:
                    panel12.BackColor = Color.Red;
                    break;
                case 2:
                    panel12.BackColor = Color.Blue;
                    break;
                case 3:
                    panel12.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel12.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[11].Owner)
            {
                case 0:
                    panel13.BackColor = Color.White;
                    break;
                case 1:
                    panel13.BackColor = Color.Red;
                    break;
                case 2:
                    panel13.BackColor = Color.Blue;
                    break;
                case 3:
                    panel13.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel13.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[12].Owner)
            {
                case 0:
                    panel14.BackColor = Color.White;
                    break;
                case 1:
                    panel14.BackColor = Color.Red;
                    break;
                case 2:
                    panel14.BackColor = Color.Blue;
                    break;
                case 3:
                    panel14.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel14.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[13].Owner)
            {
                case 0:
                    panel15.BackColor = Color.White;
                    break;
                case 1:
                    panel15.BackColor = Color.Red;
                    break;
                case 2:
                    panel15.BackColor = Color.Blue;
                    break;
                case 3:
                    panel15.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel15.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[14].Owner)
            {
                case 0:
                    panel16.BackColor = Color.White;
                    break;
                case 1:
                    panel16.BackColor = Color.Red;
                    break;
                case 2:
                    panel16.BackColor = Color.Blue;
                    break;
                case 3:
                    panel16.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel16.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[15].Owner)
            {
                case 0:
                    panel17.BackColor = Color.White;
                    break;
                case 1:
                    panel17.BackColor = Color.Red;
                    break;
                case 2:
                    panel17.BackColor = Color.Blue;
                    break;
                case 3:
                    panel17.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel17.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[16].Owner)
            {
                case 0:
                    panel18.BackColor = Color.White;
                    break;
                case 1:
                    panel18.BackColor = Color.Red;
                    break;
                case 2:
                    panel18.BackColor = Color.Blue;
                    break;
                case 3:
                    panel18.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel18.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[17].Owner)
            {
                case 0:
                    panel19.BackColor = Color.White;
                    break;
                case 1:
                    panel19.BackColor = Color.Red;
                    break;
                case 2:
                    panel19.BackColor = Color.Blue;
                    break;
                case 3:
                    panel19.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel19.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[18].Owner)
            {
                case 0:
                    panel20.BackColor = Color.White;
                    break;
                case 1:
                    panel20.BackColor = Color.Red;
                    break;
                case 2:
                    panel20.BackColor = Color.Blue;
                    break;
                case 3:
                    panel20.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel20.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[19].Owner)
            {
                case 0:
                    panel21.BackColor = Color.White;
                    break;
                case 1:
                    panel21.BackColor = Color.Red;
                    break;
                case 2:
                    panel21.BackColor = Color.Blue;
                    break;
                case 3:
                    panel21.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel21.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[20].Owner)
            {
                case 0:
                    panel23.BackColor = Color.White;
                    break;
                case 1:
                    panel23.BackColor = Color.Red;
                    break;
                case 2:
                    panel23.BackColor = Color.Blue;
                    break;
                case 3:
                    panel23.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel23.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (stocks[21].Owner)
            {
                case 0:
                    panel24.BackColor = Color.White;
                    break;
                case 1:
                    panel24.BackColor = Color.Red;
                    break;
                case 2:
                    panel24.BackColor = Color.Blue;
                    break;
                case 3:
                    panel24.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel24.BackColor = Color.Pink;
                    break;

            }

            //--------------------------------------------------------------
            switch (companies[0].Owner)
            {
                case 0:
                    panel3.BackColor = Color.White;
                    break;
                case 1:
                    panel3.BackColor = Color.Red;
                    break;
                case 2:
                    panel3.BackColor = Color.Blue;
                    break;
                case 3:
                    panel3.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel3.BackColor = Color.Pink;
                    break;

            }
            //--------------------------------------------------------------
            switch (companies[1].Owner)
            {
                case 0:
                    panel27.BackColor = Color.White;
                    break;
                case 1:
                    panel27.BackColor = Color.Red;
                    break;
                case 2:
                    panel27.BackColor = Color.Blue;
                    break;
                case 3:
                    panel27.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel27.BackColor = Color.Pink;
                    break;

            }
            //--------------------------------------------------------------
            switch (companies[2].Owner)
            {
                case 0:
                    panel26.BackColor = Color.White;
                    break;
                case 1:
                    panel26.BackColor = Color.Red;
                    break;
                case 2:
                    panel26.BackColor = Color.Blue;
                    break;
                case 3:
                    panel26.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel26.BackColor = Color.Pink;
                    break;

            }
            //--------------------------------------------------------------
            switch (companies[3].Owner)
            {
                case 0:
                    panel22.BackColor = Color.White;
                    break;
                case 1:
                    panel22.BackColor = Color.Red;
                    break;
                case 2:
                    panel22.BackColor = Color.Blue;
                    break;
                case 3:
                    panel22.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel22.BackColor = Color.Pink;
                    break;

            }


            //--------------------------------------------------------------
            switch (tVRadioComps[0].Owner)
            {
                case 0:
                    panel28.BackColor = Color.White;
                    break;
                case 1:
                    panel28.BackColor = Color.Red;
                    break;
                case 2:
                    panel28.BackColor = Color.Blue;
                    break;
                case 3:
                    panel28.BackColor = Color.Fuchsia;
                    break;
                case 4:
                    panel28.BackColor = Color.Pink;
                    break;

            }


            //-------------------------------------------------------------- 
            switch (tVRadioComps[1].Owner)
            {
                case 0:
                    panel25.BackColor = Color.White;
                break;
                case 1:
                    panel25.BackColor = Color.Red;
                break;
                case 2:
                    panel25.BackColor = Color.Blue;
                break;
                case 3:
                    panel25.BackColor = Color.Fuchsia;
                break;
                case 4:
                    panel25.BackColor = Color.Pink;
                break;

            }

           

            //--------------------------------------------------------------

            //////////////////////////////////////////////////////////////
        }



        private void GranViaBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[0].Owner == 0) tmpstring = "Владельца нет";
            else tmpstring = players[stocks[0].Owner - 1].Name;
            
            toolTip1.SetToolTip(GranViaBut, $"{stocks[0].Name}  , Владелец: "+ tmpstring); 
        }



        private void GranViaBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[0],players, stocks, LogForm);
            
        }

        private void PlasaMajorBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[1], players, stocks, LogForm);
            
        }

        private void JawaiBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[2], players, stocks, LogForm);
            
        }

        private void TaitiBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[3],players, stocks, LogForm);
            
        }

        private void FidjiBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[4], players, stocks, LogForm);
           
        }

        private void DelPoloBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[5], players, stocks, LogForm);
           
        }

        private void SanAnjeloBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[6], players, stocks, LogForm);
            
        }

        private void PiatVenetBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[7], players, stocks, LogForm);
            
        }

        private void TrafalgarBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[8], players, stocks, LogForm);
            
        }

        private void WaitHollBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[9], players, stocks, LogForm);
            
        }

        private void OksvordBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[10], players, stocks, LogForm);
           
        }

        private void PiatnitskaBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[11], players, stocks, LogForm);
            
        }

        private void OhotaBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[12], players, stocks, LogForm);
            
        }

        private void TverskaBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[13], players, stocks, LogForm);
            
        }

        private void MadlenBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[14], players, stocks, LogForm);
            
        }

        private void EleseikieBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[15],players, stocks, LogForm);
            
        }

        private void SenDeniBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[16], players, stocks, LogForm);
            
        }

        private void BraitonBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[17], players, stocks, LogForm);
            
        }

        private void AvenuBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[18], players, stocks, LogForm);
            
        }

        private void WallstreetBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[19], players, stocks, LogForm);
            
        }

        private void JamatoBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[20], players, stocks, LogForm);
            
        }

        private void MinatokyBut_Click(object sender, EventArgs e)
        {
            soundP.Open("open");
            Locationmy locationmy = new Locationmy(stocks[21], players, stocks, LogForm);
            
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Start start = new Start();
                start.Show();
            LogForm.Close();
            Close();
        }

        // Сообщения Hint на кнопках полей акций

        private void PlasaMajorBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[1].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[1].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[1].Owner - 1].Name;

            toolTip1.SetToolTip(PlasaMajorBut, $"{stocks[1].Name}  , Владелец: " + tmpstring);
        }

        private void JawaiBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[2].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[2].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[2].Owner - 1].Name;

            toolTip1.SetToolTip(JawaiBut, $"{stocks[2].Name}  , Владелец: " + tmpstring);
        }

        private void TaitiBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[3].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[3].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[3].Owner - 1].Name;

            toolTip1.SetToolTip(TaitiBut, $"{stocks[3].Name}  , Владелец: " + tmpstring);
        }

        private void FidjiBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[4].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[4].Owner == 4) tmpstring = "Банк";
                    else tmpstring = players[stocks[4].Owner - 1].Name;

            toolTip1.SetToolTip(FidjiBut, $"{stocks[4].Name}  , Владелец: " + tmpstring);
        }

        private void DelPoloBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[5].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[5].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[5].Owner - 1].Name;

            toolTip1.SetToolTip(DelPoloBut, $"{stocks[5].Name}  , Владелец: " + tmpstring);
        }

        private void SanAnjeloBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[6].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[6].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[6].Owner - 1].Name;

            toolTip1.SetToolTip(SanAnjeloBut, $"{stocks[6].Name}  , Владелец: " + tmpstring);
        }

        private void PiatVenetBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[7].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[7].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[7].Owner - 1].Name;

            toolTip1.SetToolTip(PiatVenetBut, $"{stocks[7].Name}  , Владелец: " + tmpstring);
        }

        private void TrafalgarBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[8].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[8].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[8].Owner - 1].Name;

            toolTip1.SetToolTip(TrafalgarBut, $"{stocks[8].Name}  , Владелец: " + tmpstring);
        }

        private void WaitHollBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[9].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[9].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[9].Owner - 1].Name;
            toolTip1.SetToolTip(WaitHollBut, $"{stocks[9].Name}  , Владелец: " + tmpstring);
        }

        private void OksvordBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[10].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[10].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[10].Owner - 1].Name;

            toolTip1.SetToolTip(OksvordBut, $"{stocks[10].Name}  , Владелец: " + tmpstring);
        }

        private void PiatnitskaBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[11].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[11].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[11].Owner - 1].Name;

            toolTip1.SetToolTip(PiatnitskaBut, $"{stocks[11].Name}  , Владелец: " + tmpstring);
        }

        private void OhotaBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[12].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[12].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[12].Owner - 1].Name;

            toolTip1.SetToolTip(OhotaBut, $"{stocks[12].Name}  , Владелец: " + tmpstring);
        }

        private void TverskaBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[13].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[13].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[13].Owner - 1].Name;

            toolTip1.SetToolTip(TverskaBut, $"{stocks[13].Name}  , Владелец: " + tmpstring);
        }

        private void MadlenBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[14].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[14].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[14].Owner - 1].Name;

            toolTip1.SetToolTip(MadlenBut, $"{stocks[14].Name}  , Владелец: " + tmpstring);
        }

        private void EleseikieBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[15].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[15].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[15].Owner - 1].Name;

            toolTip1.SetToolTip(EleseikieBut, $"{stocks[15].Name}  , Владелец: " + tmpstring);
        }

        private void SenDeniBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[16].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[16].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[16].Owner - 1].Name;

            toolTip1.SetToolTip(SenDeniBut, $"{stocks[16].Name}  , Владелец: " + tmpstring);
        }

        private void BraitonBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[17].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[17].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[17].Owner - 1].Name;

            toolTip1.SetToolTip(BraitonBut, $"{stocks[17].Name}  , Владелец: " + tmpstring);
        }

        private void AvenuBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[18].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[18].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[18].Owner - 1].Name;

            toolTip1.SetToolTip(AvenuBut, $"{stocks[18].Name}  , Владелец: " + tmpstring);
        }

        private void WallstreetBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[19].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[19].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[19].Owner - 1].Name;

            toolTip1.SetToolTip(WallstreetBut, $"{stocks[19].Name}  , Владелец: " + tmpstring);
        }

        private void JamatoBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[20].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[20].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[20].Owner - 1].Name;

            toolTip1.SetToolTip(JamatoBut, $"{stocks[20].Name}  , Владелец: " + tmpstring);
        }

        private void MinatokyBut_MouseMove(object sender, MouseEventArgs e)
        {
            if (stocks[21].Owner == 0) tmpstring = "Владельца нет";
            else if (stocks[21].Owner == 4) tmpstring = "Банк";
            else tmpstring = players[stocks[21].Owner - 1].Name;

            toolTip1.SetToolTip(MinatokyBut, $"{stocks[21].Name}  , Владелец: " + tmpstring);
        }

        // Кнопка (фунция) ходить
        private void Go_Click(object sender, EventArgs e)
        {
            GoFunCl();
        }

        private void EndGo_Click(object sender, EventArgs e)
        {
            EndGoFunc();


        }

       

        private void brosok_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(brosok, "Бросить кости");
        }

        private void Go_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Go, "Ходить");
        }

        private void EndGo_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(EndGo, "Завершить ход");
        }

        private void bagButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(bagButton, "Портфель");
        }

        private void DealButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(DealButton, "Сделки");
        }

        private void BankButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(BankButton, "Банк");
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            DealForm dealForm = new DealForm(stocks, companies, tVRadioComps, players,LogForm);
            dealForm.ShowDialog();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Information information = new Information(stocks, companies, tVRadioComps,players);
            information.ShowDialog();
        }

        private void bagButton_Click(object sender, EventArgs e)
        {
            briefcase briefcase = new briefcase(stocks, companies, tVRadioComps, players,banks);
            briefcase.ShowDialog();
        }

        private void BankButton_Click(object sender, EventArgs e)
        {
            Banks MyBank = new Banks(stocks, companies, tVRadioComps, players, banks);
            MyBank.ShowDialog();
        }

        private void RoadButton_Click(object sender, EventArgs e)
        {
          
        }
      
        
        //------------------------------------------------------------------------------------------------------------
        public void BrosokCl()
        {
            Random rnd = new Random();
            data.playergo = rnd.Next(2, 13);
            soundP.Open("kosti");
            brosok.Enabled = false;
            labkos.Text = data.playergo.ToString();
            Go.Enabled = true;
        }

        //--------------------------------------------------------------------------------------------------------------
        public void GoFunCl()
        {

            for (int i = 0; i < data.playergo; i++)
            {
                players[data.ActivePlayer].Position++;

                //Переход через СТАРТ

                if (players[data.ActivePlayer].Position >= 40)
                {


                    players[data.ActivePlayer].Position -= 40;
                    players[data.ActivePlayer].Money += 200;
                    LogForm.AddLog(players[data.ActivePlayer], "Перешел через СТАРТ");
                    soundP.Open("newstart");
                    MessageBox.Show(players[data.ActivePlayer].Name + "!!! Вы перешли через СТАРТ и получаете 200 АС", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Уплата по кредиту. если он есть

                    if (banks[data.ActivePlayer].CreditTake)
                    {
                        players[data.ActivePlayer].Money -= banks[data.ActivePlayer].CreditPayForCircle;
                        banks[data.ActivePlayer].CreditRepay -= banks[data.ActivePlayer].CreditPayForCircle;
                        banks[data.ActivePlayer].CircleOst--;

                        if (banks[data.ActivePlayer].CreditRepay == 0)
                        {
                            banks[data.ActivePlayer].CreditTake = false;
                            MessageBox.Show(players[data.ActivePlayer].Name + "!!!  Уплата по кредиту: " +
                                banks[data.ActivePlayer].CreditPayForCircle.ToString() + " \n+" +
                                "Поздравляем вы погасили кредит!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(players[data.ActivePlayer].Name + "!!!  Уплата по кредиту: " +
                               banks[data.ActivePlayer].CreditPayForCircle.ToString(), "Information", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                        }
                    }

                    //Форс - мажор
                    if (tmpForce == 3)
                    {
                        Force force = new Force(ref players, ref stocks, ref companies, ref tVRadioComps,LogForm);

                        soundP.Open("forcemag");
                        force.ShowDialog();

                    }
                    tmpForce--;
                    if (tmpForce <= 0) tmpForce = 3;

                }

                //Выбираем игрока кто сейчас будет ходить


                switch (data.ActivePlayer)
                {
                    case 0:
                        Pl1.Location = new Point(PlPosition.GetPlayerCoordinateX(0, players[0].Position),
                                                    PlPosition.GetPlayerCoordinateY(0, players[0].Position));
                        break;
                    case 1:
                        Pl2.Location = new Point(PlPosition.GetPlayerCoordinateX(1, players[1].Position),
                                                    PlPosition.GetPlayerCoordinateY(1, players[1].Position));
                        break;
                    case 2:
                        Pl3.Location = new Point(PlPosition.GetPlayerCoordinateX(2, players[2].Position),
                                                    PlPosition.GetPlayerCoordinateY(2, players[2].Position));
                        break;
                }
                soundP.Open("go");
                System.Threading.Thread.Sleep(310);
            }

            switch (players[data.ActivePlayer].Position)
            {
                case 1:
                    soundP.Open("open");
                    Locationmy locationmy = new Locationmy(stocks[0], players, stocks, LogForm);
                   

                    break;
                case 2:
                    soundP.Open("office");
                    office offic = new office(stocks, players,LogForm);
                    if(players[data.ActivePlayer].CompORUser) offic.ShowDialog();
                    if (data.ReMove == true)
                    {
                        data.ReMove = false;
                        data.playergo = 40 - players[data.ActivePlayer].Position;
                        GoFunCl();
                    }
                    break;
                case 3:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[1], players, stocks, LogForm);
                   
                    break;
                case 4:
                    if (players[data.ActivePlayer].CompORUser)
                    {
                        DialogResult = MessageBox.Show("Подоходный налог!!! Если хотите уплатить 200 АС, нажмите ОК. Если хотите" +
                        " уплатить 10% от своих денег нажмите отмена.", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (DialogResult == DialogResult.OK)
                        {
                            players[data.ActivePlayer].Money -= 200;
                            LogForm.AddLog(players[data.ActivePlayer], "Платит подоходный налог 200 АС");
                        }
                        else
                        {
                            int rezult;
                            rezult = players[data.ActivePlayer].Money / 100 * 10;
                            players[data.ActivePlayer].Money -= rezult;
                            LogForm.AddLog(players[data.ActivePlayer], "Платит подоходный налог "+rezult+" АС");
                        }
                    }
                    else
                    {
                        int rezult;
                        rezult = players[data.ActivePlayer].Money / 100 * 10;
                        players[data.ActivePlayer].Money -= rezult;
                        LogForm.AddLog(players[data.ActivePlayer], "Платит подоходный налог " + rezult + " АС");
                    } 
                    break;
                case 5:
                    soundP.Open("open");
                    CompaniesForm companiesForm = new CompaniesForm(companies[0], players, companies, LogForm);
                   
                    break;
                case 6:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[2], players, stocks, LogForm);
                   
                    break;
                case 7:
                    soundP.Open("open");
                    Chance chance = new Chance(stocks, players,LogForm);
                    if (players[data.ActivePlayer].CompORUser) chance.ShowDialog();
                    if (data.MoveTo == true)
                    {
                        data.MoveTo = false;
                        switch (data.ActivePlayer)
                        {
                            case 0:
                                Pl1.Location = new Point(PlPosition.GetPlayerCoordinateX(0, players[0].Position),
                                                            PlPosition.GetPlayerCoordinateY(0, players[0].Position));
                                break;
                            case 1:
                                Pl2.Location = new Point(PlPosition.GetPlayerCoordinateX(1, players[1].Position),
                                                            PlPosition.GetPlayerCoordinateY(1, players[1].Position));
                                break;
                            case 2:
                                Pl3.Location = new Point(PlPosition.GetPlayerCoordinateX(2, players[2].Position),
                                                            PlPosition.GetPlayerCoordinateY(2, players[2].Position));
                                break;
                        }

                    }
                    break;
                case 8:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[3], players, stocks, LogForm);
                    

                    break;
                case 9:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[4], players, stocks, LogForm);
                    
                    break;
                case 10:
                    //Интерпол задержка
                    if (players[data.ActivePlayer].CompORUser)
                    {
                        if (players[data.ActivePlayer].HaveALawyer > 0)
                        {
                            MessageBox.Show("У вас хороший адвокат!!! Вопросы с интерполом решины", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogForm.AddLog(players[data.ActivePlayer],"Адвокат", "У тебя нет конфликтов с интерполом");
                        }
                        else
                        {
                            MessageBox.Show(players[data.ActivePlayer].Name + "! Вы задержаны интерполом. Извините но вы пропускаете один ход" +
                            "!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            players[data.ActivePlayer].CanMove = false;
                            LogForm.AddLog(players[data.ActivePlayer], "Задержан интерполом");
                        }
                    }
                    else
                    {
                        if (players[data.ActivePlayer].HaveALawyer > 0)
                        {
                            LogForm.AddLog(players[data.ActivePlayer], "Адвокат", "У тебя нет конфликтов с интерполом");

                        }
                        else
                        {
                            players[data.ActivePlayer].CanMove = false;
                            LogForm.AddLog(players[data.ActivePlayer], "Задержан интерполом");
                        }
                    }
                    break;
                case 11:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[5], players, stocks, LogForm);
                    
                    break;
                case 12:
                    soundP.Open("open");
                    TvCompForm tvCompF = new TvCompForm(tVRadioComps[0], players, tVRadioComps, 0,LogForm);
                    

                    break;
                case 13:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[6], players, stocks, LogForm);
                   
                    break;
                case 14:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[7], players, stocks, LogForm);
                    
                    break;
                case 15:
                    soundP.Open("open");
                    companiesForm = new CompaniesForm(companies[1], players, companies,LogForm);
                   
                    break;
                case 16:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[8], players, stocks, LogForm);
                    
                    break;

                case 17:
                    soundP.Open("office");
                    offic = new office(stocks, players,LogForm);
                    if (players[data.ActivePlayer].CompORUser) offic.ShowDialog();
                    if (data.ReMove == true)
                    {
                        data.ReMove = false;
                        data.playergo = 40 - players[data.ActivePlayer].Position;
                        GoFunCl();
                    }
                    break;
                case 18:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[9], players, stocks, LogForm);
                    
                    break;
                case 19:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[10], players, stocks, LogForm);
                    
                    break;
                case 20:
                    // Биржа
                    FinExchange exchange = new FinExchange(stocks, companies, tVRadioComps, players, banks);
                    if (players[data.ActivePlayer].CompORUser) exchange.ShowDialog();
                    break;
                case 21:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[11], players, stocks, LogForm);
                    
                    break;
                case 22:
                    soundP.Open("open");
                    chance = new Chance(stocks, players,LogForm);
                    if (players[data.ActivePlayer].CompORUser) chance.ShowDialog();
                    if (data.MoveTo == true)
                    {
                        data.MoveTo = false;
                        switch (data.ActivePlayer)
                        {
                            case 0:
                                Pl1.Location = new Point(PlPosition.GetPlayerCoordinateX(0, players[0].Position),
                                                            PlPosition.GetPlayerCoordinateY(0, players[0].Position));
                                break;
                            case 1:
                                Pl2.Location = new Point(PlPosition.GetPlayerCoordinateX(1, players[1].Position),
                                                            PlPosition.GetPlayerCoordinateY(1, players[1].Position));
                                break;
                            case 2:
                                Pl3.Location = new Point(PlPosition.GetPlayerCoordinateX(2, players[2].Position),
                                                            PlPosition.GetPlayerCoordinateY(2, players[2].Position));
                                break;
                        }

                    }
                    break;
                case 23:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[12], players, stocks, LogForm);
                    
                    break;
                case 24:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[13], players, stocks, LogForm);
                   
                    break;
                case 25:
                    soundP.Open("open");
                    companiesForm = new CompaniesForm(companies[2], players, companies,LogForm);
                   
                    break;
                case 26:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[14], players, stocks, LogForm);
                   
                    break;
                case 27:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[15], players, stocks, LogForm);
                   
                    break;

                case 28:
                    soundP.Open("open");
                    tvCompF = new TvCompForm(tVRadioComps[1], players, tVRadioComps, 1,LogForm);
                    
                    break;

                case 29:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[16], players, stocks, LogForm);
                    
                    break;

                case 30:
                    if (players[data.ActivePlayer].CompORUser)
                    {
                        if (players[data.ActivePlayer].HaveALawyer > 0)
                        {
                            MessageBox.Show("У вас хороший адвокат!!! Вопросы с интерполом решины", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogForm.AddLog(players[data.ActivePlayer], "Адвокат", "У тебя нет конфликтов с интерполом");
                        }
                        else
                        {
                            MessageBox.Show(players[data.ActivePlayer].Name + "! Вы задержаны интерполом. Извините но вы пропускаете один ход" +
                            "!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            players[data.ActivePlayer].CanMove = false;
                            LogForm.AddLog(players[data.ActivePlayer], "Задержан интерполом");
                        }
                    }
                    else
                    {
                        if (players[data.ActivePlayer].HaveALawyer > 0)
                        {
                            LogForm.AddLog(players[data.ActivePlayer], "Адвокат", "У тебя нет конфликтов с интерполом");

                        }
                        else
                        {
                            players[data.ActivePlayer].CanMove = false;
                            LogForm.AddLog(players[data.ActivePlayer], "Задержан интерполом");
                        }
                    }
                    break;
                case 31:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[17], players, stocks, LogForm);
                   
                    break;

                case 32:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[18], players, stocks, LogForm);
                   
                    break;

                case 33:
                    soundP.Open("office");
                    offic = new office(stocks, players,LogForm);
                    if (players[data.ActivePlayer].CompORUser) offic.ShowDialog();
                    if (data.ReMove == true)
                    {
                        data.ReMove = false;
                        data.playergo = 40 - players[data.ActivePlayer].Position;
                        GoFunCl();
                    }
                    break;

                case 34:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[19], players, stocks, LogForm);
                    
                    break;

                case 35:
                    soundP.Open("open");
                    companiesForm = new CompaniesForm(companies[3], players, companies,LogForm);
                    
                    break;

                case 36:
                    soundP.Open("open");
                    chance = new Chance(stocks, players,LogForm);
                    if (players[data.ActivePlayer].CompORUser) chance.ShowDialog();
                    if (data.MoveTo == true)
                    {
                        data.MoveTo = false;
                        switch (data.ActivePlayer)
                        {
                            case 0:
                                Pl1.Location = new Point(PlPosition.GetPlayerCoordinateX(0, players[0].Position),
                                                            PlPosition.GetPlayerCoordinateY(0, players[0].Position));
                                break;
                            case 1:
                                Pl2.Location = new Point(PlPosition.GetPlayerCoordinateX(1, players[1].Position),
                                                            PlPosition.GetPlayerCoordinateY(1, players[1].Position));
                                break;
                            case 2:
                                Pl3.Location = new Point(PlPosition.GetPlayerCoordinateX(2, players[2].Position),
                                                            PlPosition.GetPlayerCoordinateY(2, players[2].Position));
                                break;
                        }

                    }
                    break;

                case 37:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[20], players, stocks, LogForm);
                    
                    break;

                case 38:
                    if (players[data.ActivePlayer].CompORUser)
                    {
                        MessageBox.Show("Пожертвование в благотворительный фонд. Уплатите 75 АС.", "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        players[data.ActivePlayer].Money -= 75;
                        data.BlagoFond += 75;
                        LogForm.AddLog(players[data.ActivePlayer], "Платит пожертвование в благотворительный фонд 75 АС");
                    }
                    else
                    {
                        players[data.ActivePlayer].Money -= 75;
                        data.BlagoFond += 75;
                        LogForm.AddLog(players[data.ActivePlayer], "Платит пожертвование в благотворительный фонд 75 АС");
                    }
                    break;
                case 39:
                    soundP.Open("open");
                    locationmy = new Locationmy(stocks[21], players, stocks, LogForm);
                   
                    break;

            }

            Go.Enabled = false;
            EndGo.Enabled = true;
            
        }

        //---------------------------------------------------------------------------------------------------------------------------

        public void EndGoFunc()
        {

            data.PlayerIsDo = false;
            data.ActivePlayer++;
            if (data.ActivePlayer == 3) data.ActivePlayer = 0;
            if (players[data.ActivePlayer].CanMove)
            {
                soundP.Open("newgo");


                GoInfo goInfo = new GoInfo(players[data.ActivePlayer]);
                goInfo.ShowDialog();
                brosok.Enabled = true;
                EndGo.Enabled = false;
            }
            else
            {
                MessageBox.Show(players[data.ActivePlayer].Name + "! Вы задержаны интерполом и пропускаете один ход", "" +
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                players[data.ActivePlayer].CanMove = true;

                data.ActivePlayer++;
                if (data.ActivePlayer == 3) data.ActivePlayer = 0;
                soundP.Open("newgo");


                GoInfo goInfo = new GoInfo(players[data.ActivePlayer]);
                goInfo.ShowDialog();




                brosok.Enabled = true;
                EndGo.Enabled = false;
            }
            if (players[data.ActivePlayer].CompORUser == false )
            {
                ComputerIntellMain();
                EndGoFunc();
            }

        }



        //---------------------------------------------------------------------------------------------------------

        public void ComputerIntellMain()
        {
            CheckforActionToBy();
            BrosokCl();
            GoFunCl();
        
        }
        //-------------------------------------------------------------------------------------------------------------

        bool ActiveLog;
        private void LogFormShow_Click(object sender, EventArgs e)
        {
           

            if (!ActiveLog)
            {
                LogForm.Show();
                ActiveLog = true;
            }
            else
            {
                LogForm.Hide();
                ActiveLog = false;
            }
            
        }

        private void InfoButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(InfoButton, "Общая информация");
        }

        private void LogFormShow_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(LogFormShow, "История(лог)");
        }




        //----------------------------------------------------------------------------------------------------------

        public void CheckforActionToBy()
        {
            

            if (stocks[2].Owner == data.ActivePlayer+1|| stocks[3].Owner == data.ActivePlayer + 1 || stocks[4].Owner == data.ActivePlayer + 1)
            {
                int tmp = 0;
                int index=0;
                if (stocks[2].Owner == data.ActivePlayer + 1) tmp++; else index = 2;
                if (stocks[3].Owner == data.ActivePlayer + 1) tmp++; else index = 3;
                if (stocks[4].Owner == data.ActivePlayer + 1) tmp++; else index = 4;
                if (tmp == 2) AskAboutPurchase(index);
            }
            if (stocks[5].Owner == data.ActivePlayer + 1 || stocks[6].Owner == data.ActivePlayer + 1 || stocks[7].Owner == data.ActivePlayer + 1)
            {
                int tmp = 0;
                int index=0;
                if (stocks[5].Owner == data.ActivePlayer + 1) tmp++; else index = 5;
                if (stocks[6].Owner == data.ActivePlayer + 1) tmp++; else index = 6;
                if (stocks[7].Owner == data.ActivePlayer + 1) tmp++; else index = 7;
                if (tmp == 2) AskAboutPurchase(index);
            }
           if (stocks[8].Owner == data.ActivePlayer + 1 || stocks[9].Owner == data.ActivePlayer + 1 || stocks[10].Owner == data.ActivePlayer + 1)
            {
                int tmp = 0;
                int index=0;
                if (stocks[8].Owner == data.ActivePlayer + 1) tmp++; else index = 8;
                if (stocks[9].Owner == data.ActivePlayer + 1) tmp++; else index = 9;
                if (stocks[10].Owner == data.ActivePlayer + 1) tmp++; else index = 10;
                if (tmp == 2) AskAboutPurchase(index);
            }
             if (stocks[11].Owner == data.ActivePlayer + 1 || stocks[12].Owner == data.ActivePlayer + 1 || stocks[13].Owner == data.ActivePlayer + 1)
            {
                int tmp = 0;
                int index=0;
                if (stocks[11].Owner == data.ActivePlayer + 1) tmp++; else index = 11;
                if (stocks[12].Owner == data.ActivePlayer + 1) tmp++; else index = 12;
                if (stocks[13].Owner == data.ActivePlayer + 1) tmp++; else index = 13;
                if (tmp == 2) AskAboutPurchase(index);
            }
            if (stocks[14].Owner == data.ActivePlayer + 1 || stocks[15].Owner == data.ActivePlayer + 1 || stocks[16].Owner == data.ActivePlayer + 1)
            {
                int tmp = 0;
                int index=0;
                if (stocks[14].Owner == data.ActivePlayer + 1) tmp++; else index = 14;
                if (stocks[15].Owner == data.ActivePlayer + 1) tmp++; else index = 15;
                if (stocks[16].Owner == data.ActivePlayer + 1) tmp++; else index = 16;
                if (tmp == 2) AskAboutPurchase(index);
            }
             if (stocks[17].Owner == data.ActivePlayer + 1 || stocks[18].Owner == data.ActivePlayer + 1 || stocks[19].Owner == data.ActivePlayer + 1)
            {
                int tmp = 0;
                int index = 0;
                if (stocks[17].Owner == data.ActivePlayer + 1) tmp++; else index = 17;
                if (stocks[18].Owner == data.ActivePlayer + 1) tmp++; else index = 18;
                if (stocks[19].Owner == data.ActivePlayer + 1) tmp++; else index = 19;
                if (tmp == 2) AskAboutPurchase(index);
            }
        }

       public void  AskAboutPurchase(int index)
        {
            int playr;
            if(stocks[index].Owner != 0)
            {
                switch (stocks[index].Owner)
                {
                    case 1:
                        playr = 0;
                        if (players[0].CompORUser)
                        {
                            if (players[data.ActivePlayer].Money >= stocks[index].Price + 600)
                            {
                                DialogResult result = MessageBox.Show(players[data.ActivePlayer].Name + ": " +
                                    "" + players[0].Name + "! Не хотите ли вы продать мне свою акцию " + stocks[index].Name + " за" +
                                    " " + stocks[index].Price + 400 + " АС", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    BuyUserAction(index, playr);
                                }
                            }
                        }
                        else
                        {
                            BuyCompAction(index, playr);
                        }
                        break;
                    case 2:
                        playr = 1;
                        if (players[1].CompORUser)
                        {
                            if (players[data.ActivePlayer].Money >= stocks[index].Price + 600)
                            {
                                DialogResult result = MessageBox.Show(players[data.ActivePlayer].Name + ": " +
                                    "" + players[1].Name + "! Не хотите ли вы продать мне свою акцию " + stocks[index].Name + " за" +
                                    " " + stocks[index].Price + 400 + " АС", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    BuyUserAction(index, playr);
                                }
                            }
                        }
                        else
                        {
                            BuyCompAction(index, playr);
                        }
                        break;
                    case 3:
                        playr = 2;
                        if (players[2].CompORUser)
                        {
                            if (players[data.ActivePlayer].Money >= stocks[index].Price + 600)
                            {
                                DialogResult result = MessageBox.Show(players[data.ActivePlayer].Name + ": " +
                                    "" + players[2].Name + "! Не хотите ли вы продать мне свою акцию " + stocks[index].Name + " за" +
                                    " " + stocks[index].Price + 400 + " АС", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    BuyUserAction(index, playr);
                                }
                            }
                        }
                        else
                        {
                            BuyCompAction(index, playr);
                        }
                        break;
                }
            }
        }

        public void BuyCompAction(int ind, int player)
        {
            if (players[data.ActivePlayer].Money >= stocks[ind].Price + 400)
            {
                players[player].DeleteStock(ind+1);
                stocks[ind].Owner = (byte)(data.ActivePlayer + 1);
                stocks[ind].Buildings = 0;
                players[data.ActivePlayer].Money -= stocks[ind].Price+400;
                players[data.ActivePlayer].AddStock(stocks[ind]);
                players[ind].Money += stocks[ind].Price + 400;
            }
        }


        public void BuyUserAction(int index, int playr)
        {
            players[playr].DeleteStock(index + 1);
            stocks[index].Owner = (byte)(data.ActivePlayer + 1);
            stocks[index].Buildings = 0;
            players[data.ActivePlayer].Money -= stocks[index].Price + 400;
            players[data.ActivePlayer].AddStock(stocks[index]);
            players[index].Money += stocks[index].Price + 400;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }


}
