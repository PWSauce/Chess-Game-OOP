using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

public class Board
{
    Vector2 tileSize;

    List<Piece> pieces;
    List<Tile> tiles;

    public Board(GraphicsDevice graphicsDevice)
    {
        Initialize(graphicsDevice);
    }

    void Initialize(GraphicsDevice graphicsDevice)
    {
        tileSize = new Vector2(graphicsDevice.Viewport.Bounds.Height / 16); // Sets tilesize so that 16 tiles fit from top to bottom.

        pieces = new List<Piece>();
        tiles = new List<Tile>();
    }

    public void LoadContent(GraphicsDevice graphicsDevice, Texture2D tileSprite)
    {
        Vector2 tilePos = new Vector2(graphicsDevice.Viewport.Bounds.Width / 2 - tileSize.X * 4, graphicsDevice.Viewport.Bounds.Height / 2 - tileSize.Y * 4);
        Rectangle tileRect = new Rectangle((int)tilePos.X, (int)tilePos.Y, (int)tileSize.X, (int)tileSize.Y);

        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                if (i % 2 == j % 2)
                    tiles.Add(new Tile(tileRect, tileSprite, new Color(0xF0, 0xD9, 0xB5)));
                else
                    tiles.Add(new Tile(tileRect, tileSprite, new Color(0x94, 0x6f, 0x51)));

                tileRect.Y += (int)tileSize.Y;
            }
            tileRect.X += (int)tileSize.X;
            tileRect.Y = (int)tilePos.Y;
        }
    }

    public void AddPiece(Piece piece)
    {
        pieces.Add(piece);
    }

    public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
    {
        for (int i = 0; i < tiles.Count; ++i)
        {
            tiles[i].Draw(spriteBatch);
        }

        for (int i = 0; i < pieces.Count; ++i)
        {
            pieces[i].Draw(spriteBatch, graphicsDevice);
        }
    }
}