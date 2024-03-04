using System;
using dotnet_jan_24_mac.Models;
using Npgsql;
using dotnet_jan_24_mac.Interfaces;

namespace dotnet_jan_24_mac.Providers
{
	public class SectorProvider : ISectorProvider
	{
		public SectorProvider()
		{
		}
        public List<SectorModel> GetSectors()
        {
            List<SectorModel> sectors = new List<SectorModel>();
            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";
            bool boolfound = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM endeavour.sector_lookup", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    boolfound = true;
                    Console.WriteLine("connection established");
                    while (dr.Read())
                    {
                        SectorModel newItem = new SectorModel();

                        newItem.SectorId = dr.GetInt32(0);
                        newItem.SectorName = dr.GetString(1);
                        sectors.Add(newItem);
                    }
                    Console.WriteLine($"sectorLookups rows retrieved count:{sectors.Count}");
                    if (boolfound == false)
                    {
                        Console.WriteLine("Data does not exist");
                    }
                    dr.Close();
                }
            }
            return sectors;
        }
	}
}

