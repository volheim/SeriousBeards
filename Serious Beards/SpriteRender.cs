using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    class SpriteRender:Component,ILoadable,IDrawable //Skal sikre at vi kan tegne vores objekter fra GameObject
    {
        private Rectangle spriteRectangle;
        private Texture2D sprite;
        private string spriteName;
        private float Layer;

        public SpriteRender(GameObject gameObject,string spriteName, float layer)
        {

        }

        public void Update()
        {

        }
         public void LoadContent(ContentManager contentManager)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
