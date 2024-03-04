using System;
using dotnet_jan_24_mac.Models;
namespace dotnet_jan_24_mac.Interfaces
{
	public interface IStocksProvider
	{
		public List<StockModel> GetStocks();


    }
}

