using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MonoBook.Implementation
{
    public class MainBook : Game
    {
		GraphicsDeviceManager graphics;

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
		

		}

		protected override void Update(GameTime gameTime)
		{
			
			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			base.Draw(gameTime);
		}
	}
}
