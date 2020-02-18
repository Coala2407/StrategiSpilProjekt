using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class Arrow : GameObject
    {
        bool run;
        int spriteIndex;
        double nextBlinkTime;
        bool modelvisibility;
        public override void Update(GameTime gameTime)
        {
            //while (run)
            //{

            //    if (gameTime.TotalGameTime.TotalMilliseconds >= nextBlinkTime)
            //    {
            //        modelvisibility = !modelvisibility;
            //        if (modelvisibility)
            //        {
            //            spriteIndex = 0;
            //        }
            //        if (!modelvisibility)
            //        {
            //            spriteIndex = 1;
            //        }
            //        nextBlinkTime = gameTime.TotalGameTime.TotalMilliseconds + 1000;
            //    }
            //}
        }

        public override void OnCollision(GameObject otherObject)
        {

        }

        private void initialize()
        {
            size = 1f;
            sprite = Assets.ArrowSprite[spriteIndex];
        }

        public Arrow()
        {

        }
        
        public Arrow(Vector2 position, int spriteIndex)
        {
            this.position = position;
            this.spriteIndex = spriteIndex;
            initialize();
        }
    }
}
