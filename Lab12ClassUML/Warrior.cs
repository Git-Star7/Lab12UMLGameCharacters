using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Warrior : GameCharacter
    {
        //fields
        //properties
        public string WeaponType { get; set; }

        //constructors
        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            WeaponType = _weaponType;

        }
        //methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}
