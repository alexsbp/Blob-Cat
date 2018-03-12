using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using IrrKlang;
using Microsoft.Xna.Framework.Audio;

namespace BlobCat
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class GameWorld : Game
	{
		Bullet bullet; 
		public static GraphicsDeviceManager graphics;
		bool isShooting = false; 
        List<GameObject> objects = new List<GameObject>();
		List<SoundEffect> soundeffects = new List<SoundEffect>();
		public static List<Bullet> usedBullets = new List<Bullet>();
		List<Bullet> Bullets = new List<Bullet>();
		private SpriteBatch spriteBatch;

		public GameWorld()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			graphics.PreferredBackBufferWidth = 1400;
			graphics.PreferredBackBufferHeight = 800;
	}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			ISoundEngine engine = new ISoundEngine(); 
            // TODO: Add your initialization logic here 
            objects.Add(new BlobCat(Content.Load<Texture2D>("Blobcat"), new Vector2(100, 500), 0f, 1.0f));

            this.IsMouseVisible = true; 

			//instantier musik 

			base.Initialize();
		}
        
		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
          
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();



			// TODO: Add your update logic here

            foreach (GameObject o in objects)
            {
                o.Update();
            }

			#region Skyd kode
			KeyboardState keyState = Keyboard.GetState();

			if (keyState.IsKeyDown(Keys.Space) && isShooting == false)
			{ 
				foreach (BlobCat BC in objects)
				{
					Bullets.Add(new Bullet(Content.Load<Texture2D>("rainbowStar"), new Vector2(BC.Position.X + 100, BC.Position.Y + 170), 0.1f, 0.3f));
					soundeffects.Add(Content.Load<SoundEffect>("owen_wilson_wow"));
					soundeffects[0].Play();
				}
				isShooting = true;
			}
			if (keyState.IsKeyUp(Keys.Space))
			{
				isShooting = false;
			}
			#endregion
			foreach (Bullet bt in Bullets)
			{
				bt.Update();
			}

			if (usedBullets != null)
			{
				foreach (Bullet bt in usedBullets)
				{
					Bullets.Remove(bt);
				}
			}

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            foreach( GameObject o in objects)
            {
                o.Draw(spriteBatch);
            }
			foreach (Bullet bt in Bullets)
			{
				bt.Draw(spriteBatch);
			}

			spriteBatch.End();


			base.Draw(gameTime);
		}
	}
}
