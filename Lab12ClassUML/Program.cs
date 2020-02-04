using System;

namespace Lab12ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] characters = new GameCharacter[]
            {
                new Warrior("Fluphi", 75, 72, "Corruptor Blade"),
                new Warrior("Strawberry", 70, 38, "Dual Cathar Honor Blades"),
                new Wizard("Stormcaller", 15, 100, 95, 2),
                new Wizard("Veshtola", 63, 87, 68, 1),
                new Wizard("Durpz", 12, 100, 85, 4)
            };

            foreach (GameCharacter character in characters)
            {
                character.Play();
                Console.WriteLine();
            }
        }
    }
}
