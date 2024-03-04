using System;
using EntityFramework.Models;

namespace EntityFramework.ProfileModels
{
	public class FavoriteStocksModel
	{
        public int FavoriteStockId { get; set; }
        public string TickerSymbol { get; set; }
        public int UserId { get; set; }
    }
}

