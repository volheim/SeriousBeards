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
    class Tile
    {
        protected Texture2D texture;
        private Rectangle position; //Position for vores tiles
        private static ContentManager content; //Skal sætte værdien for content


        public Rectangle Rectangle //Gør det muligt at kunne komme ind og ændre "Rectangle position"
        {
            get { return position; }
            set { position = value; }
        }

        public static ContentManager Content // Sikre at man kan load alle tiles content fra denne her klasse.
        {
            get { return content; }
            set { content = value; }
        }

        public void DrawTile(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);

        }
    }
}
