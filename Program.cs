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
            while (animal.IsAlive)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1> Попросить поговорить");
                Console.WriteLine("2> Покормить");
                Console.WriteLine("3> Напоить");
                Console.WriteLine("4> Поиграть");
                Console.WriteLine("5> Показать показатели");
                Console.WriteLine("6> Убить");
                Console.WriteLine("7> Закончить игру");
                Console.WriteLine(" ");
                string choise0 = Console.ReadLine();
                int choise = int.Parse(choise0);
                if (animal.IsAlive)
                {
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
                        animal.play();
                    }
                    else if (choise == 5)
                    {
                        animal.Print();
                    }
                    else if (choise == 6)
                    {
                        animal.die();
                    }
                    else
                    {
                        animal.IsAlive = false;
                    }
                }
                else
                    Console.WriteLine("Зверушка уже померла, теперь живи с этим");
            }
        }
    }
}