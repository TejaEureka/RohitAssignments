using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class TotalMarketStock
{
    public string TickerSymbol { get; set; } = null!;

    public string? TickerName { get; set; }
}
