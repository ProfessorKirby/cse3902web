
public class KillMarioCommand:ICommand
{
	private Game1 myGame;
	
	public KillMarioCommand(Game1 game)
	{
		myGame = game;
	}

	public void Execute()
	{
		myGame.marioSprite = new DeadMarioSprite();
	}
}