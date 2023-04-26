using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public abstract class Piece
{
    protected int row {get; set; }
    protected int column {get; set; }
    protected Texture2D sprite {get; set; }
    protected bool isBlack {get; set; }

    public Piece(int x, int y, Texture2D sp, bool black = false)
    {
        row = x;
        column = y;
        sprite = sp;
        isBlack = black;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Color color = (isBlack) ? Color.Black : Color.White;
        spriteBatch.Draw(sprite, new Vector2(row, column), color);
    }

    public abstract bool CanMove(int rowTarget, int columnTarget);
}