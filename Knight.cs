using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Knight : Piece
{
    public Knight(int x, int y, Texture2D sp, bool black) : base(x, y, sp, black)
    {

    }

    public override bool CanMove(int rowTarget, int columnTarget)
    {
        throw new NotImplementedException();
    }
}