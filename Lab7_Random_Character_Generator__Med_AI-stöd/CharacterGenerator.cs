using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class CharacterGenerator
    {
        private readonly Random random = new Random();


        // Posible character names, classes, and abilities
        private string[] names = { "Eero Tonitucoor", "Nonsum Homo", "Kronk", "Euranya Atvash", "Lorezeion", "Amin Bidibamin", "Mina Badabina" };
        private string[] classes = { "Warrior", "Mage", "Rouge", "Archer", "Paladin" };
        private string[] abilities = { "Berserk", "Fireball", "Stealth", "Divine Smite", "Shapeshift", "Warp", "Healing" };

    

    public Character GenerateCharacter()
        {
            string name = names[random.Next(names.Length)];
            string characterClass = classes[random.Next(classes.Length)];
            string specialAbility = abilities[random.Next(abilities.Length)];

            int strength = random.Next(1, 21);
            int agility = random.Next(1, 21);
            int health = random.Next(50, 151);

            Character newCharacter = new Character(
                name,
                characterClass, 
                strength,
                agility, 
                health,
                specialAbility
                );

            return newCharacter;
        }
    } 
}

