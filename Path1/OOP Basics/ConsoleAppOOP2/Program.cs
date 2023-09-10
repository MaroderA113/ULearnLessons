using System;
using System.Globalization;

namespace ConsoleAppOOP2
{
	public class City
	{
		public string Name;
		public GeoLocation Location;
	}

	public class GeoLocation
	{
		public double Latitude;
		public double Longitude;
	}
	public class Program
	{
		static void Main()
		{
			var city = new City
			{
				Name = "Ekaterinburg",
				Location = new GeoLocation()
			};
			city.Location.Latitude = 56.50;
			city.Location.Longitude = 60.35;
			Console.WriteLine("I love {0} located at ({1}, {2})",
				city.Name,
				city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
				city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
		}
	}
}
