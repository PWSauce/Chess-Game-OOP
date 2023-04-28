using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class GridTile
{
    public Texture2D sprite { get; private set; }
    public Color color { get; private set;}
    public int row { get; private set; }
    public int column { get; private set; }

    public GridTile(Texture2D sp, Color cl, int r, int c)
    {
        sprite = sp;
        color = cl;
        row = r;
        column = c;
    }

}