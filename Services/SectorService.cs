using System;
using dotnet_jan_24_mac.Interfaces;
using dotnet_jan_24_mac.Models;

namespace dotnet_jan_24_mac.Services
{
	public class SectorService : ISectorService
	{
        public ISectorProvider provider;
        public SectorService(ISectorProvider sectorprovider)
		{
            provider = sectorprovider;
		}
        public List<SectorModel> GetSectors()
        {
            return provider.GetSectors();
        }
    }
}

