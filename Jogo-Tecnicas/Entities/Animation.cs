using Jogo_Tecnicas.Source;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Tecnicas.Entities
{
    internal class Animation
    {
        private Texture2D _texture;

        private List<Rectangle> _sourceRectangles = new();

        private int _frames;

        private int _frame;

        private float _frameTime;

        private float _frameTimeLeft;

        private bool _active = true;

        //constructor for  animation

        public Animation(Texture2D texture, int frames, float frameTime, bool v)
        {
            _texture = texture;
            _frameTimeLeft = _frameTime;
            _frameTime = frameTime;
            _frames = frames;
            var width = _texture.Width / _frames;
            var height = _texture.Height;

            for (int i = 0; i < _frames; i++)
            {
                _sourceRectangles.Add(new Rectangle(i * width, 0, width, height));
            }
        }
        //methods to start, stop and reset animation

        public void Start()
        {
            _active = true;
        }

        public void Stop()
        {
            _active = false;
        }

        public void Reset()
        {
            _frame = 0;
            _frameTimeLeft = _frameTime;
        }  

        //while the animation is active the update method will process the frame time and move to the next one when ready

        public void Update()
        {
            if (!_active) return;

            _frameTimeLeft -= Globals.TotalSeconds;

            if (_frameTimeLeft <= 0)
            {
              _frameTimeLeft = _frameTime;
              _frame = (_frame + 1) % _frame;
            }
        } 

    

        //draw method of the animation based on the current position and cut out the correct sprime from the spritesheet

        public void Draw(Vector2 position)
        {
            Globals.SpriteBatch.Draw(_texture, position, _sourceRectangles[_frame], Color.White);
        }

      

      



      
       
    }
}
