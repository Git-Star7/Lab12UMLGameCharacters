using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    abstract class GameCharacter
    {
        //fields
        //properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        //constructors

        //methods
        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }
    }
}
