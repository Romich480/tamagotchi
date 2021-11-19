using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите животное");
            Console.WriteLine("1> Лиса");
            Console.WriteLine("2> Бобр");
            Console.WriteLine("3> Кот");
            Console.WriteLine("4> Гусь");
            string choanimal0 = Console.ReadLine();
            int choanimal = int.Parse(choanimal0);
            TestAnimal animal;
            if (choanimal == 1)
            {
                animal = new Fox("лиса");
            }
            else if (choanimal == 2)
            {
                animal = new Beaver("бобр");
            }
            else if (choanimal == 3)
            {
                animal = new Cat("киса");
            }
            else 
            {
                animal = new Goose("гусь");
            }
            int cycle = 0;
            while (cycle != 69)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1> Попросить поговорить");
                Console.WriteLine("2> Покормить");
                Console.WriteLine("3> Напоить");
                Console.WriteLine("4> Убить");
                Console.WriteLine("5> Закончить игру");
                string choise0 = Console.ReadLine();
                int choise = int.Parse(choise0);
                if (choise == 1)
                {
                    animal.speak();
                }
                else if (choise == 2)
                {
                    animal.eat();
                }
                else if (choise == 3)
                {
                    animal.drink();
                }
                else if (choise == 4)
                {
                    animal.die();
                    cycle = 69;
                }
                else
                {
                    cycle = 69;
                }
            }
        }
    }
}