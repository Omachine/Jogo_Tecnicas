using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Tecnicas.Source { 
    internal abstract class Entity
{
        public Texture2D spritesheet;
        public Vector2 position;
        
        public abstract void Update();

        public abstract void Draw(SpriteBatch spriteBatch);
}
}
