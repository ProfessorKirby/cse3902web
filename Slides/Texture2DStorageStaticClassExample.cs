namespace ObjectManagementExamples
{
	public static class Texture2DStorage
	{
		// Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
		private static Texture2D goombaSpriteSheet;
		private static Texture2D koopaSpriteSheet;
		// More private static Texture2D fields follow
		// ...

		// static classes have no constructor, but we need a method to initialize the Texture2D fields
		public static LoadAllTextures(ContentManager content)
		{
			goombaSpriteSheet = content.Load<Texture2D>("goomba");
			// More Content.Load calls follow
			//...
		}

		public static UnloadAllTextures()
		{ 
			// unload all the Texture2Ds - not needed for the scope of this project
		}

		public static Texture2D GetGoombaSpriteSheet()
		{
			return goombaSpriteSheet;
		}
		
		public static Texture2D GetKoopaSpriteSheet()
		{
			return koopaSpriteSheet;
		}
		
		// More public static Texture2D returning methods follow
		// ...
		
	}
}

// Client code in main game class' LoadContent method:
Texture2DStorage.LoadAllTextures(Content);

// Client code in GoombaSprite class' constructor:
Texture2D spriteSheet = Texture2DStorage.GetGoombaSpriteSheet();