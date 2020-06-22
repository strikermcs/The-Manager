using System;
using System.Collections.Generic;
using System.Text;

namespace mainlib
{
    public class TVRadioComp
    {
        public string Name { get; set; }
        public ushort Price { get; set; } 
        public ushort MortgagePrice { get; set; }
        public int ImageIndex { get; set; }
        public byte Owner { get; set; }
        public int StockNumber { get; set; }

        public TVRadioComp()
        {
            Price = 150;
            MortgagePrice = 75;
        }
    

        public static int GetRenta(bool Companies,int kosti)
        {
            if (Companies) return kosti * 10;
            else return kosti * 4;
        }
    }
}
