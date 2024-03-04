using System;
using dotnet_jan_24_mac.Models;
namespace dotnet_jan_24_mac.Interfaces
{
	public interface ISectorProvider
	{
		public List<SectorModel> GetSectors();
	}
}

