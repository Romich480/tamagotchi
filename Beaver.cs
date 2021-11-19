using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    public class Beaver : TestAnimal
    {
        public Beaver(string name) : base(name)
        {

        }

        public override void speak()
        {
            base.speak();
            Console.WriteLine("что-то на бобровском");
        }
    }
}