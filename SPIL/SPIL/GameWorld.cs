using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SPIL
{

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //World size
        public const int WindowWidth = 960;
        public const int WindowHeight = 540;

        //All game objects. Used to draw
        public static List<GameObject> GameObjectList = new List<GameObject>();
        //To add and remove objects in runtime
        public static List<GameObject> NewGameObjects = new List<GameObject>();
        public static List<GameObject> RemoveGameObjects = new List<GameObject>();

        public static void AddGameObject(GameObject gameObject)
        {
            NewGameObjects.Add(gameObject);
        }

        public static void RemoveGameObject(GameObject gameObject)
        {
            RemoveGameObjects.Add(gameObject);
        }

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //Screen setup
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
            this.IsMouseVisible = true;
            graphics.ApplyChanges();

            base.Initialize();
        }

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		public static Bank Bwank;
		public static CoalMine CcoalMine;
		public static GoldMine GgoldMine;
		public static DiamondMine DdiamondMine;

		protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Assets.LoadContent(Content);


			Bwank = new Bank();
			CcoalMine = new CoalMine();
			GgoldMine = new GoldMine();
			DdiamondMine = new DiamondMine();
            //Load shit right here boi:
			GameObjectList.Add(Bwank);
            GameObjectList.Add(CcoalMine);
            GameObjectList.Add(new Coal());
            GameObjectList.Add(GgoldMine);
            GameObjectList.Add(new Gold());
            GameObjectList.Add(DdiamondMine);
            GameObjectList.Add(new Diamond());
            GameObjectList.Add(new FontCoal());
            GameObjectList.Add(new FontGold());
            GameObjectList.Add(new FontDiamond());
            GameObjectList.Add(new FontCreateSlave());
			GameObjectList.Add(new Slave(new Vector2(480, 270), "CoalMiner"));
			GameObjectList.Add(new Slave(new Vector2(480, 270), "GoldMiner"));
			GameObjectList.Add(new Slave(new Vector2(480, 270), "DiamondMiner"));
			GameObjectList.Add(new Slave(new Vector2(480, 300), "DiamondMiner"));

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
            //Spawn units
            if (Keyboard.HasBeenPressed(Keys.D1))
            {
                GameObjectList.Add(new Slave(new Vector2(900, 500), "CoalMiner"));
            }
            if (Keyboard.HasBeenPressed(Keys.D2))
            {
                GameObjectList.Add(new Slave(new Vector2(900, 500), "GoldMiner"));
            }
            if (Keyboard.HasBeenPressed(Keys.D3))
            {
                GameObjectList.Add(new Slave(new Vector2(900, 500), "DiamondMiner"));
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

            foreach (GameObject go in GameObjectList)
            {
                go.Draw(spriteBatch);
            }

            spriteBatch.End();
        }
    }

}
