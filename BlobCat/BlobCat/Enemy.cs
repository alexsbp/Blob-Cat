using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BlobCat
{
    abstract class Enemy : GameObject
    {
        int health; 
	abstract class Enemy : GameObject
	{
		public Enemy(Texture2D sprites, Vector2 pos, float layers) : base(sprites, pos, layers)
		{

		}


	}
}
