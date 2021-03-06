﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Serious_Beards
{
    public class Character : GameObject
    {
        GameObject go;

        Vector2 position;
        Texture2D sprite;

        float speed;
        int health;
        Vector2 facingDirecction;
        int Damage;
        float attackSpeed;
        Vector2 moveTarget;
        Rectangle attackRectangle;

        public Character(Vector2 position, Texture2D sprite) : base(position, sprite)
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

            base.Draw(gameTime);
        }
    }
}
