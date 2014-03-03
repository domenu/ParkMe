using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MapKit;
using MonoTouch.CoreLocation;
using MonoTouch.CoreGraphics;

namespace ParkMe.iOS
{
	public partial class ParkingDetailViewController : UIViewController
	{
		private Parking _parking;

		public ParkingDetailViewController () : base ("ParkingDetailViewController", null)
		{

		}

		public void SetCarPark(Parking parking)
		{
			if (parking != _parking) {
				_parking = parking;
			}
		}

		private void RefreshView()
		{
			if (_parking == null)
				return;

			var adresParts = _parking.Address.Split(new string[] {"<br>"}, StringSplitOptions.RemoveEmptyEntries);

			Title = _parking.Description;
			labelBeschikbareCapaciteit.Text = _parking.AvailableCapacity;
			labelBeschikbareCapaciteit.BackgroundColor = UIColor.Clear.FromHexString (_parking.SuggestedRGB);
			labelAfstand.Text = "10";										// TODO
			labelIsOpen.Text = _parking.IsOpen ? "Ja" : "Neen";
			labelStraatNummer.Text = adresParts [0];
			labelPostcodeGemeente.Text = adresParts [1];
			labelContact.Text = _parking.ContactInfo;
			labelTotaleCapaciteit.Text = _parking.TotalCapacity.ToString();

			ShowCarParkOnMap ();
		}

		void ShowCarParkOnMap ()
		{
			var annotation = new MapAnnotation (new CLLocationCoordinate2D (_parking.Latitude, _parking.Longitude), _parking.Description, _parking.Address);
			mapView.AddAnnotation (annotation);

			var coords = new MonoTouch.CoreLocation.CLLocationCoordinate2D (_parking.Latitude, _parking.Longitude);
			var span = new MKCoordinateSpan (KilometresToLatitudeDegrees (0.5), KilometresToLongitudeDegrees (0.5, coords.Latitude));
			mapView.Region = new MKCoordinateRegion (coords, span);
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
		}
	}
}

