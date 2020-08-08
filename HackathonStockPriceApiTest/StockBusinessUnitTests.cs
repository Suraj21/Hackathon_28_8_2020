using HackathonStockPriceWebApi;
using HackathonStockPriceWebApi.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace HackathonStockPriceApiTest
{
    [TestClass]
    public class UnitTest1
    {
        //IStockBusiness mockStockBusiness;
        [TestMethod]
        public void GetStockDetails_check_whether_stock_details_are_present_or_not()
        {
            var mockStockBusiness = new Mock<IStockBusiness>();
            mockStockBusiness.Setup(x => x.GetStockDetails()).Returns(MockStockDetailsList);
            Assert.IsNotNull(mockStockBusiness);
        }

        [TestMethod]
        public void GetStockInfo_check_whether_stock_Info_are_present_or_not()
        {
            var mockStockBusiness = new Mock<IStockBusiness>();
            mockStockBusiness.Setup(x => x.GetStockInfo()).Returns(MockStockInfoList);
            Assert.IsNotNull(mockStockBusiness);
        }

        private List<StockInfo> MockStockInfoList()
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

        private List<Stock> MockStockDetailsList()
        {
            List<Prices> DateWisePrice = new List<Prices>();
            IRandomNo _randomNo = new GenerateNo();
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
    }
}
