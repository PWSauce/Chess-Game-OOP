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

    Pawn pawn;
    Piece[] pieces;

    Board board;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        pieces = new Piece[8];
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        sprite = Content.Load<Texture2D>("pawn");
        tile = Content.Load<Texture2D>("Square");
        pawn = new Pawn(0, 0, sprite, true);
        pieces[0] = pawn;
        board = new Board(tile);

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
        pieces[0].Draw(_spriteBatch);
        board.Draw(_spriteBatch, _graphics.GraphicsDevice);
        _spriteBatch.End();


        base.Draw(gameTime);
    }
}
