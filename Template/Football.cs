using System;

public class Football : Game
{
    public override void endPlay()
    {
        Console.WriteLine("Football Game Finished!");
    }

    public override void initialize()
    {
        Console.WriteLine("Football Game Initialized!");
    }

    public override void startPlay()
    {
        Console.WriteLine("Football Game Started. Enjoy the game!");
    }
}