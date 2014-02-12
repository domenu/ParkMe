using System;
using System.Collections.Generic;

namespace ParkMe.iOS
{
	public class CarPark
	{
		public string Name { get; set; }
		public string AddressLine1 { get; set; }
		public string Location { get; set; }
		public string PCO { get; set; }
		public string Phone { get; set; }
		public string DefaultLanguage { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Capacity { get; set; }
		public string Floors { get; set; }
		public string parkingType { get; set; }
		public string FreeText { get; set; }
	}

	public class Carparks
	{
		public List<CarPark> CarPark { get; set; }
	}

	public class Agency
	{
		public Carparks Carparks { get; set; }
		public string Name { get; set; }
		public string AddressLine1 { get; set; }
		public string Location { get; set; }
		public string PCO { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string EMail { get; set; }
		public string TimeZone { get; set; }
		public string Website { get; set; }
	}

	public class Parkeergarages
	{
		public Agency Agency { get; set; }
	}

	public class RootObject
	{
		public Parkeergarages Parkeergarages { get; set; }
	}

}

