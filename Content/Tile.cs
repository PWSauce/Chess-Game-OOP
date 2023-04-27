using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Tile
{
    Rectangle tilePos;
    Texture2D sprite;
    Color color;

    public Tile(Rectangle rect, Texture2D sp, Color cl)
    {
        tilePos = new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        sprite = sp;
        color = cl;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(sprite, tilePos, color);
    }

}