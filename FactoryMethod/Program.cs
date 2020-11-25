using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape shape1 = shapeFactory.GetShape("circle");
            shape1.draw();

            Shape shape2 = shapeFactory.GetShape("rectangle");
            shape2.draw();

            Shape shape3 = shapeFactory.GetShape("square");
            shape3.draw();


        }
    }
}
