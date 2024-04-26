using FinnStock.Application;
using FinnStock.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnStock.Infrastructure
{
    public class StockRepository :IStockRepository
    {
        public List<StockData> GetAllStocks()
        {
            return null;
        }

    }
}
