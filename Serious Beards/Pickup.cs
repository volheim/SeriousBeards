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
    class Pickup : GameObject
    {
        Texture2D sprite;

        int value;
        int healAmmount;
        Int16 type;
        /*
            1. coins
            2. health
            3. weapon
        */
        Int16 weaponIndex;

        public Pickup(Transform transform, Texture2D sprite, int value, int healAmmount, Int16 type, Int16 weaponIndex) : base()
        {
            this.Transform = transform;
            this.sprite = sprite;
            this.value = value;
            this.healAmmount = healAmmount;
            this.type = type;
            this.weaponIndex = weaponIndex;
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
        void Draw(SpriteBatch spriteBatch)
        {
            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }
    }
}
