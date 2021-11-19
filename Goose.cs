using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{

    public class Goose : TestAnimal
    {
        public Goose(string name) : base(name)
        {

        }

        public override void speak()
        {
            base.speak();
            Console.WriteLine("я гусь, можно до вас я доябусь");
        }
    }
}