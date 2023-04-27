using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public abstract class Piece
{
    protected int row { get; set; }
    protected int column { get; set; }
    protected Texture2D sprite { get; set; }
    protected bool isBlack { get; }

    Vector2 tileSize;

    public Piece(int x, int y, Texture2D sp, bool black)
    {
        row = x;
        column = y;
        sprite = sp;
        isBlack = black;
    }

    public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
    {
        tileSize = new Vector2(graphicsDevice.Viewport.Bounds.Height / 16); // Sets tilesize so that 16 tiles fit from top to bottom.
        Vector2 tilePos = new Vector2(graphicsDevice.Viewport.Bounds.Width / 2 - tileSize.X * 4, graphicsDevice.Viewport.Bounds.Height / 2 - tileSize.Y * 4);
        Rectangle tileRect = new Rectangle((int)tilePos.X, (int)tilePos.Y, (int)tileSize.X, (int)tileSize.Y);

        int blackOffset = isBlack ? (int)tileSize.X * 8 : 0;
        tileRect.X += (int)tileSize.X * row;
        tileRect.Y += (int)tileSize.Y * column;

        Color color = (isBlack) ? Color.Black : Color.White;
        spriteBatch.Draw(sprite, tileRect, color);

        Console.WriteLine(tilePos);
    }

    public abstract bool CanMove(int rowTarget, int columnTarget);
}