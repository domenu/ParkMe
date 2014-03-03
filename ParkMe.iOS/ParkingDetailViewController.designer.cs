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
		MonoTouch.UIKit.UIButton buttonCallParking { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonNavigeren { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelAfstand { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelBeschikbareCapaciteit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelIsOpen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelPostcodeGemeente { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelStraatNummer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelTotaleCapaciteit { get; set; }

		[Outlet]
		MonoTouch.MapKit.MKMapView mapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonCallParking != null) {
				buttonCallParking.Dispose ();
				buttonCallParking = null;
			}

			if (buttonNavigeren != null) {
				buttonNavigeren.Dispose ();
				buttonNavigeren = null;
			}

			if (labelAfstand != null) {
				labelAfstand.Dispose ();
				labelAfstand = null;
			}

			if (labelBeschikbareCapaciteit != null) {
				labelBeschikbareCapaciteit.Dispose ();
				labelBeschikbareCapaciteit = null;
			}

			if (labelIsOpen != null) {
				labelIsOpen.Dispose ();
				labelIsOpen = null;
			}

			if (labelPostcodeGemeente != null) {
				labelPostcodeGemeente.Dispose ();
				labelPostcodeGemeente = null;
			}

			if (labelStraatNummer != null) {
				labelStraatNummer.Dispose ();
				labelStraatNummer = null;
			}

			if (labelTotaleCapaciteit != null) {
				labelTotaleCapaciteit.Dispose ();
				labelTotaleCapaciteit = null;
			}

			if (mapView != null) {
				mapView.Dispose ();
				mapView = null;
			}
		}
	}
}
