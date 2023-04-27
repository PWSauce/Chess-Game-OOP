using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace ChessGameOOP;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Texture2D sprite;
    Texture2D tile;

    Texture2D pieceSprite;

    Pawn pawn;

    Board board;

    MouseState prev;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        _graphics.PreferredBackBufferWidth = 1920;
        _graphics.PreferredBackBufferHeight = 1080;
        _graphics.ApplyChanges();

        board = new Board(_graphics.GraphicsDevice);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        sprite = Content.Load<Texture2D>("pawn");
        tile = Content.Load<Texture2D>("Square");

        board.LoadContent(_graphics.GraphicsDevice, tile);


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
                        pieceSprite = Content.Load<Texture2D>("pawn");
                        board.AddPiece(new Pawn(i, j, pieceSprite, true));
                        board.AddPiece(new Pawn(i, 7 - j, pieceSprite, false));
                        break;

                    case 'R':
                        pieceSprite = Content.Load<Texture2D>("rook");
                        board.AddPiece(new Rook(i, j, pieceSprite, true));
                        board.AddPiece(new Rook(i, 7 - j, pieceSprite, false));
                        break;

                    case 'G':
                        pieceSprite = Content.Load<Texture2D>("knight");
                        board.AddPiece(new Knight(i, j, pieceSprite, true));
                        board.AddPiece(new Knight(i, 7 - j, pieceSprite, false));
                        break;

                    case 'B':
                        pieceSprite = Content.Load<Texture2D>("bishop");
                        board.AddPiece(new Bishop(i, j, pieceSprite, true));
                        board.AddPiece(new Bishop(i, 7 - j, pieceSprite, false));
                        break;

                    case 'K':
                        pieceSprite = Content.Load<Texture2D>("king");
                        board.AddPiece(new King(i, j, pieceSprite, true));
                        board.AddPiece(new King(i, 7 - j, pieceSprite, false));
                        break;

                    case 'Q':
                        pieceSprite = Content.Load<Texture2D>("queen");
                        board.AddPiece(new Queen(i, j, pieceSprite, true));
                        board.AddPiece(new Queen(i, 7 - j, pieceSprite, false));
                        break;
                    
                    default:
                        throw new System.ArgumentOutOfRangeException("Unknown piece type.");
                }
            }
        }
        // 
    }

    void PieceMove()
    {
        MouseState curr = Mouse.GetState();

        if (curr.LeftButton == ButtonState.Pressed && prev.LeftButton == ButtonState.Released)
        {
            
        }

        prev = curr;
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
        board.Draw(_spriteBatch, _graphics.GraphicsDevice);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
