using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.ViewportAdapters;

namespace MonoBook.Implementation.Views
{
    public class HeaderView
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch spriteBatch;
        SpriteFont _font;
        ViewportAdapter _viewportAdapter;
        public HeaderView(GraphicsDeviceManager graphics, Game game, ViewportAdapter viewportAdapter)
        {
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
            _graphics = graphics;
            
            _font = game.Content.Load<SpriteFont>("File");
            _viewportAdapter = viewportAdapter;
        }

        void DrawFixedHeader()
        {

            spriteBatch.DrawString(_font, "ULTIMO", new Vector2(50, 50), Color.FromNonPremultiplied(83, 94, 115,200));
            spriteBatch.DrawString(_font, "VARIACAO", new Vector2(200, 50), Color.FromNonPremultiplied(83, 94, 115, 200));
            spriteBatch.DrawString(_font, "VOLUME", new Vector2(400, 50), Color.FromNonPremultiplied(83, 94, 115, 200));
            spriteBatch.DrawString(_font, "NEGOCIOS", new Vector2(500, 50), Color.FromNonPremultiplied(83, 94, 115, 200));
            spriteBatch.DrawString(_font, "HORA", new Vector2(650, 50), Color.FromNonPremultiplied(83, 94, 115, 200));
            
        }

        public void Draw(GameTime gameTime)
        {


            var ma = _viewportAdapter.GetScaleMatrix();

            spriteBatch.Begin(transformMatrix: ma);

            var randonLast = new Random().Next(-100, 200);
            var randonVol = new Random().Next(-100, 200);
            var randonVolume = new Random().Next(-100, 200);
            DrawFixedHeader();


            spriteBatch.DrawString(_font, $"{randonLast}", new Vector2(50, 70), (randonLast < 0 )? Color.Red: Color.White);
            spriteBatch.DrawString(_font, $"{randonVol}", new Vector2(200, 70), (randonVol < 0) ? Color.Red : Color.White);
            spriteBatch.DrawString(_font, $"{randonVolume}", new Vector2(400, 70), (randonVol < 0) ? Color.Red : Color.White);
            spriteBatch.DrawString(_font, $"{randonVolume}", new Vector2(500, 70), (randonVol < 0) ? Color.Red : Color.White);
            spriteBatch.DrawString(_font, $"{randonVolume}", new Vector2(650, 70), (randonVol < 0) ? Color.Red : Color.White);

            spriteBatch.End();
        }

        public void Update(GameTime gameTime)
        {
      

        }

    }
}
