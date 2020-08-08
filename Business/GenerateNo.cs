using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonStockPriceWebApi
{
    public class GenerateNo : IRandomNo
    {
        public int GetRandomNo()
        {
            Random random = new Random();

            return random.Next(1, 200);
        }
    }
}
