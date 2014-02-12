using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ParkMe.iOS
{
	public partial class ParkingDetailViewController : UIViewController
	{
		private Parking _parking;

		public ParkingDetailViewController () : base ("ParkingDetailViewController", null)
		{
			Title = "Parking info";
		}

		public void SetParkingInfo(Parking parking)
		{
			if (parking != _parking) {
				_parking = parking;

				RefreshView ();
			}
		}

		private void RefreshView()
		{
			if (_parking != null) {
				Title = _parking.Naam;
			}
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
		}
	}
}

