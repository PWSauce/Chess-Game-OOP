using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Board
{
    Texture2D tile;
    int tileSize = 30;

    public Board(Texture2D t)
    {
        tile = t;
    }

    public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
    {
        Vector2 tilePos = new Vector2(graphicsDevice.Viewport.Bounds.Width / 2 - tileSize * 4, graphicsDevice.Viewport.Bounds.Height / 2 - tileSize * 4);
        Rectangle tileRect = new Rectangle((int)tilePos.X, (int)tilePos.Y, tileSize, tileSize);

        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                if (i % 2 == j % 2)
                    spriteBatch.Draw(tile, tileRect, Color.White);
                else
                    spriteBatch.Draw(tile, tileRect, Color.Black);

                tileRect.Y += tileSize;
            }
            tileRect.X += tileSize;
            tileRect.Y = (int)tilePos.Y;
        }
    }
}