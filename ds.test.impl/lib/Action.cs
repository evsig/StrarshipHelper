using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    abstract class Action
    { }

    class AdditionAction : Action
    {
        public AdditionAction()
        {
            Console.WriteLine("Результат сложения");
        }
    }
    class SubtractionAction : Action
    {
        public SubtractionAction()
        {
            Console.WriteLine("Результат вычитания");
        }
    }
}
