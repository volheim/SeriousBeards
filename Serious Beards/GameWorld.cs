using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Serious_Beards
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        private List<GameObject> gameObjects;
        private List<Enemy> enemyList;
        static Player player;
        protected float deltatime;

        private Camera camera;

        private static int screenHeight;

        private static int screenWidth;

        public static int ScreenHeight
        {
            get { return screenHeight; }
            set { screenHeight = value; }
        }
        public static int ScreenWidth
        {
            get { return screenWidth; }
            set { screenWidth = value; }
        }

        World world;

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //Går ind og kikker på størrelsen af ens GraphicsDevice på den enkelte computer og udvider skærmen til dens bredte og højde.
            ScreenHeight = graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            ScreenWidth = graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            graphics.ApplyChanges();

            
            world = new World();//Skaber en ny verden
            gameObjects = new List<GameObject>();
            enemyList = new List<Enemy>();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Tile.Content = Content;

            world.GenerateMap(new int[,]
            {
                //{ 1,1,1,1,1,1},
                //{ 1,1,1,1,1,1},
                //{ 1,1,1,1,1,1},
                //{ 1,1,1,1,1,1},
                { 1,1,1,1,1,1},
                { 1,1,1,1,1,1},
                { 1,1,1,1,1,1},
            }, 64); //Size er størrelsen på tiles i pixel aka 64 hen a Y aksen og X aksen som bruges i World generation

            //GameObject gameObject = new GameObject(); //Laver et nyt gameobject
            player = new Player(new Vector2(25, 15), Content.Load<Texture2D>("ThreadPool"));

            enemyList.Add(new Enemy(new Vector2(100, 50), Content.Load<Texture2D>("ThreadPool"), 5, 3, 1, 1.5f, 1, 0));

            camera = new Camera();

            //gameObjects.Add(gameObject);
            // TODO: use this.Content to load your game content here
            base.LoadContent();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            camera.Follow();
            // TODO: Add your update logic here

            foreach(Enemy enemy in enemyList)
            {
                enemy.Update(gameTime);
            }

            deltatime = (float)gameTime.ElapsedGameTime.TotalSeconds; //Skal sikre at vores movement er independent af frame rate

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(transformMatrix: camera.Transform);
            world.Draw(spriteBatch);

            player.Draw(spriteBatch);

            foreach(Enemy enemy in enemyList)
            {
                enemy.Draw(spriteBatch);
            }
            spriteBatch.End();
            // TODO: Add your drawing code here

            
        }

    }
}
