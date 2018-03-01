using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    public class Transform //Skal være public ellers kan man ikke nå den i GameObject
    {
        private Vector2 position;

        public Vector2 Position//Skal skabe adgang til field "position"
        {
            get { return position; }
            set { position = value; }

            //Sætter position for vores sprite til player

        }
        //Sætter position for vores sprite til player
        public Transform(GameObject gameObject, Vector2 position)
        {

        }
        //Skal gøre det lettere at flytte vores gameobject
        public void Translate(Vector2 translate)
        {
            position += translate;
        }
    }
}
