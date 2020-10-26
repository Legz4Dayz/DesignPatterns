using System;

namespace abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = ShapeFactoryProducer.getRoundedFactory(false);

            Shape shape1 = shapeFactory.getShape("RECTANGLE");
            shape1.draw();

            Shape shape2 = shapeFactory.getShape("SQUARE");
            shape2.draw();

            AbstractFactory shapeFactory1 = ShapeFactoryProducer.getRoundedFactory(true);
            Shape shape3 = shapeFactory1.getShape("RECTANGLE");
            shape3.draw();

            Shape shape4 = shapeFactory1.getShape("SQUARE");
            shape4.draw();

        }
    }
}
