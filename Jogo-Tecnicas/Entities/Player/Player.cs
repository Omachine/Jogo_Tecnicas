using Jogo_Tecnicas.Source;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Jogo_Tecnicas.Entities.Player
{
    internal class Player 
    {

        Texture2D _texture;
        Vector2 _position = new (100, 100);
       
        float _speed = 200f;

        private AnimationManager _anim = new();
         
        public Player()
        {
            var PlayerTexture = Globals.Content.Load<Texture2D>("PlayerAll");
            _anim.AddAnimation(new Vector2(0,1),new(PlayerTexture, 8, 8, 0.1f, 1));
        }

        //public void Update()
        //{
        //    if (Keyboard.GetState().IsKeyDown(Keys.A))
        //    {
        //        velocity.X = -speed;
        //    }
        //    else if (Keyboard.GetState().IsKeyDown(Keys.D))
        //    {
        //        velocity.X = speed;
        //    }
        //    if(velocity != Vector2.Zero)
        //        velocity.Normalize();

        //    position += velocity * speed;
        //    velocity = Vector2.Zero;

        //}


        //public void Draw(SpriteBatch spriteBatch)
        //{
        //    spriteBatch.Draw(texture, position, null, Color.White, 0f, Vector2.Zero, 3f, SpriteEffects.None, 0);
        //}
        //public Vector2 velocity;
        //public float playerSpeed = 5f;
        //public Player(Texture2D sprite)
        //{
        //    spritesheet = sprite;
        //    velocity = new Vector2();
        //}

        //public override void Update()
        //{
        //    KeyboardState keyboard = Keyboard.GetState();



        //    if (keyboard.IsKeyDown(Keys.A))
        //    {
        //        velocity.X -= playerSpeed;
        //    }
        //    if (keyboard.IsKeyDown(Keys.D))
        //    {
        //        velocity.X += playerSpeed;
        //    }



        //    //Esta a  haver problemas com o vector2 de velocity
        //    position = velocity;
        //}




        //public override void Draw(SpriteBatch spriteBatch)
        //{
        //    spriteBatch.Draw(spritesheet, position, Color.White);

        //}
    }
}
