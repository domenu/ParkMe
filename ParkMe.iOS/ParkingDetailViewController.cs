using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MapKit;
using MonoTouch.CoreLocation;

namespace ParkMe.iOS
{
	public partial class ParkingDetailViewController : UIViewController
	{
		private CarPark _parking;

		public ParkingDetailViewController () : base ("ParkingDetailViewController", null)
		{
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

				var latitude = double.Parse (_parking.Latitude);
				var longitude = double.Parse (_parking.Longitude);

				var annotation = new MapAnnotation (new CLLocationCoordinate2D(latitude, longitude), _parking.Name, _parking.AddressLine1);
				mapView.AddAnnotation(annotation);
				var coords = new MonoTouch.CoreLocation.CLLocationCoordinate2D (latitude, longitude);
				var span = new MKCoordinateSpan(KilometresToLatitudeDegrees(0.2), KilometresToLongitudeDegrees(0.2, coords.Latitude));
				mapView.Region = new MKCoordinateRegion(coords, span);

				labelCapacteit.Text = _parking.Capacity;
				buttonDialNumber.SetTitle (_parking.Phone, UIControlState.Normal);
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

		private void DialCarPark(object sender, EventArgs e)
		{
			// URL encode phone number
			var regex = new System.Text.RegularExpressions.Regex (@"[^\d]");
			var phoneNumber = regex.Replace (_parking.Phone, "");

			var encodedPhoneNumber = Uri.EscapeDataString(phoneNumber);
			var phoneUrl = NSUrl.FromString(string.Format(@"tel://{0}", encodedPhoneNumber));
			UIApplication.SharedApplication.OpenUrl(phoneUrl);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			RefreshView ();
			buttonDialNumber.TouchUpInside += DialCarPark;
		}
	}
}

