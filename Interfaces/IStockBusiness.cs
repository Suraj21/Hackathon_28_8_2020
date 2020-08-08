using HackathonStockPriceWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonStockPriceWebApi
{
    public interface IStockBusiness
    {
       List<Stock> GetStockDetails();
       List<StockInfo> GetStockInfo();
    }
}
