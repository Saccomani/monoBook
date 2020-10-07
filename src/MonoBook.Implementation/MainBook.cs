using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoBook.Implementation.Enum;
using MonoBook.Implementation.Views;

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
        public MainBook()
        {
			graphics = new GraphicsDeviceManager(this);
			graphics.IsFullScreen = true;
		}
		protected override void Initialize()
		{
			base.Initialize();
		}

		protected override void LoadContent()
		{
			var font = Content.Load<SpriteFont>("Header");

			_headerView = new HeaderView(graphics, font);
		}
		protected override void Update(GameTime gameTime)
		{
			
			base.Update(gameTime);

			_headerView.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{

			base.Draw(gameTime);


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
