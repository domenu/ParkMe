using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

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
			
			// Perform any additional setup after loading the view, typically from a nib.
			var parkingList = new List<Parking> {
				new Parking { Naam = "Kouter" }, 
				new Parking { Naam = "Sint-Michiels"}
			};
			var parkingDataSource = new ParkingDataSource (this, parkingList);
			TableView.Source = parkingDataSource;		
		}
	}
}

