using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MapKit;

namespace ParkMe.iOS
{
	public partial class ParkingDetailViewController : UIViewController
	{
		private CarPark _parking;

		public ParkingDetailViewController () : base ("ParkingDetailViewController", null)
		{
			Title = "Parking info";
		}

		public void SetParkingInfo(CarPark parking)
		{
			if (parking != _parking) {
				_parking = parking;
			}
		}

		private void RefreshView()
		{
			if (_parking != null) {
				Title = _parking.Name;
				//labelNaam.Text = _parking.Name;
				labelStraatNummer.Text = _parking.AddressLine1;
				labelPostcodeGemeente.Text = _parking.PCO + " " + _parking.Location;

				var coords = new MonoTouch.CoreLocation.CLLocationCoordinate2D (double.Parse (_parking.Latitude), double.Parse (_parking.Longitude));
				var span = new MKCoordinateSpan(KilometresToLatitudeDegrees(1), KilometresToLongitudeDegrees(1, coords.Latitude));
				mapView.Region = new MKCoordinateRegion(coords, span);

				labelCapacteit.Text = _parking.Capacity;
				labelTelefoon.Text = _parking.Phone;
				labelExtraInfo.Text = _parking.FreeText;
			}
		}

		/// <summary>Converts kilometres to latitude degrees</summary>
		public double KilometresToLatitudeDegrees(double kms)
		{
			double earthRadius = 6371.0; // in kms
			double radiansToDegrees = 180.0/Math.PI;
			return (kms/earthRadius) * radiansToDegrees;
		}

		/// <summary>Converts kilometres to longitudinal degrees at a specified latitude</summary>
		public double KilometresToLongitudeDegrees(double kms, double atLatitude)
		{
			double earthRadius = 6371.0; // in kms
			double degreesToRadians = Math.PI/180.0;
			double radiansToDegrees = 180.0/Math.PI;
			// derive the earth's radius at that point in latitude
			double radiusAtLatitude = earthRadius * Math.Cos(atLatitude * degreesToRadians);
			return (kms / radiusAtLatitude) * radiansToDegrees;
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

			RefreshView ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

