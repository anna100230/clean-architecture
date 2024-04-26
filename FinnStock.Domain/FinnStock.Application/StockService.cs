using FinnStock.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnStock.Application
{
    public class StockService :IStockService
    {
        private readonly IStockRepository stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            this.stockRepository = stockRepository;
        }
        List<StockData> IStockService.GetAllStocks()
        {
            return this.stockRepository.GetAllStocks();
        }
    }
}
