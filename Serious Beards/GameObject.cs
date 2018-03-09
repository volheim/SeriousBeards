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
        private Texture2D sprite;
        public Vector2 position;
        private Transform transform;

        public List<Component> componentlist; //Skal indeholde de komponeneter der skal loades ud.

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
            Component _return = null;
            foreach (Component com in componentlist) //Tjekker listen op med componenets 
            {
                if (com.GetType().Name == component) //Hvis det der er i vores liste er en componenet skal den retunere det tilbage. 
                {
                    _return = com;
                    break;
                }
            }

            return _return;
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
        public virtual void Draw(SpriteBatch spriteBatch)
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
            spriteBatch.Draw(sprite, position, Color.White);
            //base.Draw(SpriteBatch spriteBatch);
        }

    }
}
