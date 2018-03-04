using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    interface ILoadable //Skal bruges til at skelne mellem hvilke klasser der indeholder en load content og draw
    {
        void LoadContent(ContentManager contentManagerInterface);


    }
}
