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
        private readonly Timer startSec;
        bool IsStarving = true;
        bool IsThirsty = true;
        bool IsWantToPlay = true;
        public bool IsAlive = true; 

        string name;
        int hunger;
        int thirst;
        int mood;
        int age; 

        public string Name { get; }
        public int Age { set; get; }
        public int Thirst { set; get; }
        public int Mood { set; get; }
        public int Hunger { set; get; }
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
            if ((IsThirsty) && (IsAlive))
            {
                Console.WriteLine("Drinking...");
                startDeathTimer.Enabled = false;
                startThirstyTimer.Enabled = true;
                thirst = 20;
            }
        }

        public void eat()
        {
            if ((IsStarving) && (IsAlive))
            {
               Console.WriteLine("Eating...");
               startDeathTimer.Enabled = false;
               startStarvingTimer.Enabled = true;
               hunger = 25;
            }
        }
        public void play()
        {
            if ((IsWantToPlay) && (IsAlive))
            {
                Console.WriteLine("Playing...");
                startDeathTimer.Enabled = false;
                startWantToPlayTimer.Enabled = true;
                mood = 30;
            }
        }
        public virtual void speak()
        {
            if (IsAlive)
                Console.WriteLine("Speaking...");
        }

        public void life()
        {
            this.age++;
            this.hunger--;
            this.thirst--;
            this.mood--;
            startSec.Enabled = true;
        }

        public void Print()
        {
            Console.WriteLine(" ");
            Console.Write("возраст зверька - ");
            Console.Write(this.age);

            Console.WriteLine(" ");
            Console.Write("голод зверька - ");
            Console.Write(this.hunger);

            Console.WriteLine(" ");
            Console.Write("жажда зверька - ");
            Console.Write(this.thirst);

            Console.WriteLine(" ");
            Console.Write("настроение зверька - ");
            Console.Write(this.mood);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }

        private void StartStarving(object? sender, ElapsedEventArgs e)
        {
            startStarvingTimer.Enabled = false;
            Console.WriteLine(" ");
            Console.WriteLine("ГАААААЛЯЯЯЯЯЯЯЯЯЯЯ ЖРААААААААААААААТЬ!!!");
            startDeathTimer.Enabled = true;
        }
        private void StartThirsty(object? sender, ElapsedEventArgs e)
        {
            startThirstyTimer.Enabled = false;
            Console.WriteLine(" ");
            Console.WriteLine("ГАААААЛЯЯЯЯЯЯЯЯЯЯЯ ПИИИИИИИИИИИИИИИТЬ!!!");
            startDeathTimer.Enabled = true;
        }
         private void StartWantToPlay(object? sender, ElapsedEventArgs e)
        {
            startWantToPlayTimer.Enabled = false;
            Console.WriteLine(" ");
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

        private void StartSec(object? sender, ElapsedEventArgs e)
        {
            if (IsAlive)
            {
                life();
            }
        }
        public TestAnimal(string name)
        {
            this.name = name;
            age = 0;

            this.startStarvingTimer = new Timer(15000);
            startStarvingTimer.Elapsed += StartStarving;
            startStarvingTimer.Enabled = true;
            hunger = 25;

            this.startThirstyTimer = new Timer(10000);
            startThirstyTimer.Elapsed += StartThirsty;
            startThirstyTimer.Enabled = true;
            thirst = 20;

            this.startWantToPlayTimer = new Timer(20000);
            startWantToPlayTimer.Elapsed += StartWantToPlay;
            startWantToPlayTimer.Enabled = true;
            mood = 30;

            this.startDeathTimer = new Timer(10000);
            startDeathTimer.Elapsed += StartDeath;

            this.startSec = new Timer(1000);
            startSec.Elapsed += StartSec;
            startSec.Enabled = true;
        }

        
    }
}