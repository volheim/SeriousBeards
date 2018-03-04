using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    abstract class Component
    {
        private GameObject gameObject;

        public GameObject GameObjects
        {
            get { return gameObject; } //Skal retunere dens værdi til field op gameObject
        }
        public Component()
        {

        }
        public Component(GameObject gameObject)
        {

        }

    }
}
