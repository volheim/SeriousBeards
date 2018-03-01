using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    class CollisionTiles : Tile
    {
        public CollisionTiles(int i, Rectangle rectangle)
        { 
//Placeringen for vores Tile//Loader den angivende tile efter nummer så den ligger "Tile" sammen med int
//Alle disse tiles bliver loaded gennem vores GameWorld klasse.
//Dette gør det også muligt at kunne bruge det samme parameter til flere forskellige tiles
    texture = Content.Load<Texture2D>("Tile" + i);
            this.Rectangle = rectangle;                    
        }                                                  
    }                                                     
}

