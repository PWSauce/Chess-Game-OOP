using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

public class Grid
{
    Vector2 gridSize;
    Vector2 pos;
    int tileSize;
    List<GridTile> gridTiles;

    public Grid(Vector2 gridSz, Vector2 gridPos, int tileSz)
    {
        gridSize = gridSz;
        pos = gridPos;
        tileSize = tileSz;
        gridTiles = new List<GridTile>();
    }

    public void AddTile(string spriteName, Color color, int row, int column)
    {
        gridTiles.Add(new GridTile(ResourceManager.FindSprite(spriteName), color, row, column));
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        for (int i = 0; i < gridTiles.Count; ++i)
        {
            Texture2D sp = gridTiles[i].sprite;
            Rectangle tileRect = new Rectangle((int)pos.X + tileSize * gridTiles[i].row, (int)pos.Y + tileSize * gridTiles[i].column, tileSize, tileSize);
            spriteBatch.Draw(sp, tileRect, gridTiles[i].color);
        }
    }
}