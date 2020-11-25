using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");
            robert.sendMessage("hallo");
            john.sendMessage("haaallo");
        }
    }
}
