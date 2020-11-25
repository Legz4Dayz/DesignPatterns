using System;

public class ConsoleLogger : AbstractLogger {
    protected override void write(string message)
    {
        Console.WriteLine("Console::Logger: " + message);
    }

    public ConsoleLogger(int level): base(level){
    }
}