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
        Vector2 spawnPoint = new Vector2(45, (540 / 2 + 28));
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

        //Debug hitboxes
#if DEBUG
        Texture2D collisionTexture;
        private void DrawCollisionBox(GameObject go)
        {
            Rectangle collisionBox = go.GetCollisionBox();
            Rectangle topLine = new Rectangle(collisionBox.X, collisionBox.Y, collisionBox.Width, 1);
            Rectangle bottomLine = new Rectangle(collisionBox.X, collisionBox.Y + collisionBox.Height, collisionBox.Width, 1);
            Rectangle leftLine = new Rectangle(collisionBox.X, collisionBox.Y, 1, collisionBox.Height);
            Rectangle rightLine = new Rectangle(collisionBox.X + collisionBox.Width, collisionBox.Y, 1, collisionBox.Height);

            spriteBatch.Draw(Assets.collisionTexture, topLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(Assets.collisionTexture, bottomLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(Assets.collisionTexture, leftLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(Assets.collisionTexture, rightLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        }
#endif

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
        public static FontCoal fontCoal;
        public static FontDiamond fontDiamond;
        public static FontGold fontGold;
		public static Slave Sslave;

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Assets.LoadContent(Content);


            Bwank = new Bank();
            CcoalMine = new CoalMine();
            GgoldMine = new GoldMine();
            DdiamondMine = new DiamondMine();
            fontCoal = new FontCoal();
            fontDiamond = new FontDiamond();
            fontGold = new FontGold();
			Sslave = new Slave(spawnPoint, "CoalMiner");
            //Load shit right here boi:
            GameObjectList.Add(Bwank);
            GameObjectList.Add(CcoalMine);
            GameObjectList.Add(new Coal());
            GameObjectList.Add(GgoldMine);
            GameObjectList.Add(new Gold());
            GameObjectList.Add(DdiamondMine);
            GameObjectList.Add(new Diamond());
            GameObjectList.Add(fontCoal);
            GameObjectList.Add(fontGold);
            GameObjectList.Add(fontDiamond);
            GameObjectList.Add(new FontCreateSlave());
			GameObjectList.Add(Sslave);
			GameObjectList.Add(new Slave(spawnPoint, "GoldMiner"));
			GameObjectList.Add(new Slave(spawnPoint, "DiamondMiner"));

            // TODO: use this.Content to load your game content here
            //Load Debug hitbox
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
                SpawnCoalMiner();
            }
            if (Keyboard.HasBeenPressed(Keys.D2))
            {
                SpawnGoldMiner();
            }
            if (Keyboard.HasBeenPressed(Keys.D3))
            {
                SpawnDiamondMiner();
            }
			{
				//if (GameObject.Enabled == true)
				//{
				//	GameObject.Update();
				//	foreach (GameObject otherGaneObject in GameObjectList)
				//	{
				//		//forhindre objects i allGameObjects i at kollidere med sig selv.
				//		//if (GameObject != otherGaneObject)
				//		//{
				//		//	if (GameObject && (GameObject as DamageBox).ownerGameObject != otherGaneObject)
				//		//	{
				//		//		GameObject.CheckCollision(GameObject, otherGaneObject);
				//		//	}
				//		//	else if (otherGaneObject is DamageBox && (otherGaneObject as DamageBox).ownerGameObject != otherGaneObject)
				//		//	{
				//		//		GameObject.CheckCollision(GameObject, otherGaneObject);
				//		//	}


				//		//}
				//	}
				//}
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
#if DEBUG
                DrawCollisionBox(go);
#endif
            }

            spriteBatch.End();
        }

        // Spawn units
        public void SpawnCoalMiner()
        {
            if (fontCoal.coalCurrency >= 1)
            {
                GameObjectList.Add(new Slave(spawnPoint, "CoalMiner"));
                fontCoal.coalCurrency -= 1;
            }
        }

        public void SpawnGoldMiner()
        {
            if (fontCoal.coalCurrency >= 5)
            {
                GameObjectList.Add(new Slave(spawnPoint, "GoldMiner"));
                fontCoal.coalCurrency -= 5;
            }
        }

        public void SpawnDiamondMiner()
        {
            if (fontGold.goldCurrency >= 10)
            {
                GameObjectList.Add(new Slave(spawnPoint, "DiamondMiner"));
                fontGold.goldCurrency -= 10;
            }
        }
    }

}
