using System;
using System.Collections.Generic;
using MonoTouch.UIKit;

namespace ParkMe.iOS
{
	public class ParkingDataSource : UITableViewSource
	{
		private RootViewController _controller;
		private IList<CarPark> _parkingList;

		public ParkingDataSource (RootViewController controller, IList<CarPark> parkingList)
		{
			_controller = controller;
			_parkingList = parkingList;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return  1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _parkingList.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			string cellId = "ParkingCell";
			var cell = tableView.DequeueReusableCell (cellId);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellId);
				cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			}

			// configure the cell
			cell.TextLabel.Text = _parkingList [indexPath.Row].Name;
			// cell.DetailTextLabel.Text = matchList[indexPath.Row].Score;
			//cell.ImageView.Image = UIImage.FromFile(matchList[indexPath.Row].Icon);
			return cell;
		}

		public override void RowSelected (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			var parkingDetailViewController = new ParkingDetailViewController ();
			parkingDetailViewController.SetCarPark (_parkingList [indexPath.Row]);
			_controller.NavigationController.PushViewController (parkingDetailViewController, true);
		}

	}
}

