using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Tamagotchi
{
    public abstract class TestAnimal : IAnimal
    {
        private readonly Timer startStarvingTimer;
        private readonly Timer startThirstyTimer;
        private readonly Timer startWantToPlayTimer;
        private readonly Timer startDeathTimer;
        bool IsStarving = true;
        bool IsThirsty = true;
        bool IsWantToPlay = true;
        public bool IsAlive = true; 

        string name;
        int age; 

        public string Name { get; }
        public int Age { set; get; }
        public void die()
        {
            Console.WriteLine("DIE MAZAFAKA DIE");
            startDeathTimer.Enabled = false;
            startStarvingTimer.Enabled = false;
            startThirstyTimer.Enabled = false;
            startWantToPlayTimer.Enabled = false;
            IsStarving = false;
            IsAlive = false;
        }

        public void drink()
        {
            if ((IsThirsty) & (IsAlive))
            {
                Console.WriteLine("Drinking...");
                startDeathTimer.Enabled = false;
                startThirstyTimer.Enabled = true;
            }
        }

        public void eat()
        {
            if ((IsStarving) & (IsAlive))
            {
               Console.WriteLine("Eating...");
               startDeathTimer.Enabled = false;
               startStarvingTimer.Enabled = true;
            }
        }
        public void play()
        {
            if ((IsWantToPlay) & (IsAlive))
            {
                Console.WriteLine("Playing...");
                startDeathTimer.Enabled = false;
                startWantToPlayTimer.Enabled = true;
            }
        }
        public virtual void speak()
        {
            if (IsAlive)
                Console.WriteLine("Speaking...");
        }

        private void StartStarving(object? sender, ElapsedEventArgs e)
        {
            startStarvingTimer.Enabled = false;
            Console.WriteLine("ГАААААЛЯЯЯЯЯЯЯЯЯЯЯ ЖРААААААААААААААТЬ!!!");
            startDeathTimer.Enabled = true;
        }
        private void StartThirsty(object? sender, ElapsedEventArgs e)
        {
            startThirstyTimer.Enabled = false;
            Console.WriteLine("ГАААААЛЯЯЯЯЯЯЯЯЯЯЯ ПИИИИИИИИИИИИИИИТЬ!!!");
            startDeathTimer.Enabled = true;
        }
         private void StartWantToPlay(object? sender, ElapsedEventArgs e)
        {
            startWantToPlayTimer.Enabled = false;
            Console.WriteLine("ГАААААЛЯЯЯЯЯЯЯЯЯЯЯ ИГРАААААААААААААТЬ!!!");
            startDeathTimer.Enabled = true;
        }

        private void StartDeath(object? sender, ElapsedEventArgs e)
        {
            if (IsAlive)
            {
                die();
                startDeathTimer.Enabled = false;
            }
        }

        public TestAnimal(string name)
        {
            this.name = name;
            age = 0;

            this.startStarvingTimer = new Timer(15000);
            startStarvingTimer.Elapsed += StartStarving;
            startStarvingTimer.Enabled = true;

            this.startThirstyTimer = new Timer(10000);
            startThirstyTimer.Elapsed += StartThirsty;
            startThirstyTimer.Enabled = true;

            this.startWantToPlayTimer = new Timer(20000);
            startWantToPlayTimer.Elapsed += StartWantToPlay;
            startWantToPlayTimer.Enabled = true;

            this.startDeathTimer = new Timer(10000);
            startDeathTimer.Elapsed += StartDeath;
        }

        
    }
}