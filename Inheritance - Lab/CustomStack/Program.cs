using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new List<string>() { "1", "2", "3" });
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
