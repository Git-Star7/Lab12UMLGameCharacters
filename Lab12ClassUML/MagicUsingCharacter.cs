using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    abstract class MagicUsingCharacter : GameCharacter
    {
        //fields
        //properties
        public int MagicalEnergy { get; set; }

        //constructors
        
        //methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
