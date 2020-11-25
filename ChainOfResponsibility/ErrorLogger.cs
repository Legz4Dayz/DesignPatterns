using System;

public class ErrorLogger : AbstractLogger {
    public ErrorLogger(int level):base(level){
    }

    protected override void write(string message)
    {
        Console.WriteLine("Error::Logger: " + message);
    }

}