using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    public abstract class TestAnimal : IAnimal
    {
        string name;
        int age;

        public string Name { get; }
        public int Age { get; }
        public void die()
        {
            Console.WriteLine("RIP");
        }

        public void drink()
        {
            Console.WriteLine("Drinking...");
        }

        public void eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void speak()
        {
            Console.WriteLine("Speaking...");
        }

        public TestAnimal(string name)
        {
            this.name = name;
            age = 0;
        }
    }
}
