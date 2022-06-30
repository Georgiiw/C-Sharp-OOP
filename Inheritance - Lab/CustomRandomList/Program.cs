using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList list = new RandomList();

            list.Add("nameOne");
            list.Add("nameTwo");
            list.Add("nameThree");
            list.Add("nameSecret");
            Console.WriteLine(list.RandomString());
        }
    }
}
