using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public abstract class Piece
{
    protected int xCoord;
    protected int yCoord;
    protected Texture2D sprite;

    public Piece(int x, int y, Texture2D sp)
    {
        xCoord = x;
        yCoord = y;
        sprite = sp;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(sprite, new Vector2(xCoord, yCoord), Color.White);
    }

    public abstract bool CanMove(int xTarget, int yTarget);
}