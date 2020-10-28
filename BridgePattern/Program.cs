using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AbstractShape redCircle = new Circle(100, 100, 10, new RedCircle());
            AbstractShape greenCircle = new Circle(200, 80, 40, new GreenCircle());


            redCircle.draw();
            greenCircle.draw();
        }
    }
}
