using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SPIL
{
    class UI : GameObject
    {
        public UI()
        {
            sprite = Assets.UIBackground;
            position = new Vector2(1080, 0);
        }

        public override void OnCollision(GameObject otherObject)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
