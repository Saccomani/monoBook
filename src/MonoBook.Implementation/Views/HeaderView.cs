using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoBook.Implementation.Views
{
    public class HeaderView
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch spriteBatch;
        SpriteFont _font;
        Color bookBackGroundColor = Color.FromNonPremultiplied(16, 17, 24, 100);

        public HeaderView(GraphicsDeviceManager graphics,SpriteFont font)
        {
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
            _graphics = graphics;

            _font = font;
        }


        public void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(_font, $"CONTADOR : {gameTime.TotalGameTime.TotalSeconds}", new Vector2(100, 200), Color.White);

            spriteBatch.End();

        }

        public void Update(GameTime gameTime)
        {
      

        }

    }
}
