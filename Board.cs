using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Board
{
    Texture2D tile;
    Vector2 tileSize;

    public Board(Texture2D t)
    {
        tile = t;
    }

    public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
    {
        tileSize = new Vector2(graphicsDevice.Viewport.Bounds.Height / 16); // Sets tilesize so that 16 tiles fit from top to bottom.

        Vector2 tilePos = new Vector2(graphicsDevice.Viewport.Bounds.Width / 2 - tileSize.X * 4, graphicsDevice.Viewport.Bounds.Height / 2 - tileSize.Y * 4);
        Rectangle tileRect = new Rectangle((int)tilePos.X, (int)tilePos.Y, (int)tileSize.X, (int)tileSize.Y);

        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                if (i % 2 == j % 2)
                    spriteBatch.Draw(tile, tileRect, Color.White);
                else
                    spriteBatch.Draw(tile, tileRect, Color.Black);

                tileRect.Y += (int)tileSize.Y;
            }
            tileRect.X += (int)tileSize.X;
            tileRect.Y = (int)tilePos.Y;
        }
    }
}