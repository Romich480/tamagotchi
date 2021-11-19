using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    public class Cat : TestAnimal
    {
        public Cat(string name) : base(name)
        {

        }

        public override void speak()
        {
            base.speak();
            Console.WriteLine("мяу");
        }
    }
}