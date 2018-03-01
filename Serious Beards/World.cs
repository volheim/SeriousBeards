using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serious_Beards
{
    class World
    {
        private List<CollisionTiles> collisionTiles = new List<CollisionTiles>();
        //Kan bruges til kamera funktion senere
        private int width; //Skal bruges til bredete af tiles
        private int height; //Skal bruges til højde af tiles

        //Skal bruges til collision maybe depending on how we do it
        public List<CollisionTiles> CollisionTiles
        {
            get { return collisionTiles; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public World()
        {
            //Constructor for verden som kan laves videre på
        }

        //Her skabes world i form af int array. Size er størrelsen på vores tiles
        public void GenerateMap(int[,] world, int size)
        {
            //Går igennem mit array på X aksen så længe at X er mindre end 0 og der lægges 1 oven i
            //Samme gøres ved Y aksen
            for (int x = 0; x < world.GetLength(1); x++)
                for (int y = 0; y < world.GetLength(0); y++)
                {
                    int number = world[y, x];
                    //Går ind og skaber en ny tile i vores liste med collision tiles hvis tallet er størrer end 0 i vores Array
                    //Den tilføjer en ny rektangel som er den placering og ganger de forskellige X og Y værder op med tile size.
                    //Alt i alt er det for at sikre at tiles er lige store.
                    //Grundent til at number er ligmed 0 er for at sikre vi har en form for tile man kan gå på.
                    if (number > 0)
                        collisionTiles.Add(new CollisionTiles(number, new Rectangle(x * size, y * size, size, size)));
                    width = (x + 1) * size;
                    height = (y + 1) * size;
                }


        }

    }
}
