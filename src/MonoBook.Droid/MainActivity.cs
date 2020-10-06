using Android.App;
using Android.OS;
using Android.Views;
using Microsoft.Xna.Framework;
using MonoBook.Implementation;

namespace MonoBook.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AndroidGameActivity
    {
		protected override void OnCreate(Bundle savedInstanceState)
		{
			MainBook game;

			base.OnCreate(savedInstanceState);
			game = new MainBook();

			SetContentView((View)game.Services.GetService(typeof(View)));
			game.Run();

		}
	}
}
