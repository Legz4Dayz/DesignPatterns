using System;

public class FileLogger : AbstractLogger {
    protected override void write(string message)
    {
        Console.WriteLine("File::Logger: " + message);
    }

    public FileLogger(int level):base(level){
        
    }

}