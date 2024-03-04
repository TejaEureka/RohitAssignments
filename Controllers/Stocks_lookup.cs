using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_jan_24_mac.Models;
using dotnet_jan_24_mac.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet_jan_24_mac.Controllers
{
    [ApiController]
    [Route("/sectors")]
    public class Stocks_lookup : Controller
    {
        ISectorService sectorService;
        public Stocks_lookup(ISectorService service)
        {
            sectorService = service;
        }
        [HttpGet(Name = "GetSectors")]
        public List<SectorModel> getSectors()
        {
            return sectorService.GetSectors();
        }

    }
}

