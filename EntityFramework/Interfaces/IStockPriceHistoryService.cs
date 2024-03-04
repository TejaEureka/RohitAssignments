using System;
using EntityFramework.Models;
namespace EntityFramework.Interfaces
{
	public interface IStockPriceHistoryService
	{
        public List<StocksPriceHistory> GetStockPriceHistory(string tickersymbol);
    }
}

