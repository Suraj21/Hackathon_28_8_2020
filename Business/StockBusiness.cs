using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonStockPriceWebApi.Model;

namespace HackathonStockPriceWebApi
{
    public class StockBusiness : IStockBusiness
    {
        IRandomNo _randomNo;
        public StockBusiness(IRandomNo randomNo)
        {
            _randomNo = randomNo;
        }
        public List<Stock> GetStockDetails()
        {
            List<Prices> DateWisePrice = new List<Prices>();

            DateTime dateTime = new DateTime(2020, 8, 1);
            for (int i = 0; i < 30; i++)
            {
                var prices = new Prices { Date = dateTime, Price = _randomNo.GetRandomNo() };
                DateWisePrice.Add(prices);
                dateTime.AddDays(1);
            }

            List<Stock> Stocks = new List<Stock>
            {
                 new Stock{ CompanyName = "HoneyWell", DateWisePrices = DateWisePrice , Date = "July-2020"}
            };

            return Stocks;
        }

        public List<StockInfo> GetStockInfo()
        {
            List<StockInfo> stockInfos = new List<StockInfo>()
            {
                 new StockInfo
                 {
                     CompanyName = "HoneyWell",
                     Date = "July-2020",
                     Recommandation ="Buy",
                     News = new List<string> { "Honeywell pirce up by 5 %", "Honeywell bought new statup" } }
            };

            return stockInfos;
        }

        private int[] PricesList()
        {
            int[] randomPriceList = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomPriceList[i] = _randomNo.GetRandomNo();
            }

            return randomPriceList;
        }
    }
}
