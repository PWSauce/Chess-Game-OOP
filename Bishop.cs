using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Bishop : Piece
{
    public Bishop(int x, int y, Texture2D sp, bool black) : base(x, y, sp, black)
    {

    }

    public override bool CanMove(int rowTarget, int columnTarget)
    {
        return Math.Abs(row - rowTarget) == Math.Abs(column - columnTarget);
    }
}