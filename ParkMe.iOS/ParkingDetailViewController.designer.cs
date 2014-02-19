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
		MonoTouch.UIKit.UILabel labelAdres { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelAvailableCapacity { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelAvailableCapcity { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelCapacteit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelExtraInfo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelTelefoon { get; set; }

		[Outlet]
		MonoTouch.MapKit.MKMapView mapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (labelAvailableCapacity != null) {
				labelAvailableCapacity.Dispose ();
				labelAvailableCapacity = null;
			}

			if (labelAdres != null) {
				labelAdres.Dispose ();
				labelAdres = null;
			}

			if (labelAvailableCapcity != null) {
				labelAvailableCapcity.Dispose ();
				labelAvailableCapcity = null;
			}

			if (labelCapacteit != null) {
				labelCapacteit.Dispose ();
				labelCapacteit = null;
			}

			if (labelExtraInfo != null) {
				labelExtraInfo.Dispose ();
				labelExtraInfo = null;
			}

			if (labelTelefoon != null) {
				labelTelefoon.Dispose ();
				labelTelefoon = null;
			}

			if (mapView != null) {
				mapView.Dispose ();
				mapView = null;
			}
		}
	}
}
