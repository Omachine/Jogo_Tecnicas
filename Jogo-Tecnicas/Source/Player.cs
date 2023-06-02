using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Jogo_Tecnicas.Source
{
    internal class Player:Entity
{
        public Vector2 velocity;
        public float playerSpeed = 5f;
        public Player(Texture2D sprite)
        {
            spritesheet = sprite;
            velocity = new Vector2();
        }
        
        public override void Update()
        {
            KeyboardState keyboard = Keyboard.GetState();

           
          
            if (keyboard.IsKeyDown(Keys.A))
            {
                velocity.X -= playerSpeed;
            }
            if (keyboard.IsKeyDown(Keys.D))
            {
                velocity.X += playerSpeed;
            }



            //Esta a  haver problemas com o vector2 de velocity
            position = velocity;
        }




        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(spritesheet, position, Color.White);

        }
}
}
