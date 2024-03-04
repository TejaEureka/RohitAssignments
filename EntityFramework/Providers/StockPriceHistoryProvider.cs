using System;
using EntityFramework.Models;
using Npgsql;
using Dapper;
using EntityFramework.Interfaces;

namespace EntityFramework.Providers
{
	public class StockPriceHistoryProvider : IStockPriceHistoryProviderInterface
    {

		public List<StocksPriceHistory> GetStocksPriceHistory(string tickersymbol)
		{
			List<StocksPriceHistory> stocksPriceHistories = new List<StocksPriceHistory>();
            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";
            bool boolfound = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
                conn.Open();
                stocksPriceHistories = conn.Query<StocksPriceHistory>("select * from endeavour.stocks_price_history where ticker_symbol like @Tickersymbol", new { Tickersymbol = tickersymbol }).ToList();
                if (boolfound == false)
                {
                    Console.WriteLine("Data does not exist");
                }
            }
		    return stocksPriceHistories;
        }
	}
}

