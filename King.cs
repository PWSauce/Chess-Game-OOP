using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class King : Piece
{
    bool hasMoved;

    public King(int x, int y, Texture2D sp, bool black) : base(x, y, sp, black)
    {
        hasMoved = false;
    }

    public override bool CanMove(int rowTarget, int columnTarget)
    {
        Vector2 targetDelta = new Vector2(Math.Abs(rowTarget - row), Math.Abs(columnTarget - column));
        
        return targetDelta.X == 1 || targetDelta.Y == 1;
    }
}