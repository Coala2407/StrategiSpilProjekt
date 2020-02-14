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

        public Tile()
        {
            size = 0.15f;
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
