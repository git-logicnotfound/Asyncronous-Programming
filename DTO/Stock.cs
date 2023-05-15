using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asyncronous_Programming.DTO
{
    public class StockPrice
    {
        public string Identifier { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal? Open { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Close { get; set; }
        public int Volume { get; set; }
        public decimal Change { get; set; }
        public decimal ChangePercent { get; set; }
    }
}