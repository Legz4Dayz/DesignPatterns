using System;

public class GreenCircle : DrawAPI
{
    public void drawCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing Green Circle: radius: {radius}, x: {x}, y: {y}");
    }
}