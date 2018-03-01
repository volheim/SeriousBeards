using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    class Walk:IAnimationStrategy
    {
        private Animatior animatior; //Til animation
        private Transform transform; //Til movement af vores player

        public Walk(Transform transform, Animator animator)
        {
            
        }
        public void Execute(ref Directoin directoin)
        {
            animatior.PlayAnimation("Walk" + directoin);
        }
    }
}
