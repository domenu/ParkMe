// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace ParkMe.iOS
{
	[Register ("ParkingDetailViewController")]
	partial class ParkingDetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel labelCapacteit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelExtraInfo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelNaam { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelPostcodeGemeente { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelStraatNummer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelTelefoon { get; set; }

		[Outlet]
		MonoTouch.MapKit.MKMapView mapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (labelNaam != null) {
				labelNaam.Dispose ();
				labelNaam = null;
			}

			if (labelStraatNummer != null) {
				labelStraatNummer.Dispose ();
				labelStraatNummer = null;
			}

			if (labelPostcodeGemeente != null) {
				labelPostcodeGemeente.Dispose ();
				labelPostcodeGemeente = null;
			}

			if (mapView != null) {
				mapView.Dispose ();
				mapView = null;
			}

			if (labelCapacteit != null) {
				labelCapacteit.Dispose ();
				labelCapacteit = null;
			}

			if (labelTelefoon != null) {
				labelTelefoon.Dispose ();
				labelTelefoon = null;
			}

			if (labelExtraInfo != null) {
				labelExtraInfo.Dispose ();
				labelExtraInfo = null;
			}
		}
	}
}
