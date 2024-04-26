using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnStock.Domain
{
    public class StockData
    {
        public int Count { get; set; }
        public List<StockLine> Result { get; set; }
    }
}
