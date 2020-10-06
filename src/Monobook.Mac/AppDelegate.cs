using AppKit;
using Foundation;
using MonoBook.Implementation;

namespace Monobook.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {

        MainBook game;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application

            game = new MainBook();
            game.Run();
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
