using lib;
using System;

namespace ds.test.impl
{
    class Program
    {
        static void Main(string[] args)
{
            IPlugin dev = new AdditionPlugin("Плагин сложения");
            Action Action2 = dev.Run();

            dev = new SubtractionPlugin("Плагин вычитания");
            Action Action = dev.Run();

            Console.ReadLine();
        }
    }
}
