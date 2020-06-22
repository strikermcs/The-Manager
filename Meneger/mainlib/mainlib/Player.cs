using System;
using System.Collections.Generic;
using System.Text;

namespace mainlib
{
    public class Player
    {
        public bool CompORUser { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Position { get; set; }
        public Stock[] Stocks = new Stock[0];
        public Company[] companies = new Company[0];
        public TVRadioComp[] tVRadioComps = new TVRadioComp[0];
        public bool MayPlayerGo { get; set; }
        public bool MoneyInStart { get; set; }  
        public bool CanMove { get; set; }
        public int HaveALawyer { get; set; }
        public int HaveAExchangeCard { get; set; }
        public bool ByExCard { get; set; }
        


        public void AddStock(Stock number)
        {
            Array.Resize(ref Stocks, Stocks.Length + 1);
            Stocks[Stocks.Length - 1] = number;
        }
        public void AddStock(Company number)
        {
            Array.Resize(ref companies, companies.Length + 1);
            companies[companies.Length - 1] = number;
        }
        public void AddStock(TVRadioComp number)
        {
            Array.Resize(ref tVRadioComps, tVRadioComps.Length + 1);
            tVRadioComps[tVRadioComps.Length - 1] = number;
        }

        public void DeleteStock(int StockNumber)
        {
            if (StockNumber < 23)
            {
                int k = 0;
                Stock[] tmpstocks = new Stock[Stocks.Length - 1]; 
                for(int i = 0; i < Stocks.Length; i++)
                {
                    if (Stocks[i].StockNumber == StockNumber) continue;
                    else
                    {
                        tmpstocks[k] = Stocks[i];
                        k++;
                    }
                }
                Stocks = tmpstocks;
            }else if(StockNumber>=23 && StockNumber <= 26)
            {
                int k = 0;
                Company[] tmpstocks = new Company[companies.Length - 1];
                for (int i = 0; i < companies.Length; i++)
                {
                    if (companies[i].StockNumber == StockNumber) continue;
                    else
                    {
                        tmpstocks[k] = companies[i];
                        k++;
                    }
                }
                companies = tmpstocks;
            }
            else
            {
                int k = 0;
                TVRadioComp[] tmpstocks = new TVRadioComp[tVRadioComps.Length - 1];
                for (int i = 0; i < tVRadioComps.Length; i++)
                {
                    if (tVRadioComps[i].StockNumber == StockNumber) continue;
                    else
                    {
                        tmpstocks[k] = tVRadioComps[i];
                        k++;
                    }
                }
                tVRadioComps = tmpstocks;
            }
        }

        
    }
}
