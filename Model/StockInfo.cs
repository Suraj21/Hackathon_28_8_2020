using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonStockPriceWebApi.Model
{
    public class StockInfo
    {
        public string CompanyName { get; set; }
        public List<string> News { get; set; }
        public string Date { get; set; }
        public string Recommandation { get; set; }
    }
}
