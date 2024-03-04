using dotnet_jan_24_mac.Models;
using dotnet_jan_24_mac.Interfaces;
using Npgsql;
namespace dotnet_jan_24_mac.Providers
{
    public class StocksProvider : IStocksProvider
	{
		public StocksProvider()
		{
		}
		public List<StockModel> GetStocks()
		{
            List<StockModel> stocks = new List<StockModel>();

            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";
            bool boolfound = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM endeavour.stocks_lookup", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    boolfound = true;
                    Console.WriteLine("connection established");
                    while (dr.Read())
                    {
                        StockModel newItem = new StockModel();

                        newItem.TickerSymbol = dr.GetString(0);
                        newItem.TickerName = dr.GetString(1);
                        stocks.Add(newItem);
                    }
                    Console.WriteLine($"sectorLookups rows retrieved count:{stocks.Count}");
                }
                if (boolfound == false)
                {
                    Console.WriteLine("Data does not exist");
                }
                dr.Close();
            }


            return stocks;
        }
	}
}

