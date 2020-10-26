using System;

public class Square : Shape
{
    public void draw()
    {
        Console.WriteLine("Square");
        outSide();
    }

    private void outSide(){
        Console.WriteLine("Specific to Square");
    }
}