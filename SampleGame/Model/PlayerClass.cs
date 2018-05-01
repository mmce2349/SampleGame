using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SampleGame
{
	public class PlayerClass
	{
		public PlayerClass()
		{
		}
		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture;
			Position = position;
			Active = true;
			Health = 100;
		}
		public void Update()
		{
		}
		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}
		//Animation representing the player
		private Texture2D playerTexture;
		public Texture2D PlayerTexture
		{
			get { return playerTexture; }
			set { playerTexture = value; }

		}
		//position of the player relative.... to screen
		public Vector2 Position;

		private bool active;
		public bool Active
		{
			get { return active; }
			set { active = value;}

		}
		//amount of hit points 
		private int health;
		public int Health

		{
			get { return health;}
			set { health = value; }

		}
		//width of player ship
		public int Width
		{
			get { return PlayerTexture.Width; }

		}
		//Height
		public int Height
		{
			get { return PlayerTexture.Height; }
		}

	}
}
