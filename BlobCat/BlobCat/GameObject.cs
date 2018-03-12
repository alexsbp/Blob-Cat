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

        public Texture2D Sprite { get => sprite; set => sprite = value; }
        public float Layer { get => layer; set => layer = value; }
        public float Scale { get => scale; set => scale = value; }

        float layer;
        private float scale;  

		public GameObject(Texture2D sprites, Vector2 pos, float layers, float scale)
		{
			this.Sprite = sprites;
			this.position = pos;
			this.Layer = layers;
            this.Scale = scale;
		}

		public void LoadContent (ContentManager content, string spriteName)
		{
			Sprite = content.Load<Texture2D>(spriteName); 
		}

		public virtual void Update()
		{

		}

		public virtual void Draw (SpriteBatch spriteBatch)
		{
            spriteBatch.Draw(Sprite, position, null, Color.White, 0f, Vector2.Zero, Scale, SpriteEffects.None, Layer);

		}

    }
}
