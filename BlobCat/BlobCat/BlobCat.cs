using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BlobCat
{
    class BlobCat : GameObject
    {

        public BlobCat(Texture2D sprites, Vector2 pos, float layers, float scale) : base(sprites, pos, layers, scale)
        {

        }

		public override void Update()
		{
			KeyboardState keyState = Keyboard.GetState();

			if (keyState.IsKeyDown(Keys.Space))
			{
				Jump(); 
			}
		}

		public void Jump()
		{

		}
    }
}
