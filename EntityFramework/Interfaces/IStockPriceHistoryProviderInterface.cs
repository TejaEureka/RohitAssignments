using System;
using EntityFramework.Providers;
using EntityFramework.Models;
namespace EntityFramework.Interfaces
{
	public interface IStockPriceHistoryProviderInterface
	{
        public List<StocksPriceHistory> GetStocksPriceHistory(string tickersymbol);
	}
}

