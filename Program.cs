using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Fox fox = new Fox("лиса");
            fox.speak();
            Beaver beaver = new Beaver("валера");
            beaver.speak();
            Cat cat = new Cat("киса");
            cat.speak();
            Goose goose = new Goose("гусь");
            goose.speak();
            goose.die();
        }
    }
}
