namespace ObjectManagementExamples
{
	public class EnemySpriteFactory
	{
		private Texture2D goombaSpritesheet;
		private Texture2D koopaSpritesheet;
		// More private Texture2Ds follow
		// ...
		
		private static EnemySpriteFactory instance = new EnemySpriteFactory();
				
		public static EnemySpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}
		
		private EnemySpriteFactory()
		{
		}
			
		public void LoadAllTextures(ContentManager content)
		{
			goombaSpriteSheet = content.Load<Texture2D>("goomba");
			// More Content.Load calls follow
			//...
		}
		
		public ISprite CreateGoombaSprite()
		{
			return new GoombaSprite(goombaSpritesheet, Game1.Instance.level.isAboveGround);
		}
		
		public ISprite CreateKoopaSprite()
		{
			return new KoopaSprite(koopaSpritesheet, 32, 32);
		}
		
		public ISprite CreateGiantKoopaSprite()
		{
			return new KoopaSprite(koopaSpritesheet, 64, 64);
		}
		
		// More public ISprite returning methods follow
		// ...
	}
}

// Client code in main game class' LoadContent method:
EnemySpriteFactory.Instance.LoadAllTextures(Content);

// Client code in Goomba class:
ISprite mySprite = EnemySpriteFactory.Instance.CreateGoombaSprite();