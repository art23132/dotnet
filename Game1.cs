using System;
using System.Diagnostics;
using System.Security.Authentication;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace dotnet;

public class Game1 : Game
{

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont _spriteFont;


    //texture for sprite
    private Texture2D _spriteCat;
    private Texture2D _spriteFut;
    private Vector2 SpritePos_Cat;


    float timer = 0f;
    int x = 0;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = false;
    }

    protected override void Initialize()
    {
        
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _spriteCat = Content.Load<Texture2D>("sprite_hero");
        _spriteFut = Content.Load<Texture2D>("sprite_Fut");
        _spriteFont = Content.Load<SpriteFont>("Font");

        SpritePos_Cat = new Vector2(0, 0);
        

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

        MouseState mouseState = Mouse.GetState();

        int cursorX = mouseState.X;
        int cursorY = mouseState.Y;

        SpritePos_Cat.X = cursorX;
        SpritePos_Cat.Y = cursorY;

        // if (_spriteCat.Intersect())
        // {
            
        // }

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(new Color(189, 203, 240));

        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _spriteBatch.Draw(_spriteFut, new Rectangle(new Point(0, 0), new Point(_spriteFut.Width * 4, _spriteFut.Height * 4) ), Color.White);
        _spriteBatch.Draw(_spriteCat, new Rectangle(new Point((int)SpritePos_Cat.X, (int)SpritePos_Cat.Y), new Point(64)), Color.White);

        _spriteBatch.DrawString(_spriteFont, "Scoore: " + x, new Vector2(20, 420), Color.Black);
        
        _spriteBatch.End();

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}



