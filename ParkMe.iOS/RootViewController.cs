using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using RestSharp;

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

			var client = new RestClient ("http://datatank.gent.be/");
			var parkingRequest = new RestRequest ("Infrastructuur/Parkeergarages.json", Method.GET);
			var parkingResponse = client.Execute<RootObject> (parkingRequest);

			// Perform any additional setup after loading the view, typically from a nib.
			var parkingList = new List<CarPark> {
				new CarPark { Name = "Kouter" }, 
				new CarPark { Name = "Sint-Michiels"}
			};
			var parkingDataSource = new ParkingDataSource (this, parkingList);
			TableView.Source = parkingDataSource;		
		}
	}
}

