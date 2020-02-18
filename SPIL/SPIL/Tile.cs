using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class Tile : GameObject
    {
        public enum Mode
        {
            StartTile = 0,
            EndTile = 1
        }
        public enum Direction
        {
            TurnUp = 0,
            TurnRight = 1,
            TurnDown = 2,
            TurnLeft = 3
        }

        /// <summary>
        /// Makes the units turn on the map. Not used for all tiles.
        /// </summary>
        Direction tileDirection;
        public Direction TileDirection { get; set; }

        /// <summary>
        /// Only used for the first and last tile. Sets unit spawn/despawn location.
        /// </summary>
        Mode tileMode;
        public Mode TileMode { get; set; }

        /// <summary>
        /// Set to true if units walk on the tile. Towers can't be built on a path tile.
        /// </summary>
        bool isUnitPath;
        public bool IsUnitPath { get; set; }
        /// <summary>
        /// Default tile constructor
        /// </summary>
        private int spriteIndex;
        public Tile(bool isUnitPath, Vector2 position, int spriteIndex)
        {
            this.spriteIndex = spriteIndex;
            this.isUnitPath = isUnitPath;
            this.position = position;

            initialize();
        }

        /// <summary>
        /// Change the turn direction of the tile. Makes the units turn
        /// </summary>
        /// <param name="tiledirection"></param>
        public Tile(bool isUnitPath, Vector2 position, Direction tiledirection, int spriteIndex)
        {
            this.spriteIndex = spriteIndex;
            this.isUnitPath = isUnitPath;
            this.position = position;
            TileDirection = tiledirection;
            initialize();
        }

        /// <summary>
        /// Only used for first and last tile. Sets unit spawn/despawn locations.
        /// </summary>
        /// <param name="tileMode"></param>
        public Tile(bool isUnitPath, Vector2 position, Mode tileMode, int spriteIndex)
        {
            this.spriteIndex = spriteIndex;
            this.isUnitPath = isUnitPath;
            this.position = position;
            TileMode = tileMode;
            initialize();

        }

        /// <summary>
        /// Runs on all constructors
        /// </summary>
        private void initialize()
        {
            size = 0.25f;
            sprite = Assets.TileSprites[spriteIndex];
        }

        public override void OnCollision(GameObject otherObject)
        {

        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}