﻿using System;

namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
       
            Puppy puppy = new Puppy();
            puppy.Bark();
            puppy.Eat();
            puppy.Weep();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
