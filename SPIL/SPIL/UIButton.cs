using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIL
{
    class UIButton : UI
    {
        public UIButton(Vector2 position, Texture2D texture, string text, string name)
        {
            this.position = position;
            this.name = name;
            sprite = texture;
        }
    }
}
