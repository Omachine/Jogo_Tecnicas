﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Jogo_Tecnicas.Source
{
    internal class Globals
    {
        public static float TotalSeconds { get; set; }

        public static ContentManager Content { get; set; }

        public static SpriteBatch SpriteBatch { get; set; }

        public static void Update(GameTime gt)
        {
            TotalSeconds = (float)gt.TotalGameTime.TotalSeconds;
        }
    }
}
