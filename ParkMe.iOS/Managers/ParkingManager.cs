using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ParkMe.iOS
{
	public class ParkingManager
	{
		public List<Parking> GetParkings()
		{
			// http://datatank.gent.be/Mobiliteitsbedrijf/Parkings11.json
			var client = new RestClient ("http://datatank.gent.be");
			var request = new RestRequest ("/Mobiliteitsbedrijf/Parkings11.json");
			var response = client.Execute (request);

			var jObject = JObject.Parse (response.Content);
			var token = jObject ["Parkings11"] ["parkings"];
			var parkings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Parking>> (token.ToString ());
			return parkings.OrderBy(p => p.Description).ToList();
		}
	}
}

