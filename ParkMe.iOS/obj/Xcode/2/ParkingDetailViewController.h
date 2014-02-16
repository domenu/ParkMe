// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ParkingDetailViewController : UIViewController {
	UILabel *_labelCapacteit;
	UILabel *_labelExtraInfo;
	UILabel *_labelNaam;
	UILabel *_labelPostcodeGemeente;
	UILabel *_labelStraatNummer;
	UILabel *_labelTelefoon;
	MKMapView *_mapView;
}

@property (nonatomic, retain) IBOutlet UILabel *labelCapacteit;

@property (nonatomic, retain) IBOutlet UILabel *labelExtraInfo;

@property (nonatomic, retain) IBOutlet UILabel *labelNaam;

@property (nonatomic, retain) IBOutlet UILabel *labelPostcodeGemeente;

@property (nonatomic, retain) IBOutlet UILabel *labelStraatNummer;

@property (nonatomic, retain) IBOutlet UILabel *labelTelefoon;

@property (nonatomic, retain) IBOutlet MKMapView *mapView;

@end
