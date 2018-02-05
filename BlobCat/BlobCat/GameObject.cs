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
    class GameObject
    {
		Texture2D sprite;
		Vector2 position;
		float layer; 

		public GameObject(Texture2D sprites, Vector2 pos, float layers)
		{
			this.sprite = sprites;
			this.position = pos;
			this.layer = layers; 
		}

		public void LoadContent (ContentManager content, string spriteName)
		{
			sprite = content.Load<Texture2D>(spriteName); 
		}

		public void Update()
		{

		}

		public virtual void Draw (SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(this.sprite, this.position, Color.White); 
		}

    }
}
