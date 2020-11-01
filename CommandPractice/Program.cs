using System;
using System.Collections.Generic;

namespace Commandpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Light newLight = new Light();
            Light Light2 = new Light();
            List<ICommand> commandList = new List<ICommand>(){
                new LightOnCommand(newLight),
                new LightOnCommand(Light2)
            };

            Invoker invoker = new Invoker(commandList);    //Could be any command as long as it IS-A ICommand

            invoker.clickOn();
            // invoker.clickOff();
            invoker.show();
        }
    }
}
