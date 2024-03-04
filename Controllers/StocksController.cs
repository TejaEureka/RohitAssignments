using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_jan_24_mac.Models;
using dotnet_jan_24_mac.Services;
using dotnet_jan_24_mac.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet_jan_24_mac.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StocksController : Controller
    {
        IStocksService stocksService;
        public StocksController(IStocksService service)
        {
            stocksService = service;
        }
        [HttpGet(Name = "GetStocks")]
        public List<StockModel> Get()
        {
            return stocksService.GetStocks();
        }
    }
}

