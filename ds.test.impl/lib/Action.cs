using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    abstract class Action
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }

        public Action(int input1, int input2)
        {
            Input1 = input1;
            Input2 = input2;
        }

    }

    internal class AdditionAction : Action
    {
        public AdditionAction(int input1, int input2) : base(input1, input2)
        {
            var result = input1 + input2;
        }

    }
    
    internal class SubtractionAction : Action
    {
        public SubtractionAction(int input1, int input2) : base(input1, input2)
        {
            var result = input1 - input2;
        }
    }

}
