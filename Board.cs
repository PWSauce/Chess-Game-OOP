using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

public class Board
{
    Grid pieces;
    Grid tiles;

    public Board(GraphicsDevice graphicsDevice)
    {
        int tileSize = graphicsDevice.Viewport.Height / 16;
        int gridHeight = graphicsDevice.Viewport.Height / 2;
        int gridWidth = graphicsDevice.Viewport.Width / 2 - tileSize * 4;
        Vector2 gridPos = new Vector2(gridWidth, gridHeight - tileSize * 4);

        pieces = new Grid(new Vector2(8, 8), gridPos, tileSize);
        tiles = new Grid(new Vector2(8, 8), gridPos, tileSize);

        string[] pieceCoord = new []
        {
            "PPPPPPPP",
            "RGBQKBGR"
        };

        // TODO: Optimize piece adding.
        for (int j = 0; j < pieceCoord.Length; ++j)
        {
            for (int i = 0; i < 8; ++i)
            {
                char charPiece = pieceCoord[pieceCoord.Length - j - 1][i];

                switch(charPiece)
                {
                    case 'P':
                        pieces.AddTile("pawn", Color.Black, i, j);
                        pieces.AddTile("pawn", Color.White, i, 7 - j);
                        break;

                    case 'R':
                        pieces.AddTile("rook", Color.Black, i, j);
                        pieces.AddTile("rook", Color.White, i, 7 - j);
                        break;

                    case 'G':
                        pieces.AddTile("knight", Color.Black, i, j);
                        pieces.AddTile("knight", Color.White, i, 7 - j);
                        break;

                    case 'B':
                        pieces.AddTile("bishop", Color.Black, i, j);
                        pieces.AddTile("bishop", Color.White, i, 7 - j);
                        break;

                    case 'K':
                        pieces.AddTile("king", Color.Black, i, j);
                        pieces.AddTile("king", Color.White, i, 7 - j);
                        break;

                    case 'Q':
                        pieces.AddTile("queen", Color.Black, i, j);
                        pieces.AddTile("queen", Color.White, i, 7 - j);
                        break;
                    
                    default:
                        throw new System.ArgumentOutOfRangeException("Unknown piece type.");
                }
            }
        }

        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                if (i % 2 == j % 2)
                    tiles.AddTile("Square", new Color(0xF0, 0xD9, 0xB5), i, j);
                else
                    tiles.AddTile("Square", new Color(0x94, 0x6f, 0x51), i, j);
            }
        }
    }

    public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
    {
        tiles.Draw(spriteBatch);
        pieces.Draw(spriteBatch);
    }
}