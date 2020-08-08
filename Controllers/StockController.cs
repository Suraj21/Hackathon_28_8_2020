using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonStockPriceWebApi.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonStockPriceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        //Unity Can be used to resolve the IStockBusiness and IRandomNo contracts
        //IStockBusiness _stockBusiness;
        //public StockController(IStockBusiness stockBusiness)
        //{
        //    _stockBusiness = stockBusiness;
        //}

        // GET: api/Stock
        [HttpGet]
        [EnableCors("AllowOrigin")]
        public List<Stock> Get()
        {
            IRandomNo radomNo = new GenerateNo();
            IStockBusiness _stockBusiness = new StockBusiness(radomNo);
            var stockDetail = _stockBusiness.GetStockDetails();
            return stockDetail;
        }

        // GET: api/Stock/5
        [HttpGet("{id}", Name = "Get")]
        [EnableCors("AllowOrigin")]
        public List<StockInfo> Get(int id)
        {
            IRandomNo radomNo = new GenerateNo();
            IStockBusiness _stockBusiness = new StockBusiness(radomNo);
            var stockInfos = _stockBusiness.GetStockInfo();
            return stockInfos;
        }

        // GET: api/Stock/5
        [Route("GetStockInfo/{id}")]
        [HttpGet]
        [EnableCors("AllowOrigin")]
        public List<StockInfo> GetStockInfo(int id)
        {
            
            IRandomNo radomNo = new GenerateNo();
            IStockBusiness _stockBusiness = new StockBusiness(radomNo);
            var stockInfos = _stockBusiness.GetStockInfo();
            return stockInfos;
        }

        [Route("GetCompanyDetails/{id}")]
        [HttpGet]
        [EnableCors("AllowOrigin")]
        public List<Stock> GetCompanyDetails(int id)
        {
            IRandomNo radomNo = new GenerateNo();
            IStockBusiness _stockBusiness = new StockBusiness(radomNo);
            var stockDetail = _stockBusiness.GetStockDetails();
            return stockDetail;
        }

        // POST: api/Stock
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stock/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
