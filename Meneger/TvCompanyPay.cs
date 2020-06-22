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
    public partial class TvCompanyPay : Form
    {
        bool tmp;
        int kosti;
        int renta;
        Player[] player;
        int indexOw;
        public TvCompanyPay(Player[]  players, bool Comp, int indexOwner)
        {
            InitializeComponent();
            player = players;
            tmp = Comp;
            indexOw = indexOwner;
            if (Comp)
            {
                Box1.Text = "Приватная собственность!!! Владелец владеет обоеми теле и радио компаниями. В этом случаи вы должны " +
                    "уплатить ренту в 10 - ти кратном размере от выпавшей суммы на костях. Пожалуйста бросте кости!!   ";
            }
            else
            {
                Box1.Text = "Приватная собственность!!! Владелец владеет одной теле или радио компанией. В этом случаи вы должны " +
                    "уплатить ренту в 4  - рех кратном размере от выпавшей суммы на костях. Пожалуйста бросте кости!!   ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            kosti = rnd.Next(2, 13);
            renta = TVRadioComp.GetRenta(tmp, kosti);
            if (data.TVCompServise == true) renta *= 2;  
            button1.Text = kosti.ToString();
            MessageBox.Show(player[data.ActivePlayer].Name + "! Вам необходимо заплатить ренту игроку " + player[indexOw].Name + " в " +
                "размере " + renta + " АС");
            player[indexOw].Money += renta;
            player[data.ActivePlayer].Money -= renta;
            Close();

        }

        private void TvCompanyPay_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
