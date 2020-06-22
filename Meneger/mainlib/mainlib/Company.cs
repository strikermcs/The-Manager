using System;
using System.Collections.Generic;
using System.Text;

namespace mainlib
{
    public class Company
    {
        public string Name { get; set; }

        public ushort Price { get; set; } 
        public ushort Renta { get; set; } 
        public ushort RentaTwo { get; set; } 
        public ushort RentaThree { get; set; } 
        public ushort RentaFour { get; set; } 
        public ushort MortgagePrice { get; set; } 
        public int ImageIndex { get; set; }
        public byte Owner { get; set; }
        public int StockNumber { get; set; }
        public byte CompPosition { get; set; }

        public Company()
        {
            Price = 200;
            Renta = 25;
            RentaTwo = 50;
            RentaThree = 100;
            RentaFour = 200;
            MortgagePrice = 100;

        }
        public int GetRenta(int CompanyNumbers)
        {
            switch (CompanyNumbers)
            {
                case 1:
                    return Renta;
                   
                case 2:
                    return RentaTwo;
                    
                case 3:
                    return RentaThree;
                    
                case 4:
                    return RentaFour;
                default: return 0;
            }
        }
    }
}
