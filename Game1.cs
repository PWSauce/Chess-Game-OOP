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

        sprite = Content.Load<Texture2D>("pawn");
        ResourceManager.AddSprite(sprite);
        sprite = Content.Load<Texture2D>("rook");
        ResourceManager.AddSprite(sprite);
        sprite = Content.Load<Texture2D>("king");
        ResourceManager.AddSprite(sprite);
        sprite = Content.Load<Texture2D>("queen");
        ResourceManager.AddSprite(sprite);
        sprite = Content.Load<Texture2D>("bishop");
        ResourceManager.AddSprite(sprite);
        sprite = Content.Load<Texture2D>("knight");
        ResourceManager.AddSprite(sprite);
        sprite = Content.Load<Texture2D>("Square");
        ResourceManager.AddSprite(sprite);

        board = new Board(_graphics.GraphicsDevice);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
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
