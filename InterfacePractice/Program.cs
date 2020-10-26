using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            A aClass = new A();

            B bClass = new B();

            C cClass = new C(); //Subtype of A (which implements interface1)


            TakesInterface test1 = new TakesInterface(aClass);

            TakesInterface test2 = new TakesInterface(bClass);

            TakesInterface test3 = new TakesInterface(cClass);

            ADecorator adecorator = new ADecorator(aClass);

            Console.WriteLine(test1.printInterface1());

            Console.WriteLine(test2.printInterface1());

            Console.WriteLine(test3.printInterface1());

            Console.WriteLine(adecorator.test1());

        }
    }
}
