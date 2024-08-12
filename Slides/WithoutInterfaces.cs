
enum MarioSpriteState {StandingInPlaceMario, RunningInPlaceMario, DeadMarioMovingUpAndDown, RunningLeftAndRightMario };
MarioSpriteState mySpriteState = MarioSpriteState.StandingInPlaceMario;
int currentFrame = 0;
int totalFrames = 1;
int yPos = 0;
int xPos = 0;
bool movingUp = false;
bool movingLeft = false;

protected override void Update(GameTime gameTime)
{
	if (GamePad.GetState(PlayerIndex.One).Buttons.Start == ButtonState.Pressed)
	{
		this.Exit();
	}
	else if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
	{
		mySpriteState = MarioSpriteState.StandingInPlaceMario;
		currentFrame = 0;
		totalFrames = 1;
		movingUp = false;
		movingLeft = false;
	}
	else if (GamePad.GetState(PlayerIndex.One).Buttons.B == ButtonState.Pressed)
	{
		mySpriteState = MarioSpriteState.RunningInPlaceMario;
		currentFrame = 0;
		totalFrames = 3;
		movingUp = false;
		movingLeft = false;
	}
	else if (GamePad.GetState(PlayerIndex.One).Buttons.X == ButtonState.Pressed)
	{
		mySpriteState = MarioSpriteState.DeadMarioMovingUpAndDown;
		currentFrame = 0;
		totalFrames = 1;
		movingUp = true;
		movingLeft = false;
	}	
	else if (GamePad.GetState(PlayerIndex.One).Buttons.Y == ButtonState.Pressed)
	{
		mySpriteState = MarioSpriteState.RunningLeftAndRightMario;
		currentFrame = 0;
		totalFrames = 3;
		movingUp = false;
		movingLeft = true;
	}
	
	if (Keyboard.GetState().IsKeyDown(Keys.Q))
	{
		this.Exit();
	}
	else if (Keyboard.GetState().IsKeyDown(Keys.W))
	{
		mySpriteState = MarioSpriteState.StandingInPlaceMario;
		currentFrame = 0;
		totalFrames = 1;
		movingUp = false;
		movingLeft = false;
	}
	else if (Keyboard.GetState().IsKeyDown(Keys.E))
	{
		mySpriteState = MarioSpriteState.RunningInPlaceMario;
		currentFrame = 0;
		totalFrames = 3;
		movingUp = false;
		movingLeft = false;
	}
	else if (Keyboard.GetState().IsKeyDown(Keys.R))
	{
		mySpriteState = MarioSpriteState.DeadMarioMovingUpAndDown;
		currentFrame = 0;
		totalFrames = 1;
		movingUp = true;
		movingLeft = false;
	}	
	else if (Keyboard.GetState().IsKeyDown(Keys.T))
	{
		mySpriteState = MarioSpriteState.RunningLeftAndRightMario;
		currentFrame = 0;
		totalFrames = 3;
		movingUp = false;
		movingLeft = true;
	}
	
	switch (mySpriteState)
	{
		case MarioSpriteState.StandingInPlaceMario:
			break;
		case MarioSpriteState.RunningInPlaceMario:
			currentFrame = (currentFrame + 1) % totalFrames;
			break;
		case MarioSpriteState.DeadMarioMovingUpAndDown:
			if (movingUp)
			{
				yPos -= 1;
				if(yPos == 0)
					movingUp = false;
			}
			else
			{
				yPos += 1;
				if (yPos == 10)
					movingUp = true;
			}
			break;
		case MarioSpriteState.RunningLeftAndRightMario:
			currentFrame = (currentFrame + 1) % totalFrames;
			if(movingLeft)
			{
				xPos -= 1;
				if(xPos == 0)
					movingLeft = false;
			}
			else
			{
				xPos += 1;
				if (xPos == 10)
					movingLeft = true;
			}
			break;
	}
}