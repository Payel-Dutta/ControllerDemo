using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace ControllerDemo.iOS
{
	public partial class ViewController : UIViewController
	{
		//int count = 1;
		string translatedNumber = "";
		public List<string> PhoneNumbers { get; set; }

		public ViewController(IntPtr handle) : base(handle)
		{
			PhoneNumbers = new List<string>();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		
			//public List<string> PhoneNumbers { get; set; }

			headingLabel.Text = "Enter A Phoneword";
			translateButton.SetTitle(@"Translate To Number", UIControlState.Normal);
			callButton.SetTitle(@"Call", UIControlState.Normal);
			callHistoryButton.SetTitle(@"Call History Button", UIControlState.Normal);

			translateButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				translatedNumber = PhoneTranslator.ToNumber(PhoneNumberText.Text);
				PhoneNumberText.ResignFirstResponder();

				if (translatedNumber == "")
				{
					callButton.SetTitle(@"Call", UIControlState.Normal);
					callButton.Enabled = false;
				}
				else
				{
					callButton.SetTitle(@"Call " + translatedNumber, UIControlState.Normal);
					callButton.Enabled = true;
				}
			};
			callButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				PhoneNumbers.Add(translatedNumber);
			};
			callHistoryButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				// Launches a new instance of CallHistoryController
				CallHistoryController callHistory = this.Storyboard.InstantiateViewController("CallHistoryController") as CallHistoryController;
				if (callHistory != null)
				{
					callHistory.PhoneNumbers = PhoneNumbers;
					this.NavigationController.PushViewController(callHistory, true);
				}
			};
		}
		//public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		//{
		//	base.PrepareForSegue(segue, sender);

		//	// set the View Controller that’s powering the screen we’re
		//	// transitioning to

		//	var callHistoryContoller = segue.DestinationViewController as CallHistoryController;

		//	//set the Table View Controller’s list of phone numbers to the
		//	// list of dialed phone numbers

		//	if (callHistoryContoller != null)
		//	{
		//		callHistoryContoller.PhoneNumbers = PhoneNumbers;
		//	}
		//}
	}
}
		
	

