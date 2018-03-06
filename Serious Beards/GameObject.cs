using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Serious_Beards
{
    class GameObject : GameWorld
    {
        private Transform transform;

        private List<Component> componentlist; //Skal indeholde de komponeneter der skal loades ud.

        public Transform Transform
        {
            get { return transform; }
            set { transform = value; }
        }

        public void AddComponent(Component component)
        {

        }

        public Component GetComponent(string component)
        {
            //Needs to return something
        }

        public GameObject()
        {
            this.transform = new Transform(this, Vector2.Zero);
            componentlist = new List<Component>();
            AddComponent(transform);
        }

        public void LoadContent(ContentManager content)
        {
            foreach (Component component in componentlist)
            {
                if (component is ILoadable)
                {
                    (component as ILoadable).LoadContent(content);
                }
            }
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
        }



        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            {
                foreach (Component component in componentlist)
                {
                    if (component is IDrawable)
                    {
                        (component as IDrawable).Draw(spriteBatch);
                    }
                }
            }

            base.Draw(gameTime);
        }

    }
}
