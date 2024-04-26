﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnStock.Domain
{
    public class StockLine
    {
        public string Description { get; set; }
        public string Symbol { get; set; }
        public string DisplaySymbol { get; set; }
        public string Type { get; set; }
    }
}
