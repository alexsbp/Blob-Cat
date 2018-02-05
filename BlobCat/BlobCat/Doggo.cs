using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BlobCat
{
	class Doggo : Enemy
    {
        public Doggo(Texture2D sprites, Vector2 pos, float layers, float scale) : base(sprites, pos, layers, scale)
        {

        }
    }
}
