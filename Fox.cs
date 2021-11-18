using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    public class Fox : TestAnimal
    {
        public Fox(string name) : base(name)
        {

        }

        public override void speak()
        {
            base.speak();
            Console.WriteLine("ринь-динь-динь");
        }
    }
}
