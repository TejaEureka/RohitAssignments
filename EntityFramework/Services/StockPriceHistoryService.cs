using System;
using EntityFramework.Models;
using EntityFramework.Interfaces;
using EntityFramework.Providers;

namespace EntityFramework.Services
{
	public class StockPriceHistoryService : IStockPriceHistoryService
	{
		IStockPriceHistoryProviderInterface stockPriceHistoryProvider;
		public StockPriceHistoryService(IStockPriceHistoryProviderInterface stocksPriceHistoryProvider)
		{
            stockPriceHistoryProvider = stocksPriceHistoryProvider;
		}

		public List<StocksPriceHistory> GetStockPriceHistory(string tickersymbol)
		{
            return stockPriceHistoryProvider.GetStocksPriceHistory(tickersymbol);
		}
	}
}

