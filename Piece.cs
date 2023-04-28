using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public abstract class Piece : GridTile
{

    Vector2 tileSize;

    public Piece(int x, int y, Texture2D sp, bool black) : base(sp, black ? Color.Black : Color.White, x, y)
    {
    }

    public abstract bool CanMove(int rowTarget, int columnTarget);
}