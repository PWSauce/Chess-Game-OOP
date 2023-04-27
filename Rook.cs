using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Rook : Piece
{
    bool hasMoved;
    public Rook(int x, int y, Texture2D sp, bool black) : base(x, y, sp, black)
    {
        hasMoved = false;
    }

    public override bool CanMove(int rowTarget, int columnTarget)
    {
        throw new NotImplementedException();
    }
}