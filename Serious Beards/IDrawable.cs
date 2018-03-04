using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    interface IDrawable//Skal bruges til at skelne mellem hvilke klasser der indeholder en load content og draw
    {
        void Draw(SpriteBatch spriteBatchInterface);
    }
}
