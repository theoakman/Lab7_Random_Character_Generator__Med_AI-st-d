using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class Character 
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Health { get; set; }
        public string SpecialAbility { get; set; }

        // AI-assisted: Constructor for initializing character properties.
        public Character(string name, string characterClass, int strength,
                         int agility, int health, string specialAbility)
        {
            Name = name;
            CharacterClass = characterClass;
            Strength = strength;
            Agility = agility;
            Health = health;
            SpecialAbility = specialAbility;
        }


    }
}
