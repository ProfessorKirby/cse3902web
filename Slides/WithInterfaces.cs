
ArrayList controllerList;
ISprite marioSprite;
		
protected override void Initialize()
{
	controllerList = new ArrayList();
	controllerList.Add(new KeyboardController(this));
	controllerList.Add(new GamepadController(this));
}

protected override void LoadContent()
{
	marioSprite = new StandingInPlaceMarioSprite();
}
		
protected override void Update(GameTime gameTime)
{
    foreach(IController controller in controllerList)
    {
        controller.Update();
    }

    marioSprite.Update();
}