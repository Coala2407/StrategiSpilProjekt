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
        /// Default tile constructor
        /// </summary>
        public Tile()
        {
            initialize();
        }

        /// <summary>
        /// Change the turn direction of the tile. Makes the units turn
        /// </summary>
        /// <param name="tiledirection"></param>
        public Tile(Direction tiledirection)
        {
            TileDirection = tiledirection;
            initialize();
        }

        /// <summary>
        /// Only used for first and last tile. Sets unit spawn/despawn locations.
        /// </summary>
        /// <param name="tileMode"></param>
        public Tile(Mode tileMode)
        {
            TileMode = tileMode;
            initialize();
        }

        /// <summary>
        /// Runs on all constructors
        /// </summary>
        private void initialize()
        {
            size = 0.25f;
            sprite = Assets.GrassTile1.FirstOrDefault();
        }

        public override void OnCollision(GameObject otherObject)
        {

        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}
