using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace SPIL
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        //Screen size
        public const int Width = 1920;
        public const int Height = 1080;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //To get random numbers
        public static Random rng = new Random();

        //Collection of all game objects
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
            //Screen setup
            graphics.PreferredBackBufferWidth = Width;
            graphics.PreferredBackBufferHeight = Height;
            graphics.ToggleFullScreen();
            this.IsMouseVisible = true;
            this.Window.AllowAltF4 = false;
            graphics.ApplyChanges();


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
            //Load all assets
            Assets.LoadContent(Content);

            //Add things here. After assets have been loaded

            //Test tile
            GameObjectList.Add(new Tile(false, new Vector2(20, 20)));
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

            //Updates all game objects in the game
            foreach (GameObject go in GameObjectList)
            {
                go.Update(gameTime);

                foreach (GameObject other in GameObjectList)
                {
                    //Checks for collision between all game objects
                    go.CheckCollision(other);
                }
            }

            //Remove game objects in runtime
            foreach (GameObject go in RemoveGameObjects)
            {
                GameObjectList.Remove(go);
            }

            //Add new game objects in runtime
            GameObjectList.AddRange(NewGameObjects);
            NewGameObjects.Clear();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            foreach (GameObject go in GameObjectList)
            {
                go.Draw(spriteBatch);
            }
            spriteBatch.End();
            // TODO: Add your drawing code here
            
            base.Draw(gameTime);
        }
    }
}
