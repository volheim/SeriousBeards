using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    enum Directoin { Front,Back,Left,Right}; //Bruges til at bestemme hvilken retning man går, angriber eller står idle i.

    interface IAnimationStrategy
    {
        void Update(ref Directoin directoin);

    }
}
