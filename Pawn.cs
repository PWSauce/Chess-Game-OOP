using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Pawn : Piece
{
    bool hasMoved { get; set; }

    public Pawn(int x, int y, Texture2D sp, bool isBlack) : base(x, y, sp, isBlack)
    {
        hasMoved = false;
    }
    
    public override bool CanMove(int rowTarget, int columnTarget)
    {
        throw new NotImplementedException();
    }

    bool DiagonalAttack(int rowTarget, int columnTarget)
    {
        return false;
    }

    bool enPassant(int rowTarget, int columnTarget)
    {
        return false;
    }
}