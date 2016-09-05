using System;

using UIKit;

namespace ControllerDemo.iOS
{
	public partial class SIdeMenuController : UIViewController
	{
		public SIdeMenuController() : base("SIdeMenuController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


