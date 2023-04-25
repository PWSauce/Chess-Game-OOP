using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Pawn : Piece
{
    public Pawn(int x, int y, Texture2D sp) : base(x, y, sp)
    {

    }
    
    public override bool CanMove(int xTarget, int yTarget)
    {
        throw new NotImplementedException();
    }
}