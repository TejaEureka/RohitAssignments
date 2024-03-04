using System;
using dotnet_jan_24_mac.Models;
using dotnet_jan_24_mac.Providers;
using dotnet_jan_24_mac.Interfaces;
namespace dotnet_jan_24_mac.Services
{
	public class StocksService : IStocksService
	{
		public IStocksProvider provider;
		public StocksService(IStocksProvider stocksProvider)
		{
			provider = stocksProvider;
		}

		public List<StockModel> GetStocks()
		{
			return provider.GetStocks();
		}
	}
}

