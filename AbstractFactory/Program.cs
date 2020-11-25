using System;

namespace abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Seems like the only meaningful difference between Abstract Factory and Factory Method 
            is that the Abstract factory provides an additional abstraction which can be used in a concretion  
            to create different type of Factories (See FactoryProducer)
            while the Factory Method is just those factories alone. 
            */
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
