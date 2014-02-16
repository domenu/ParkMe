using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using RestSharp;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace ParkMe.iOS
{
	public partial class RootViewController : UITableViewController
	{
		public RootViewController () : base ("RootViewController", null)
		{
			Title = "ParkMe";
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

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
			}).ToList ();

			/*
			var client = new RestClient ("http://datatank.gent.be/");
			var parkingRequest = new RestRequest ("Infrastructuur/Parkeergarages.json", Method.GET);
			var parkingResponse = client.Execute<RootObject> (parkingRequest);
*/
			// Perform any additional setup after loading the view, typically from a nib.
			/*
			var parkingList = new List<CarPark> {
				new CarPark { Name = "Kouter" }, 
				new CarPark { Name = "Sint-Michiels" }
			};
			*/
			var parkingDataSource = new ParkingDataSource (this, carParks);
			TableView.Source = parkingDataSource;		
		}
	}
}

