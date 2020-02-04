using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Wizard : MagicUsingCharacter
    {
        //fields
        //properties
        public int SpellNumber { get; set; }

        //constructors
        public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
            SpellNumber = _spellNumber;

        }
        //methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
    }
}
