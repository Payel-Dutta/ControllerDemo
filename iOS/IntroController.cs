using System;
using System.Drawing;
using UIKit;

namespace ControllerDemo.iOS
{
	public partial class IntroController : BaseController
	{
		public IntroController() : base("IntroController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		
			View.BackgroundColor = UIColor.White;

			var title = new UILabel(new RectangleF(0, 80, 320, 30));
			title.Font = UIFont.SystemFontOfSize(24.0f);
			title.TextAlignment = UITextAlignment.Center;
			title.TextColor = UIColor.Blue;
			title.Text = "I am Introduction View Controller";
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


