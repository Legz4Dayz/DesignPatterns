using System;

public class Rectangle : Shape {
    public Rectangle(){
        type = "Rectangle";
    }

    public override void draw()
    {
        Console.WriteLine("Inside Rectangel::draw() method.");
    }
}