using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Tamagotchi
{
    public abstract class TestAnimal : IAnimal
    {
        private readonly Timer startStarvingTimer;
        private readonly Timer startDeathTimer;
        bool IsStarving = true;
        public bool IsAlive = true; 

        string name;
        int age; 

        public string Name { get; }
        public int Age { get; }
        public void die()
        {
            Console.WriteLine("DIE MAZAFAKA DIE");
            startDeathTimer.Enabled = false;
            startStarvingTimer.Enabled = false;
            IsStarving = false;
            IsAlive = false;
        }

        public void drink()
        {
            if (IsAlive == true)
                Console.WriteLine("Drinking...");
        }

        public void eat()
        {
            if ((IsStarving == true) & (IsAlive == true))
            {
               Console.WriteLine("Eating...");
               startDeathTimer.Enabled = false;
               startStarvingTimer.Enabled = true;
            }
        }

        public virtual void speak()
        {
            if (IsAlive == true)
                Console.WriteLine("Speaking...");
        }

        private void StartStarving(object? sender, ElapsedEventArgs e)
        {
            startStarvingTimer.Enabled = false;
            Console.WriteLine("ГАААААЛЯЯЯЯЯЯЯЯЯЯЯ ЖРААААААААААААААТЬ!!!");
            startDeathTimer.Enabled = true;

        }

        private void StartDeath(object? sender, ElapsedEventArgs e)
        {
            die();
            startDeathTimer.Enabled = false;
        }

        public TestAnimal(string name)
        {
            this.name = name;
            age = 0;

            this.startStarvingTimer = new Timer(10000);
            startStarvingTimer.Elapsed += StartStarving;
            startStarvingTimer.Enabled = true;

            this.startDeathTimer = new Timer(5000);
            startDeathTimer.Elapsed += StartDeath;
        }

        
    }
}