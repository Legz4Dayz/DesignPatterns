using System;

namespace Commandpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Light newLight = new Light();

            Invoker invoker = new Invoker(new LightOnCommand(newLight));    //Could be any command as long as it IS-A ICommand

            invoker.clickOn();
            invoker.clickOff();
            invoker.show();
        }
    }
}
