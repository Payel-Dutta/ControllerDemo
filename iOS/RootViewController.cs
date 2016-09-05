using System;

using UIKit;

namespace ControllerDemo.iOS
{
	public partial class RootViewController : UIViewController
	{
		// the sidebar controller for the app
		public SidebarNavigation.SidebarController SidebarController { get; private set; }

		// the navigation controller
		public NavController NavController { get; private set; }

		public RootViewController() : base(null, null)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.Red;
			// create a slideout navigation controller with the top navigation controller and the menu view controller
			NavController = new NavController();
			NavController.PushViewController(new IntroController(), false);
			SidebarController = new SidebarNavigation.SidebarController(this, NavController, new SIdeMenuController());
			SidebarController.MenuWidth = 100;
			SidebarController.ReopenOnRotate = false;
		}
	}
}


