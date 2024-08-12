
KeyboardController keyboardControls;
GamepadController gamepadControls;

StandingInPlaceMarioSprite standingInPlaceMario;
RunningInPlaceMarioSprite runningInPlaceMario;
DeadMovingUpAndDownMarioSprite deadMarioSprite;
RunningLeftAndRightMarioSprite runningMarioSprite;
int currentSprite = 0;

protected override void Initialize()
{
	keyboardControls = new KeyboardController();
	gamepadControls = new GamepadController();
}

protected override void LoadContent()
{
	standingInPlaceMario = new StandingInPlaceMarioSprite();
	runningInPlaceMario = new RunningInPlaceMarioSprite();
	deadMarioSprite = new DeadMovingUpAndDownMarioSprite();
	runningMarioSprite = new RunningLeftAndRightMarioSprite();
}

protected override void Update(GameTime gameTime)
{
	keyboardControls.Update();
	gamepadControls.Update();
	
	if(currentSprite == 0)
	{
		standingInPlaceMario.Update();
	}
	else if(currentSprite == 1)
	{
		runningInPlaceMarioSprite.Update();
	}
	else if(currentSprite == 2)
	{
		deadMarioSprite.Update();
	}
	else
	{
		runningMarioSprite.Update();
	}
}