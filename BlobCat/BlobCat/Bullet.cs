using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BlobCat
{
	public class Bullet : GameObject
	{
		

		public Bullet(Texture2D sprites, Vector2 pos, float layers, float scale) : base(sprites, pos, layers, scale)
		{

		}
		public override void Update()
		{
			base.position.X += 20;
			if (base.position.X > GameWorld.graphics.PreferredBackBufferWidth * 2)
			{
				GameWorld.usedBullets.Add(this); 
			}
		}
	}
}
