using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace ParkMe.iOS
{
	public partial class RootViewController : UITableViewController
	{
		public RootViewController () : base ("RootViewController", null)
		{
			Title = "Parkeergarages in Gent";
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
			var parkingManager = new ParkingManager ();
			var parkings = parkingManager.GetParkings ();

//			var parkings =  carParkManager.GetParkings ();
//			foreach(var carPark in carParks)
//			{
//				double latitude = double.Parse(carPark.Latitude);
//				double longitude = double.Parse(carPark.Longitude);
//				carPark.DistanceFromCurrentLocation = new CLLocation(50.975684, 3.724051).DistanceFrom(new CLLocation(latitude, longitude)) / 1000;
//				// e.Location.DistanceFrom(new MonoTouch.CoreLocation.CLLocation(latitude, longitude)) / 1000;
//			}
//
//			var locationManager = new LocationManager ();
//			locationManager.LocationUpdated += (sender, e) => {
//				foreach(var carPark in carParks)
//				{
//					double latitude = double.Parse(carPark.Latitude);
//					double longitude = double.Parse(carPark.Longitude);
//					carPark.DistanceFromCurrentLocation = e.Location.DistanceFrom(new CLLocation(latitude, longitude));
//						// e.Location.DistanceFrom(new MonoTouch.CoreLocation.CLLocation(latitude, longitude)) / 1000;
//				}
//				InvokeOnMainThread (() => TableView.ReloadData ());
//			};

			var parkingDataSource = new ParkingDataSource (this, parkings);
			TableView.Source = parkingDataSource;

			//locationManager.StartLocationUpdates ();
		}
	}
}

