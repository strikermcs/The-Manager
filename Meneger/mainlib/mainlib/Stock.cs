using System;

namespace mainlib
{
    [Serializable]
    public class Stock
    {
        public  string Name { get; set; }
        public  ushort Price { get; set; }
        public  ushort Rent { get; set; }
        public ushort RentWithOneHouse { get; set; }
        public  ushort RentWithTwoHouse { get; set; }
        public  ushort RentWithThreeHouse { get; set; }
        public  ushort RentWithFourHouse { get; set; }
        public  ushort RentWithHotel { get; set; }
        public  ushort MortgagePrice { get; set; }
        public  ushort HousePrice { get; set; }
       public  string History { get; set; }
        public byte Owner { get; set; }
        public byte Buildings { get; set; }
        public int StockNumber { get; set; }
        public byte PictureIndex { get; set; } 
        public byte CompPosition { get; set; }

    }
}
