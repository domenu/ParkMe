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
using System.Threading.Tasks;

namespace ParkMe.iOS
{
	public partial class RootViewController : UITableViewController
	{
		private LoadingOverlay _loadingOverlay;
		private ParkingDataSource _parkingDataSource;

		public RootViewController () : base ("RootViewController", null)
		{
			Title = "Parkings";
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public async override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_loadingOverlay = new LoadingOverlay (UIScreen.MainScreen.Bounds, "Parkeerinfo ophalen...");
			View.Add (_loadingOverlay);

			var parkings = new List<Parking> ();
			await Task.Factory.StartNew (() => {
				var parkingManager = new ParkingManager ();
				parkings = parkingManager.GetParkings ();
			});

			_parkingDataSource = new ParkingDataSource (this, parkings);
			TableView.Source = _parkingDataSource;

			_loadingOverlay.Hide ();
			StartLocationUpdates ();	
		}

		private void StartLocationUpdates ()
		{
			var locationManager = new LocationManager ();
			locationManager.LocationUpdated += (sender, e) => {
				foreach (var parking in _parkingDataSource.ParkingList) {
					parking.DistanceFromCurrentLocation = e.Location.DistanceFrom (new CLLocation (parking.Latitude, parking.Longitude)) / 1000;
					// e.Location.DistanceFrom(new MonoTouch.CoreLocation.CLLocation(latitude, longitude)) / 1000;
				}
				InvokeOnMainThread (() => TableView.Source = _parkingDataSource);
			};
			locationManager.StartLocationUpdates ();
		}
	}
}

