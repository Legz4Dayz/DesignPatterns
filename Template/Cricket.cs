using System;

public class Cricket : Game
{
    public override void endPlay()
    {
        Console.WriteLine("Cricket Game Finished");
    }

    public override void initialize()
    {
        Console.WriteLine("Cricket Game Initialized.");
    }

    public override void startPlay()
    {
        Console.WriteLine("Cricket Game Started. Enjoy the game!");
    }
}