using System;

public class RedCircle : DrawAPI
{
    public void drawCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing Red Circle: radius: {radius}, x: {x}, y: {y}");
    }
}