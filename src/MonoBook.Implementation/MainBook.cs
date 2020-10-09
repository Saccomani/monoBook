using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoBook.Implementation.Enum;
using MonoBook.Implementation.Views;
using MonoGame.Extended.ViewportAdapters;

namespace MonoBook.Implementation
{
    public class MainBook : Game
    {
		#region [Fields]
		Color bookBackGroundColor = Color.FromNonPremultiplied(16, 17, 24, 100);
		#endregion
		private BookType bookType;
		GraphicsDeviceManager graphics;

		HeaderView _headerView;

		ScalingViewportAdapter _viewportAdapter;

		public MainBook()
        {
			graphics = new GraphicsDeviceManager(this);
			graphics.IsFullScreen = true;

			graphics.PreferredBackBufferWidth = 800;
			graphics.PreferredBackBufferHeight = 480;

			graphics.PreparingDeviceSettings += (sender, e) =>
			{
				e.GraphicsDeviceInformation.PresentationParameters.PresentationInterval = PresentInterval.Two;
			};



		}
		protected override void Initialize()
		{
			base.Initialize();
		}

		protected override void LoadContent()
		{
		
		
			_viewportAdapter = new ScalingViewportAdapter(this.GraphicsDevice, 800, 480);

			_headerView = new HeaderView(graphics, this, _viewportAdapter);



		}
		protected override void Update(GameTime gameTime)
		{
			
			base.Update(gameTime);

			_headerView.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{

			base.Draw(gameTime);

			var ma = _viewportAdapter.GetScaleMatrix();

		
			GraphicsDevice.Clear(bookBackGroundColor);

		


			switch (bookType)
            {
				case BookType.Analytical:
					break;
				case BookType.AnalyticalSimple:
					break;
				case BookType.Consolidated:
					break;
				case BookType.ConsolidatedSimple:
					break;
				default:
                    break;
            }


			_headerView.Draw(gameTime);

		
		}
	}
}
