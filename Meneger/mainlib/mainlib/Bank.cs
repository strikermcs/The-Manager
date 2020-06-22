using System;
using System.Collections.Generic;
using System.Text;

namespace mainlib
{
    public class Bank
    {
        public Stock[] stocks = new Stock[0];
        public Company[] companies = new Company[0];
        public TVRadioComp[] vRadioComps = new TVRadioComp[0];
        public bool CreditTake { get; set; }
        public int CreditRepay { get; set; }
        public int CreditPayForCircle { get; set; } 
        public int CircleOst { get; set; }

        public void AddStock(Stock number)
        {
            Array.Resize(ref stocks, stocks.Length + 1);
            stocks[stocks.Length - 1] = number;
        }
        public void AddStock(Company number)
        {
            Array.Resize(ref companies, companies.Length + 1);
            companies[companies.Length - 1] = number;
        }
        public void AddStock(TVRadioComp number)
        {
            Array.Resize(ref vRadioComps, vRadioComps.Length + 1);
            vRadioComps[vRadioComps.Length - 1] = number;
        }

        public void DeleteStock(int StockNumber)
        {
            if (StockNumber < 23)
            {
                int k = 0;
                Stock[] tmpstocks = new Stock[stocks.Length - 1];
                for (int i = 0; i < stocks.Length; i++)
                {
                    if (stocks[i].StockNumber == StockNumber) continue;
                    else
                    {
                        tmpstocks[k] = stocks[i];
                        k++;
                    }
                }
                stocks = tmpstocks;
            }
            else if (StockNumber >= 23 && StockNumber <= 26)
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
                TVRadioComp[] tmpstocks = new TVRadioComp[vRadioComps.Length - 1];
                for (int i = 0; i < vRadioComps.Length; i++)
                {
                    if (vRadioComps[i].StockNumber == StockNumber) continue;
                    else
                    {
                        tmpstocks[k] = vRadioComps[i];
                        k++;
                    }
                }
                vRadioComps = tmpstocks;
            }
        }

    }
}
