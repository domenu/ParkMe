using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ParkMe.iOS
{
	public partial class Parking
	{
		[JsonProperty(PropertyName = "timestamp")]
		public object Timestamp { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "address")]
		public string Address { get; set; }

		[JsonProperty(PropertyName = "contactInfo")]
		public string ContactInfo { get; set; }

		[JsonProperty(PropertyName = "openingHours")]
		public string OpeningHours { get; set; }

		[JsonProperty(PropertyName = "open")]
		public bool IsOpen { get; set; }

		[JsonProperty(PropertyName = "full")]
		public bool IsFull { get; set; }

		[JsonProperty(PropertyName = "suggestedRGB")]
		public string SuggestedRGB { get; set; }

		[JsonProperty(PropertyName = "totalCapacity")]
		public int TotalCapacity { get; set; }

		[JsonProperty(PropertyName = "availableCapacity")]
		public string AvailableCapacity { get; set; }

		[JsonProperty(PropertyName = "latitude")]
		public double Latitude { get; set; }

		[JsonProperty(PropertyName = "longitude")]
		public double Longitude { get; set; }

		[JsonProperty(PropertyName = "covered")]
		public bool IsCovered { get; set; }

		[JsonProperty(PropertyName = "activeRoute")]
		public List<object> ActiveRoutes { get; set; }
	}
}

