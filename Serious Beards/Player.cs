using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Serious_Beards
{
    class Player : Character
    {
        GameWorld gw;

        Transform transform;
        Texture2D sprite;

        static float speed;
        static int health;
        static Vector2 facingDirecction;
        static int Damage;
        static float attackSpeed;
        Vector2 moveTarget;
        Rectangle attackRectangle;
        

        static int money;
        static int points;
        float invulnerabilityTime;

        public Player(Vector2 position, Texture2D sprite) : base(position, sprite)
        {
            this.position = position;
            this.sprite = sprite;
        } 
        

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {


            base.Update(gameTime);
        }

        public void Move()
        {
            Vector2 translation = Vector2.Zero; //Skaber en vector uden nogen værdier
            translation += new Vector2(1, 0); //Siger at translation er det samme som en ny vector med (1,0)

            transform.Translate(translation*deltatime*speed);


        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
