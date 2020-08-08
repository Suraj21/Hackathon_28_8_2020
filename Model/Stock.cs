using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonStockPriceWebApi.Model
{
    public class Stock
    {
        public string CompanyName { get; set; }
        public List<Prices> DateWisePrices { get; set; }
        public string Date { get; set; }
    }
}
