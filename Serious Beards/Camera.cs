using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    public class Camera //Skal gør det muligt at alle kan når ud til klassen
    {
        public Matrix Transform { get; private set; } 

        //public void Follow()
        //{
        //    var position = Matrix.CreateTranslation //Dette skal kikke på positionen af vores player hvor i den går ind i midten af spriten i form af at vi dividere højde og bredte med 2
        //    //Dette vil også gøre at vores sprite sidder lidt underlig aka sidder ude i hjørnet så man ikke kan se det hele
        //    (-Player.player.position.X - (Player.player.SpriteRect.Width / 2),
        //     -Player.player.position.Y - (Player.player.SpriteRect.Height / 2),
        //     0);
        //     //Skulle gerne skubbe vores sprite til centret af vores kamera
        //    var offset = Matrix.CreateTranslation(GameWorld.ScreenWidth/2,
        //     GameWorld.ScreenHeight/2,
        //     0);

        //    Transform = position * offset;
        //}
        
    }
}
