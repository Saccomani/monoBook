using Foundation;
using MonoBook.Implementation;
using UIKit;

namespace MonoBook.iOS.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		MainBook game;

		public override void FinishedLaunching(UIApplication application)
		{
			game = new MainBook();
			game.Run();
		}
	}
}
