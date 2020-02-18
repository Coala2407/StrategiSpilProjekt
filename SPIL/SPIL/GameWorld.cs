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

        Unit unit1;
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

            byte tileMod = 54;

            //Add things here. After assets have been loaded
            //textures: 0 = grass1, 1=grass2, 2=grass3, 3=sand, 4=water 54x54p, 20x20 tiles
            //GameObjectList.Add(new Tile(false, new Vector2(20, 20), 0));
            //GameObjectList.Add(new Tile(false, new Vector2(120, 20), 1));
            //GameObjectList.Add(new Tile(false, new Vector2(220, 20), 2));
            //GameObjectList.Add(new Tile(false, new Vector2(320, 20), 3));
            //GameObjectList.Add(new Tile(false, new Vector2(420, 20), 4));
            for (int i = 0; i < 20; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), 0), 0));
            }
            for (int i = 0; i < 4; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((i*tileMod), tileMod), 3));
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j < 20; j++)
                {
                    GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), j * tileMod), 0));
                }
            }
            for (int i = 2; i < 20; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2(0, (i * tileMod)), 0));
            }
            for (int i = 2; i < 17; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((3*tileMod), (i * tileMod)), 3));
            }
            for (int i = 17; i < 20; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2((3 * tileMod), (i * tileMod)), 0));
            }
            for (int i = 4; i < 8; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((i * tileMod), (16 * tileMod)), 3));
            }
            for (int i = 10; i < 16; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((7 * tileMod), (i * tileMod)), 3));
            }
            for (int i = 8; i < 14; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((i * tileMod), (10 * tileMod)), 3));
            }
            for (int i = 11; i < 17; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((13 * tileMod), (i * tileMod)), 3));
            }
            for (int i = 13; i < 17; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((i * tileMod), (16 * tileMod)), 3));
            }
            for (int i = 7; i < 17; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((16 * tileMod), (i * tileMod)), 3));
            }
            for (int i = 6; i < 17; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((i * tileMod), (7 * tileMod)), 3));
            }
            for (int i = 3; i < 7; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((6 * tileMod), (i * tileMod)), 3));
            }
            for (int i = 6; i < 19; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((i * tileMod), (3 * tileMod)), 3));
            }
            for (int i = 3; i < 19; i++)
            {
                GameObjectList.Add(new Tile(true, new Vector2((18 * tileMod), (i * tileMod)), 3));
            }
            for (int i = 4; i < 20; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), j * tileMod), 0));
                }
            }
            for (int i = 4; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), j * tileMod), 0));
                }
            }
            for (int i = 7; i < 18; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), (4 * tileMod)), 0));
            }
            for (int i = 7; i < 17; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), (6 * tileMod)), 0));
            }
            GameObjectList.Add(new Tile(false, new Vector2((7*tileMod), (5*tileMod)), 0));
            for (int i = 8; i < 18; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2((i * tileMod), (5 * tileMod)), 4));
            }
            for (int i = 6; i < 16; i++)
            {
                GameObjectList.Add(new Tile(false, new Vector2((17 * tileMod), (i * tileMod)), 4));
            }

            unit1 = new Unit
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
