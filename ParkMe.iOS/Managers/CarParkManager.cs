using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ParkMe.iOS
{
	public class CarParkManager
	{
		public CarParkManager ()
		{
		}

		public List<CarPark> GetCarParks()
		{
			var document = XDocument.Load ("http://datatank.gent.be/Infrastructuur/Parkeergarages.xml");
			var carParks = (from carPark in document.Descendants ("CarPark")
			               select new CarPark { 
				Name = carPark.Element ("Name").Value,
				AddressLine1 = carPark.Element ("AddressLine1").Value,
				Location = carPark.Element ("Location").Value,
				PCO = carPark.Element ("PCO").Value,
				Phone = carPark.Element ("Phone").Value,
				DefaultLanguage = carPark.Element ("DefaultLanguage").Value,
				Latitude = carPark.Element ("Latitude").Value,
				Longitude = carPark.Element ("Longitude").Value,
				Capacity = carPark.Element ("Capacity").Value,
				Floors = carPark.Element ("Floors").Value,
				parkingType = carPark.Element ("parkingType").Value,
					FreeText = carPark.Element ("FreeText").Value
			}).OrderBy (carPark => carPark.Name).ToList ();

			return carParks;
		}

	}
}

