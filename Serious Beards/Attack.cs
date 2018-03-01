using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    class Attack:IAnimationStrategy
    {
        private Animator animator;//Animaton

        public Attack(Animator animator)
        {

        }

        public void Execute(ref Directoin directoin)
        {
            animator.PlayAnimation("Attack" + directoin);
        }

    }
}
