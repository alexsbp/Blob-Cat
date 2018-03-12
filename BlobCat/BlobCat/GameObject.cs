using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobCat
{
	public class GameObject
	{
		Texture2D sprite;
		public Vector2 position;
		public Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}

		float layer;
        private float scale;  

		public GameObject(Texture2D sprites, Vector2 pos, float layers, float scale)
		{
			this.sprite = sprites;
			this.position = pos;
			this.layer = layers;
            this.scale = scale;
		}

		public void LoadContent (ContentManager content, string spriteName)
		{
			sprite = content.Load<Texture2D>(spriteName); 
		}

		public virtual void Update()
		{

		}

		public virtual void Draw (SpriteBatch spriteBatch)
		{
            spriteBatch.Draw(sprite, position, null, Color.White, 0f, position, scale, SpriteEffects.None, layer);

		}

    }
}
